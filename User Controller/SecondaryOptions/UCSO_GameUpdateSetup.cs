using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace IwLauncher_Builder.User_Controller.SecondaryOptions
{
    public partial class UCSO_GameUpdateSetup : Form
    {
        public UCSO_GameUpdateSetup()
        {
            InitializeComponent();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // Verify if the creator has updated the values
            if(string.IsNullOrEmpty(tbNewVersion.Text) || string.IsNullOrEmpty(tbCurrentVersion.Text) || tbNewVersion.Text.ToLower() == tbCurrentVersion.Text.ToLower())
            {
                // Show a message that the file will not be created
                MessageBox.Show("The new version equals current version or the new/current version is empty.\nThere's no need to create a update file or you need to save/create a new version.", "IwLauncher Builder");
            }
            else
            {
                try
                {
                    // Create the text file
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwtemp.iwtemp", tbNewVersion.Text);

                    // Encrypt the created file
                    Security.IwEncryptorUse.Encrypt(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwtemp.iwtemp");

                    // Copy the AES file to the desktop
                    File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwtemp.iwtemp.aes", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\IwLB_updateversion.iwlb", true);

                    // Delete temporary files
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwtemp.iwtemp.aes");
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwtemp.iwtemp");

                    // Sets the new version on the IwMV
                    IwMemoryVariables.GameUpdates.GameCurrentVersion = tbNewVersion.Text;

                    // Acquire the memory variables
                    tbCurrentVersion.Text = IwMemoryVariables.GameUpdates.GameCurrentVersion;

                    // Show a message that the file was created
                    MessageBox.Show("The new update version set was created on your desktop with the name \"IwLB_updateversion.iwlb\"\n\nUpload it to your server!", "IwLauncher Builder");
                }
                catch(Exception ex)
                {
                    // Show a message that has the error
                    MessageBox.Show($"There was an error while building the file!\nCheck the errors:\n\n{ex.Message}", "IwLauncher Builder");
                }
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            // Closes the dialog
            this.Close();
        }

        private void UCSO_GameUpdateSetup_Load(object sender, EventArgs e)
        {
            // Acquire the memory variables
            tbCurrentVersion.Text = IwMemoryVariables.GameUpdates.GameCurrentVersion;

            // Verify if the current version is a empty text box
            if(string.IsNullOrEmpty(tbCurrentVersion.Text) || string.IsNullOrWhiteSpace(tbCurrentVersion.Text))
            {
                // Enable version creator
                btnSaveVersion.Enabled = true;
                btnSaveVersion.Visible = true;
            }
            else
            {
                // Disable version creator
                btnSaveVersion.Enabled = false;
                btnSaveVersion.Visible = false;
            }


            // Verify if the user wants to use IwSVR upload
            if(!IwMemoryVariables.UseIWSVRKey && IwMemoryVariables.ValidIwSVRKey)
            {
                // Enable IwSVR upload button
                btnUploadNewVersionSVR.Enabled = false;
                btnUploadNewVersionSVR.Visible = false;
            }
            else
            {
                // Disable IwSVR upload button
                btnUploadNewVersionSVR.Enabled = true;
                btnUploadNewVersionSVR.Visible = true;
            }
        }

        private void tbCurrentVersion_TextChanged(object sender, EventArgs e)
        {
            // Update the memory variables with the game's current version
            IwMemoryVariables.GameUpdates.GameCurrentVersion = tbCurrentVersion.Text;
        }

        private void btnUploadNewVersionSVR_Click(object sender, EventArgs e)
        {
                // Try to upload the file into IwSVR provided key folder
                try
                {
                    // Create the text file
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwtemp.iwtemp", tbNewVersion.Text);

                    // Encrypt the created file
                    Security.IwEncryptorUse.Encrypt(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwtemp.iwtemp");

                    // Delete unencrypted temporary file
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwtemp.iwtemp");

                    // Use webClient to upload file
                    using (WebClient wc = new WebClient())
                    {
                        // Creates a network credential
                        wc.Credentials = new NetworkCredential("u932742831.iwlauncher", "3;[*9pD*");
                        wc.UploadFile("ftp://FTP.IRONIAWN.COM.BR" + $"/{IwMemoryVariables.IWSVRKey.ToUpper()}/{IwMemoryVariables.ProjectName.ToUpper()}.version", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwtemp.iwtemp.aes");
                    }

                    // Sleep the thread to allow time to upload
                    System.Threading.Thread.Sleep(1000);

                    // Delete the temp file
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwtemp.iwtemp.aes");

                    // Sets the new version on the IwMV
                    IwMemoryVariables.GameUpdates.GameCurrentVersion = tbNewVersion.Text;

                    // Acquire the memory variables
                    tbCurrentVersion.Text = IwMemoryVariables.GameUpdates.GameCurrentVersion;

                    // Show a message that the file was uploaded succesfully
                    MessageBox.Show("The version was uploaded with sucess at IwServers!\nThe users will get the new version quickly.", "IwLauncher Builder");
                }
                catch
                {
                    // Show the failure message
                    MessageBox.Show($"Error while sending the information to the IwServers!\nVerify if the provided IwSVR key is valid.", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnSaveVersion_Click(object sender, EventArgs e)
        {
            // Sets the new version on the IwMV
            IwMemoryVariables.GameUpdates.GameCurrentVersion = tbNewVersion.Text;
            // Acquire the memory variables
            tbCurrentVersion.Text = IwMemoryVariables.GameUpdates.GameCurrentVersion;

            // Show a success message
            MessageBox.Show("Version updated!");
        }
    }
}
