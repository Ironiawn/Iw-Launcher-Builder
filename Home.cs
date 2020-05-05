using IwLauncher_Builder.User_Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IwLauncher_Builder
{
    public partial class Home : Form
    {
        enum CurrentSection
        {
            GameUpdatesSetup,
            GameLicensingSetup,
            GameNewsSetup,
            LauncherDesign,
            LauncherAPIIntegrations
        }
        CurrentSection UserSection;

        /// <summary>
        /// This timer will check the user state on the DB
        /// </summary>
        Timer UserChecking = new Timer();

        public Home()
        {
            InitializeComponent();
        }

        void UpdateSection(CurrentSection section)
        {
            // Update the current user section to the defined
            UserSection = section;

            // Dispose all controls of the hoster
            foreach (Control c in HostingPanel.Controls)
                c.Dispose();

            // Remove every control list inside the hoster
            HostingPanel.Controls.Clear();

            // Disable every button
            btnGameLicensingSetup.BackColor = Color.Black;
            btnGameNewsSetup.BackColor = Color.Black;
            btnGameUpdatesSetup.BackColor = Color.Black;
            btnLauncherAPIIntegrations.BackColor = Color.Black;
            btnLauncherDesign.BackColor = Color.Black;

            // Switch cases to update each section
            switch(section)
            {
                case 0: {

                        // The default case will be the update section
                        btnGameUpdatesSetup.BackColor = Color.Teal;

                        // Add the Game Update user control to the hoster panel
                        IW_UC_GameSetup GameSetupHost = new IW_UC_GameSetup();
                        
                        HostingPanel.Controls.Add(GameSetupHost);

                        break;
                    }
                case CurrentSection.GameLicensingSetup:
                    {
                        // Update the game licensing button
                        btnGameLicensingSetup.BackColor = Color.Teal;

                        // Add the Game Update user control to the hoster panel
                        IW_UC_GameLicensingSetup GameSetupHost = new IW_UC_GameLicensingSetup();

                        HostingPanel.Controls.Add(GameSetupHost);

                        break;
                }
            }
        }

        void GetMessenger(object sender)
        {
            MessageBox.Show(sender.ToString());
        }

        private void btnGameUpdatesSetup_Click(object sender, EventArgs e)
        {
            // Update the section accordingly to the button's name
            UpdateSection(CurrentSection.GameUpdatesSetup); // Change to Game Update
        }

        private void btnGameLicensingSetup_Click(object sender, EventArgs e)
        {
            // Verify the user's licence
            if (IwMemoryVariables.LicenceType == IwMemoryVariables.lType.Professional)
                // Update the section accordingly to the button's name
                UpdateSection(CurrentSection.GameLicensingSetup); // Change to Game Licensing (activation)
            else
                // The user licence doesn't conver this section
                MessageBox.Show("Your licence doesn't cover this feature. Please upgrade to Professional licence.", "IwLauncher Builder");
        }

        private void btnGameNewsSetup_Click(object sender, EventArgs e)
        {
            // Update the section accordingly to the button's name
            UpdateSection(CurrentSection.GameNewsSetup); // Change to Game News (feed)
        }

        private void btnLauncherDesign_Click(object sender, EventArgs e)
        {
            // Update the section accordingly to the button's name
            UpdateSection(CurrentSection.LauncherDesign); // Change to Launcher Design
        }

        private void btnLauncherAPIIntegrations_Click(object sender, EventArgs e)
        {
            // Verify the user's licence
            if (IwMemoryVariables.LicenceType == IwMemoryVariables.lType.Professional)
                // Update the section accordingly to the button's name
                UpdateSection(CurrentSection.LauncherAPIIntegrations); // Change to API Integrations setup
            else
                // The user licence doesn't conver this section
                MessageBox.Show("Your licence doesn't cover this feature. Please upgrade to Professional licence.", "IwLauncher Builder");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            IwMemoryVariables.Usermail = "ironiiawn@gmail.com";
            // Acquires the username
            string uName = IwConnector.RequireValue("USERNAME").ToUpper();

            // Verify if the username is null or empty
            // if it is, there's no user on database
            if (string.IsNullOrEmpty(uName))
            {
                // Show a message to the user and exit the builder
                MessageBox.Show("Your user hasn't been localized on the server.\nIf you believe that this is an error, contact us at Envato Market.", "IwLauncher Builder");
                Application.Exit();
            }
            else
            {
                // Verify if the user isn't blocked
                if(IwConnector.RequireValue("BLOCKED") != "0")
                {
                    // Show a invalid user message and close the application
                    MessageBox.Show("Your user has been deactivated!\nIf your licence has expired you need to renew before continue.\n\nIf your licence hasn't expired, contact us at Envato.", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                // Updates the username
                lbUsername.Text = uName;

                // Acquire the user licence type
                if (IwConnector.RequireValue("LICENCETYPE") == "1")
                {
                    // The user licence is set to PRO
                    lbLicenceType.Text = "PROFESSIONAL LICENCE";

                    // Set the user licence type to professional
                    IwMemoryVariables.LicenceType = IwMemoryVariables.lType.Professional;
                }
                else
                {
                    // The user licence is set to BASIC
                    lbLicenceType.Text = "BASIC LICENCE";

                    // Set the user licence type to basic
                    IwMemoryVariables.LicenceType = IwMemoryVariables.lType.Basic;
                }
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            // Closes the application
            Application.Exit();
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            // Saves all values stored in to IwMV into a project file

            // Create a temporary list
            List<string> IwMV = new List<string>();

            // First values will be the GameUpdate section
            IwMV.Add(IwMemoryVariables.GameUpdates.AllowGameUpdates.ToString()); // Allowance of Game Updates | LINE : 0
            IwMV.Add(IwMemoryVariables.GameUpdates.GameCurrentVersion); // Game's current version | LINE : 1
            IwMV.Add(IwMemoryVariables.IWSVRKey); // User's Ironiawn Server Key | LINE : 2
            IwMV.Add(IwMemoryVariables.GameUpdates.ServerURL); // Game update server file | LINE : 3
            IwMV.Add(IwMemoryVariables.UseIWSVRKey.ToString()); // User wants to use IwServer to store the update file? | LINE : 4
            
            // Second values will be the Project licensing section
            IwMV.Add(IwMemoryVariables.LicenceType == IwMemoryVariables.lType.Professional? IwMemoryVariables.ProjectBuilder : IwMemoryVariables.Usermail); // The project builder (first verify if the user licence is the Professional, and if isn't, stores the usermail) | LINE : 5
            IwMV.Add(IwMemoryVariables.ProjectName); // The project name | LINE : 6
            IwMV.Add(IwMemoryVariables.ValidIwSVRKey.ToString()); // Validation of the IwSVR Key | LINE : 7
            IwMV.Add(IwMemoryVariables.GameLicensing.ProvidedACPKey); // The project ACP Key | LINE : 8
            IwMV.Add(IwMemoryVariables.GameLicensing.UseACPKey.ToString()); // Verify if user wants to use ACP Key | LINE : 9

            // Third values will be the Game Licensing section
            IwMV.Add(IwMemoryVariables.GameLicensing.UseLicenseChecking.ToString()); // Allowance of game license checking | LINE : 10

            // Update lines
            IwMV.Add(IwMemoryVariables.GameLicensing.ServerURLKey); // The IwKey file stored webserver | LINE : 11

            // Store every value into a text file
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwlb.iwlb"))
            {
                // For each line in IwMV, create one in the text
                foreach (string s in IwMV)
                    sw.WriteLine(s);
            }

            // Encrypt the file with AES
            Security.IwEncryptorUse.Encrypt(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwlb.iwlb");

            // Copy the file to the desktop
            File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwlb.iwlb.aes", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\IwLauncherProject.IwLB_Project", true);

            // Delete temporary files
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwlb.iwlb.aes");
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwlb.iwlb");

            // Show the sucess message
            MessageBox.Show("The project file was saved on your desktop with the name \"IwLauncherProject.IwLB_Project\"", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadProject_Click(object sender, EventArgs e)
        {
            // Show the file search dialog
            OpenFileDialog opfd = new OpenFileDialog();
            // Sets the file filter
            opfd.Filter = "IwLauncher Builder Project | *.IwLB_Project";
            // Sets the file dialog title
            opfd.Title = "IwLauncher Builder - Search for a Project";

            // Verify if the user has choosen a file
            if(opfd.ShowDialog() == DialogResult.OK)
            {
                // Try to ecrypt the file
                try
                {
                    // Decrypt file
                    Security.IwEncryptorUse.Decrypt(opfd.FileName, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwlb.iwlb");

                    // Read the file and store it in the IwMV
                    string[] Contents = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwlb.iwlb");

                    // Store the values to the IwMV
                    IwMemoryVariables.GameUpdates.AllowGameUpdates = bool.Parse(Contents[0]); // Store the selection of allowing game updates
                    IwMemoryVariables.GameUpdates.GameCurrentVersion = Contents[1]; // Store the current game version
                    IwMemoryVariables.IWSVRKey = Contents[2]; // Store the IwServer key
                    IwMemoryVariables.GameUpdates.ServerURL = Contents[3]; // Store the game update file server URL
                    IwMemoryVariables.UseIWSVRKey = bool.Parse(Contents[4]); // Store the selection of using IwServer

                    // Stores the project settings
                    IwMemoryVariables.ProjectBuilder = Contents[5]; // Store the project builder
                    IwMemoryVariables.ProjectName = Contents[6]; // Store the project name
                    IwMemoryVariables.ValidIwSVRKey = bool.Parse(Contents[7]); // Store the validation of the IwSVR Key

                    // Stores the project licensing settings
                    IwMemoryVariables.GameLicensing.ProvidedACPKey = Contents[8]; // Store the ACP Key
                    IwMemoryVariables.GameLicensing.UseACPKey = bool.Parse(Contents[9]); // Verify if the user wants to use ACP Key
                    IwMemoryVariables.GameLicensing.ServerURLKey = Contents[11]; // Sets the URL of the server that holds the IwKeys file

                    // Stores the game licensing variables
                    IwMemoryVariables.GameLicensing.UseLicenseChecking = bool.Parse(Contents[10]); // Stores the validation of game licensing marker

                    // Delete temporary file
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwlb.iwlb");

                    // Show success message
                    MessageBox.Show("Your project was loaded successfully!", "IwLauncher Builder");
                }
                catch(Exception ex)
                {
                    // Delete temporary file
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\iwlb.iwlb");

                    // Show error message
                    MessageBox.Show($"Error while opening the project!\n{ex.Message}", "IwLauncher Builder");
                }
            }
        }

        private void btnSetupIwSVR_Click(object sender, EventArgs e)
        {
            // Create a IwSVR setup dialog
            User_Controller.SecondaryOptions.UCSO_SetupSVRKey SVRKey = new User_Controller.SecondaryOptions.UCSO_SetupSVRKey();
            SVRKey.ShowDialog();
        }

        private void btnProjectSetup_Click(object sender, EventArgs e)
        {
            // Create a Project Setup dialog
            User_Controller.SecondaryOptions.UCSO_ProjectSetup PS = new User_Controller.SecondaryOptions.UCSO_ProjectSetup();
            PS.ShowDialog();
        }
    }
}
