using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IwLauncher_Builder.User_Controller
{
    public partial class IW_UC_GameSetup : UserControl
    {
        public IW_UC_GameSetup()
        {
            InitializeComponent();
        }

        private void cbAllowUpdateChecking_CheckedChanged(object sender, EventArgs e)
        {
            // Verify if the group of update settings is enabled
            if(groupServerSetup.Enabled)
            {
                // Update memory variables
                IwMemoryVariables.GameUpdates.AllowGameUpdates = false;

                // Disable it
                groupServerSetup.Enabled = false;

                // Disable update file button
                btnUpdateFileSetup.Enabled = false;
            }
            else
            {
                // Update memory variables
                IwMemoryVariables.GameUpdates.AllowGameUpdates = true;

                // Enable it
                groupServerSetup.Enabled = true;

                // Enable update file button
                btnUpdateFileSetup.Enabled = true;
            }
        }

        private void btnUpdateFileSetup_Click(object sender, EventArgs e)
        {
            // Creates the update file creator dialog
            SecondaryOptions.UCSO_GameUpdateSetup USCO_GUS = new SecondaryOptions.UCSO_GameUpdateSetup();
            USCO_GUS.ShowDialog();
        }

        private void tbUpdateServer_TextChanged(object sender, EventArgs e)
        {
            // Store the server value in IWMV
            IwMemoryVariables.GameUpdates.ServerURL = tbUpdateServer.Text;
        }


        private void IW_UC_GameSetup_Load(object sender, EventArgs e)
        {
            // Get the memory variables
            tbUpdateServer.Text = IwMemoryVariables.GameUpdates.ServerURL; // Update the update url text
            cbAllowUpdateChecking.Checked = IwMemoryVariables.GameUpdates.AllowGameUpdates; // Update the game update allower

            // Create timer to check the IwSVR changes
            Timer iwsvrchanges = new Timer();
            iwsvrchanges.Interval = 500;
            iwsvrchanges.Tick += Iwsvrchanges_Tick;
            iwsvrchanges.Start();
        }

        private void Iwsvrchanges_Tick(object sender, EventArgs e)
        {
            // Verify if the user wants to use the IwSVR option
            if (IwMemoryVariables.UseIWSVRKey && IwMemoryVariables.ValidIwSVRKey)
            {
                // Disable the server provide input
                tbUpdateServer.Text = "Using IwServer version provider";
                tbUpdateServer.Enabled = false;
            }
            else
                // Enable file update server provider
                tbUpdateServer.Enabled = true;
        }
    }
}
