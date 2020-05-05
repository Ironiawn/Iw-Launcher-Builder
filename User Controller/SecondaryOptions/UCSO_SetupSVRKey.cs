using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IwLauncher_Builder.User_Controller.SecondaryOptions
{
    public partial class UCSO_SetupSVRKey : Form
    {
        public UCSO_SetupSVRKey()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            // Closes the dialog
            this.Close();
        }

        private void tbIwSVRKey_TextChanged(object sender, EventArgs e)
        {
            // Store the IwSVRKey value in IWMV
            IwMemoryVariables.IWSVRKey = tbIwSVRKey.Text;
        }

        private void btnTryIwSVRKey_Click(object sender, EventArgs e)
        {
            // Verify if the key has the 25 characters length
            if (tbIwSVRKey.TextLength < 24)
            {
                // Show a invalid key length message
                MessageBox.Show("The provided key seems that isn't a valid key.\n\nThe key can can be like the example below:\nIWSVRK-12584-AIWK1-3K2M7", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Stores the invalid key
                IwMemoryVariables.ValidIwSVRKey = false;

                // Don't execute any function
                return;
            }
            // Try to get the keyfile
            try
            {
                // Try to download the key from IwServers
                WebClient wc = new WebClient();

                // Read the contents of the acquired file
                string curKey = wc.DownloadString("https://www.ironiawn.com.br/Launcher" + $" Builder/{tbIwSVRKey.Text}.IwSVR_Key");

                // Compare the provided key to the text file
                if (curKey.ToLower() == tbIwSVRKey.Text.ToLower())
                {
                    // Show a valid message key
                    MessageBox.Show("The provided IwSVR Key is valid and can be used at production!", "IwLauncher Builder");

                    // Stores the valid key
                    IwMemoryVariables.ValidIwSVRKey = true;
                }
                else
                {
                    // Show a invalid message key
                    MessageBox.Show("The provided IwSVR Key isn't valid.", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Stores the invalid key
                    IwMemoryVariables.ValidIwSVRKey = false;
                }
            }
            catch // File wasn't located on the server
            {
                // Show a invalid message key
                MessageBox.Show("The provided IwSVR Key isn't valid.", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Stores the invalid key
                IwMemoryVariables.ValidIwSVRKey = false;
            }
        }

        private void UCSO_SetupSVRKey_Load(object sender, EventArgs e)
        {
            // Acquires the project stored values
            cbUseIwSVR.Checked = IwMemoryVariables.UseIWSVRKey; // Update the IwSVR allower
            tbIwSVRKey.Text = IwMemoryVariables.IWSVRKey; // Update the IwSVR Key text

            // Verify if the IwAWS Server checker has been checked
            if (!cbUseIwSVR.Checked)
            {
                // Update the IwSVR option in IwMV
                IwMemoryVariables.UseIWSVRKey = false;

                // Uncheck the marker
                cbUseIwSVR.Checked = false;

                // Disable it all
                lbSVRPoweredKey.Enabled = false;
                tbIwSVRKey.Enabled = false;
                btnTryIwSVRKey.Enabled = false;
            }
            else
            {
                // Update the IwSVR option in IwMV
                IwMemoryVariables.UseIWSVRKey = true;

                // Check the marker
                cbUseIwSVR.Checked = true;

                // Enable it all
                lbSVRPoweredKey.Enabled = true;
                tbIwSVRKey.Enabled = true;
                btnTryIwSVRKey.Enabled = true;
            }
        }

        private void cbUseIwSVR_MouseClick(object sender, MouseEventArgs e)
        {
            // Verify if the IwAWS Server key has been shown
            if (!cbUseIwSVR.Checked)
            {
                // Update the IwSVR option in IwMV
                IwMemoryVariables.UseIWSVRKey = false;

                // Uncheck the marker
                cbUseIwSVR.Checked = false;

                // Disable it all
                lbSVRPoweredKey.Enabled = false;
                tbIwSVRKey.Enabled = false;
                btnTryIwSVRKey.Enabled = false;
            }
            else
            {
                // Update the IwSVR option in IwMV
                IwMemoryVariables.UseIWSVRKey = true;

                // Check the marker
                cbUseIwSVR.Checked = true;

                // Enable it all
                lbSVRPoweredKey.Enabled = true;
                tbIwSVRKey.Enabled = true;
                btnTryIwSVRKey.Enabled = true;
            }
        }

        private void btnBuyKey_Click(object sender, EventArgs e)
        {
            // Show a message warning tha the user will be redirected to the Ironiawn's website
            if (MessageBox.Show("You'll be directed to the Ironiawn's shop.\nThere you can get a IwServer key.\n\nAfter the purchase, the key will be enabled at the server in the next 24 hours.", "IwLauncher Builder", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                // Open the website page
                System.Diagnostics.Process.Start("https://www.ironiawn.com.br");
        }
    }
}
