using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IwLauncher_Builder.User_Controller.SecondaryOptions
{
    public partial class UCSO_ProjectSetup : Form
    {
        public UCSO_ProjectSetup()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            // Closes the dialog
            this.Close();
        }

        private void UCSO_ProjectSetup_Load(object sender, EventArgs e)
        {
            // Acquires the informations from IwMV
            tbProjectDeveloper.Text = IwMemoryVariables.LicenceType == IwMemoryVariables.lType.Professional? IwMemoryVariables.ProjectBuilder : IwMemoryVariables.ProjectBuilder != IwMemoryVariables.Usermail? IwMemoryVariables.ProjectBuilder : IwMemoryVariables.Usermail; // The developer of the project
            tbProjectName.Text = IwMemoryVariables.ProjectName; // The name of the project

            // Verify if the user licence is the professional
            if (IwMemoryVariables.LicenceType != IwMemoryVariables.lType.Professional)
                // Disable the developer name change
                tbProjectDeveloper.Enabled = false;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            // Apply the settings to the IwMV
            IwMemoryVariables.ProjectBuilder = tbProjectDeveloper.Text; // Apply the developer of the project at IwMV
            IwMemoryVariables.ProjectName = tbProjectName.Text; // Apply the project name to the project IwMV

        }
    }
}
