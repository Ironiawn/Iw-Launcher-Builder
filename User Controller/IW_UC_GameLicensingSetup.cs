using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IwLauncher_Builder.User_Controller
{
    public partial class IW_UC_GameLicensingSetup : UserControl
    {

        public IW_UC_GameLicensingSetup()
        {
            InitializeComponent();
        }

        private void btnCreateKeysFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Set list that will contains the keys
                List<string> keys = new List<string>();

                // Creates a addon for the password
                string addonpw = "";

                // Verify if the user is using IwSVR
                if (IwMemoryVariables.UseIWSVRKey)
                    // If the user is using, add to the addon password the usermail and IwSVR key
                    addonpw = IwMemoryVariables.IWSVRKey + "$#@" + IwMemoryVariables.Usermail;

                // For each input line, encrypt the string and add to the keys list
                foreach (string s in tbLicenceKeys.Lines)
                    // Encrypt and add
                    keys.Add(Security.IwEncryptorString.Encrypt(s, "IWLAUNCHER_KEYS$#!1742/23a2sd0x0#51a!@151*&122d(~][ejxa)" + addonpw));

                // Write to a text file
                foreach (string s in keys)
                {
                    // Write line
                    File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwk.iwk", s + Environment.NewLine);
                }

                // Encrypt the temporary key using AES
                Security.IwEncryptorUse.Encrypt(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwk.iwk");

                // Delete temporary text file with secured keys
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwk.iwk");

                // Copy the AES generated file to the desktop
                File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwk.iwk.aes", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\IwGenerated Keys.IwKeys", true);

                // Delete temporary AES generated keys file
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwk.iwk.aes");

                // Clear the keys (for security)
                keys.Clear();

                // Show a success message
                MessageBox.Show("The Keys file was saved on your desktop with the name \"IwGenerated Keys.IwKeys\"!\n\nUpload it to your server and set it up at \"Server URL Key\" option.", "IwLauncher Builder");
            }
            catch
            {
                // Show an error message
                MessageBox.Show("There was an error while saving the Keys file.\nTry again later.", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadKeysFile_Click(object sender, EventArgs e)
        {
            // Show a open file dialog
            OpenFileDialog opfd = new OpenFileDialog();

            // Set the title
            opfd.Title = "IwLauncher Builder - Load Keys File";

            // Set the filter
            opfd.Filter = "IwKeys File | *.IwKeys";


            // Verify if the user has choosen a file
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                // Try to decrypt the file
                try
                {
                    // Creates a addon for the password
                    string addonpw = "";

                    // Verify if the user is using IwSVR
                    if (IwMemoryVariables.UseIWSVRKey)
                        // If the user is using, add to the addon password the usermail and IwSVR key
                        addonpw = IwMemoryVariables.IWSVRKey + "$#@" + IwMemoryVariables.Usermail;

                    // Decrypt using AES
                    Security.IwEncryptorUse.Decrypt(opfd.FileName, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp.iwk");

                    // Read the file contents
                    string[] Contents = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp.iwk");

                    // Create a list of string
                    string[] dContents = Contents;
                    
                    // Decrypt every content of the file
                    for(int i = 0; i < Contents.Length; i++) { 
                        // Add the decrypted content in the temporary list
                        dContents[i] = Security.IwEncryptorString.Decrypt(Contents[i], "IWLAUNCHER_KEYS$#!1742/23a2sd0x0#51a!@151*&122d(~][ejxa)" + addonpw);
                    }

                    // Sets the input to the decrypted content text
                    tbLicenceKeys.Lines = dContents;

                    // Show a success message
                    MessageBox.Show("The provided keys file storage has been loaded!", "IwLauncher Builder");
                }
                catch
                {
                    // Show a error message
                    MessageBox.Show($"The provided keys file hasn't been loaded. Make sure that is a compatible file or if you are using a correct account and IwSVR Key.", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbUseLicesingValidation_MouseClick(object sender, MouseEventArgs e)
        {
            // Verify if the group is enabled
            if(groupLicenseKeys.Enabled)
            {
                // Update memory variables
                IwMemoryVariables.GameLicensing.UseLicenseChecking = false;

                // Disable it
                groupLicenseKeys.Enabled = false;

                // Disable other things like buttons
                btnCreateKeysFile.Enabled = false;
                btnLoadKeysFile.Enabled = false;

                // Disable the ACP options
                cbUseAccountValidation.Enabled = false;
                btnTryACPKey.Enabled = false;
                tbACPKey.Enabled = false;
            }
            else
            {
                // Update memory variables
                IwMemoryVariables.GameLicensing.UseLicenseChecking = true;

                // Enable it
                groupLicenseKeys.Enabled = true;

                // Enable other things like buttons
                btnCreateKeysFile.Enabled = true;
                btnLoadKeysFile.Enabled = true;

                // Enable the ACP options
                cbUseAccountValidation.Enabled = true;
            }
        }

        private void IW_UC_GameLicensingSetup_Load(object sender, EventArgs e)
        {
            // Update the keys that are on the memory variables
            tbLicenceKeys.Lines = IwMemoryVariables.GameLicensing.GameKeys;

            // Update the server URL key stored at IwMV
            tbServerURLKey.Text = IwMemoryVariables.GameLicensing.ServerURLKey;

            // Verify if the user wants to use licensing
            if (!IwMemoryVariables.GameLicensing.UseLicenseChecking)
            {
                // Disable it
                groupLicenseKeys.Enabled = false;

                // Uncheck the marker
                cbUseLicesingValidation.Checked = false;

                // Disable other things like buttons
                btnCreateKeysFile.Enabled = false;
                btnLoadKeysFile.Enabled = false;

                // Disable the ACP options
                cbUseAccountValidation.Enabled = false;
                btnTryACPKey.Enabled = false;
                tbACPKey.Enabled = false;
            }
            else { 
                // Enable it
                groupLicenseKeys.Enabled = true;

                // Check the marker
                cbUseLicesingValidation.Checked = true;

                // Enable other things like buttons
                btnCreateKeysFile.Enabled = true;
                btnLoadKeysFile.Enabled = true;

                // Enable the ACP options
                cbUseAccountValidation.Enabled = true;
            }

            // Verify if the user wants to use Account Product Validation feature
            if(IwMemoryVariables.GameLicensing.UseACPKey)
            {
                // Mark the checkbox of ACP
                cbUseAccountValidation.Checked = true;

                // Set the provided text at the input
                tbACPKey.Text = IwMemoryVariables.GameLicensing.ProvidedACPKey;

                // Enables the ACP options
                tbACPKey.Enabled = true;
                btnTryACPKey.Enabled = true;
            }
            else
            {
                // Uncheck the checkbox of ACP
                cbUseAccountValidation.Checked = false;

                // Set the provided text at the input
                tbACPKey.Text = IwMemoryVariables.GameLicensing.ProvidedACPKey;

                // Disable the ACP options
                btnTryACPKey.Enabled = false;
                tbACPKey.Enabled = false;
            }
        }

        private void tbLicenceKeys_TextChanged(object sender, EventArgs e)
        {
            // Update the keys on the memory variables
            IwMemoryVariables.GameLicensing.GameKeys = tbLicenceKeys.Lines;
        }

        private void btnTryACPKey_Click(object sender, EventArgs e)
        {
            // Verify the provided ACP key
            if(tbACPKey.Text.Length == 25)
            {
                // Verify at the DB
                if(IwConnector.ValidACPKey(tbACPKey.Text) && IwMemoryVariables.ValidIwSVRKey)
                {
                    // Throw a positive message
                    MessageBox.Show("The provided ACP key is valid!", "IwLauncher Builder");

                    // Store the key at the IwMV
                    IwMemoryVariables.GameLicensing.ProvidedACPKey = tbACPKey.Text;
                }
                else
                {
                    // Verify if the user is using IwSVR
                    if (IwMemoryVariables.ValidIwSVRKey)
                    {
                        // Throw a negative message
                        MessageBox.Show("The provided ACP key is invalid!\nVerify if the logged-in user is the holder of it or if the key exists.", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Throw a negative message
                        MessageBox.Show("The provided ACP key is invalid!\nYour IwSVR key hasn't been validated or is invalid.", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Resets the key at the IwMV
                    IwMemoryVariables.GameLicensing.ProvidedACPKey = "";
                }
            }
            else
            {
                // The length of the key is invalid
                MessageBox.Show("The provided key is invalid!\nCheck the key length.", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Resets the key at the IwMV
                IwMemoryVariables.GameLicensing.ProvidedACPKey = "";
            }
        }

        private void cbUseAccountValidation_MouseClick(object sender, MouseEventArgs e)
        {
            // Verify the provided values
            if(!IwMemoryVariables.GameLicensing.UseACPKey)
            {
                // The user wants to use ACP Key
                // Enable the buttons
                btnTryACPKey.Enabled = true;
                tbACPKey.Enabled = true;

                // Store the variables at the IwMV
                IwMemoryVariables.GameLicensing.UseACPKey = true;
            }
            else
            {
                // The user don't want to use ACP Key
                // Disable the buttons
                btnTryACPKey.Enabled = false;
                tbACPKey.Enabled = false;


                // Store the variables at the IwMV
                IwMemoryVariables.GameLicensing.UseACPKey = false;
            }
        }

        private void tbServerURLKey_TextChanged(object sender, EventArgs e)
        {
            // Set the IwMV variable as the text change
            IwMemoryVariables.GameLicensing.ServerURLKey = tbServerURLKey.Text;
        }

        private void btnTryServer_Click(object sender, EventArgs e)
        {
            // Create a new webclient
            WebClient wc = new WebClient();

            // Verify if the input has http/https
            if (!tbServerURLKey.Text.Contains("http"))
                // Add to it the http option
                tbServerURLKey.Text = "http://" + tbServerURLKey.Text;

            // Try to download the file
            try
            {
                // Create the download handler
                wc.DownloadFile(tbServerURLKey.Text, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\temp.iwlb");

                // Verify if the file exists
                if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\temp.iwlb"))
                {
                    // Read the contents of the file
                    string cont = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\temp.iwlb");

                    // Delete the temporary file
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\temp.iwlb");

                    // Show that the file has been located
                    MessageBox.Show("The file has been located!\nMake sure that you've generated the keys from the IwLauncher Builder before going to production.", "IwLauncher Builder");
                }
                else
                {
                    // Show a error message
                    MessageBox.Show("Provided file doesn't exists.\nStore on a valid server and try again!", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                // Show a invalid server message
                // Show a error message
                MessageBox.Show($"Invalid file location.\nStore on a valid server and try again!", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
