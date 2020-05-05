namespace IwLauncher_Builder
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPoweredBy = new System.Windows.Forms.Label();
            this.Panel_HoldButtons = new System.Windows.Forms.Panel();
            this.btnLauncherAPIIntegrations = new System.Windows.Forms.Button();
            this.btnLauncherDesign = new System.Windows.Forms.Button();
            this.btnGameNewsSetup = new System.Windows.Forms.Button();
            this.btnGameLicensingSetup = new System.Windows.Forms.Button();
            this.btnGameUpdatesSetup = new System.Windows.Forms.Button();
            this.lbAppTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HostingPanel = new System.Windows.Forms.Panel();
            this.lbLicenceType = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.btnLoadProject = new System.Windows.Forms.Button();
            this.btnSetupIwSVR = new System.Windows.Forms.Button();
            this.btnProjectSetup = new System.Windows.Forms.Button();
            this.Panel_HoldButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(212, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(172, 37);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "%Username%";
            // 
            // lbPoweredBy
            // 
            this.lbPoweredBy.AutoSize = true;
            this.lbPoweredBy.BackColor = System.Drawing.Color.Transparent;
            this.lbPoweredBy.Font = new System.Drawing.Font("Segoe UI Light", 15.25F);
            this.lbPoweredBy.ForeColor = System.Drawing.Color.White;
            this.lbPoweredBy.Location = new System.Drawing.Point(12, 578);
            this.lbPoweredBy.Name = "lbPoweredBy";
            this.lbPoweredBy.Size = new System.Drawing.Size(175, 30);
            this.lbPoweredBy.TabIndex = 1;
            this.lbPoweredBy.Text = "© Ironiawn - 2020";
            // 
            // Panel_HoldButtons
            // 
            this.Panel_HoldButtons.BackColor = System.Drawing.Color.Black;
            this.Panel_HoldButtons.Controls.Add(this.btnLauncherAPIIntegrations);
            this.Panel_HoldButtons.Controls.Add(this.btnLauncherDesign);
            this.Panel_HoldButtons.Controls.Add(this.btnGameNewsSetup);
            this.Panel_HoldButtons.Controls.Add(this.btnGameLicensingSetup);
            this.Panel_HoldButtons.Controls.Add(this.btnGameUpdatesSetup);
            this.Panel_HoldButtons.Controls.Add(this.lbAppTitle);
            this.Panel_HoldButtons.Controls.Add(this.lbPoweredBy);
            this.Panel_HoldButtons.Controls.Add(this.pictureBox1);
            this.Panel_HoldButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_HoldButtons.Location = new System.Drawing.Point(0, 0);
            this.Panel_HoldButtons.Name = "Panel_HoldButtons";
            this.Panel_HoldButtons.Size = new System.Drawing.Size(206, 619);
            this.Panel_HoldButtons.TabIndex = 2;
            // 
            // btnLauncherAPIIntegrations
            // 
            this.btnLauncherAPIIntegrations.FlatAppearance.BorderSize = 0;
            this.btnLauncherAPIIntegrations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnLauncherAPIIntegrations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnLauncherAPIIntegrations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLauncherAPIIntegrations.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnLauncherAPIIntegrations.ForeColor = System.Drawing.Color.White;
            this.btnLauncherAPIIntegrations.Image = global::IwLauncher_Builder.Properties.Resources.icons8_api_48;
            this.btnLauncherAPIIntegrations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLauncherAPIIntegrations.Location = new System.Drawing.Point(-3, 417);
            this.btnLauncherAPIIntegrations.Name = "btnLauncherAPIIntegrations";
            this.btnLauncherAPIIntegrations.Size = new System.Drawing.Size(206, 55);
            this.btnLauncherAPIIntegrations.TabIndex = 8;
            this.btnLauncherAPIIntegrations.Text = "LAUNCHER\r\nAPI INTEGRATIONS";
            this.btnLauncherAPIIntegrations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLauncherAPIIntegrations.UseVisualStyleBackColor = true;
            this.btnLauncherAPIIntegrations.Click += new System.EventHandler(this.btnLauncherAPIIntegrations_Click);
            // 
            // btnLauncherDesign
            // 
            this.btnLauncherDesign.FlatAppearance.BorderSize = 0;
            this.btnLauncherDesign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnLauncherDesign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnLauncherDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLauncherDesign.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnLauncherDesign.ForeColor = System.Drawing.Color.White;
            this.btnLauncherDesign.Image = global::IwLauncher_Builder.Properties.Resources.icons8_paint_palette_48;
            this.btnLauncherDesign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLauncherDesign.Location = new System.Drawing.Point(-3, 356);
            this.btnLauncherDesign.Name = "btnLauncherDesign";
            this.btnLauncherDesign.Size = new System.Drawing.Size(206, 55);
            this.btnLauncherDesign.TabIndex = 7;
            this.btnLauncherDesign.Text = "LAUNCHER\r\nDESIGN";
            this.btnLauncherDesign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLauncherDesign.UseVisualStyleBackColor = true;
            this.btnLauncherDesign.Click += new System.EventHandler(this.btnLauncherDesign_Click);
            // 
            // btnGameNewsSetup
            // 
            this.btnGameNewsSetup.FlatAppearance.BorderSize = 0;
            this.btnGameNewsSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnGameNewsSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnGameNewsSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameNewsSetup.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnGameNewsSetup.ForeColor = System.Drawing.Color.White;
            this.btnGameNewsSetup.Image = global::IwLauncher_Builder.Properties.Resources.icons8_megaphone_48;
            this.btnGameNewsSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGameNewsSetup.Location = new System.Drawing.Point(-3, 295);
            this.btnGameNewsSetup.Name = "btnGameNewsSetup";
            this.btnGameNewsSetup.Size = new System.Drawing.Size(206, 55);
            this.btnGameNewsSetup.TabIndex = 6;
            this.btnGameNewsSetup.Text = "GAME\r\nNEWS SETUP";
            this.btnGameNewsSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGameNewsSetup.UseVisualStyleBackColor = true;
            this.btnGameNewsSetup.Click += new System.EventHandler(this.btnGameNewsSetup_Click);
            // 
            // btnGameLicensingSetup
            // 
            this.btnGameLicensingSetup.FlatAppearance.BorderSize = 0;
            this.btnGameLicensingSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnGameLicensingSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnGameLicensingSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameLicensingSetup.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnGameLicensingSetup.ForeColor = System.Drawing.Color.White;
            this.btnGameLicensingSetup.Image = global::IwLauncher_Builder.Properties.Resources.icons8_key_2_48;
            this.btnGameLicensingSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGameLicensingSetup.Location = new System.Drawing.Point(-3, 234);
            this.btnGameLicensingSetup.Name = "btnGameLicensingSetup";
            this.btnGameLicensingSetup.Size = new System.Drawing.Size(206, 55);
            this.btnGameLicensingSetup.TabIndex = 5;
            this.btnGameLicensingSetup.Text = "GAME\r\nLICENSING SETUP";
            this.btnGameLicensingSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGameLicensingSetup.UseVisualStyleBackColor = true;
            this.btnGameLicensingSetup.Click += new System.EventHandler(this.btnGameLicensingSetup_Click);
            // 
            // btnGameUpdatesSetup
            // 
            this.btnGameUpdatesSetup.BackColor = System.Drawing.Color.Black;
            this.btnGameUpdatesSetup.FlatAppearance.BorderSize = 0;
            this.btnGameUpdatesSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnGameUpdatesSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnGameUpdatesSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameUpdatesSetup.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnGameUpdatesSetup.ForeColor = System.Drawing.Color.White;
            this.btnGameUpdatesSetup.Image = global::IwLauncher_Builder.Properties.Resources.icons8_available_updates_48;
            this.btnGameUpdatesSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGameUpdatesSetup.Location = new System.Drawing.Point(-3, 173);
            this.btnGameUpdatesSetup.Name = "btnGameUpdatesSetup";
            this.btnGameUpdatesSetup.Size = new System.Drawing.Size(206, 55);
            this.btnGameUpdatesSetup.TabIndex = 4;
            this.btnGameUpdatesSetup.Text = "GAME\r\nUPDATES SETUP";
            this.btnGameUpdatesSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGameUpdatesSetup.UseVisualStyleBackColor = false;
            this.btnGameUpdatesSetup.Click += new System.EventHandler(this.btnGameUpdatesSetup_Click);
            // 
            // lbAppTitle
            // 
            this.lbAppTitle.AutoSize = true;
            this.lbAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbAppTitle.Font = new System.Drawing.Font("Segoe UI Light", 17.25F);
            this.lbAppTitle.ForeColor = System.Drawing.Color.White;
            this.lbAppTitle.Location = new System.Drawing.Point(6, 111);
            this.lbAppTitle.Name = "lbAppTitle";
            this.lbAppTitle.Size = new System.Drawing.Size(197, 31);
            this.lbAppTitle.TabIndex = 3;
            this.lbAppTitle.Text = "IwLauncher Builder";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::IwLauncher_Builder.Properties.Resources.icons8_saturation_96;
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // HostingPanel
            // 
            this.HostingPanel.BackColor = System.Drawing.Color.Transparent;
            this.HostingPanel.Location = new System.Drawing.Point(212, 70);
            this.HostingPanel.Name = "HostingPanel";
            this.HostingPanel.Size = new System.Drawing.Size(840, 479);
            this.HostingPanel.TabIndex = 3;
            // 
            // lbLicenceType
            // 
            this.lbLicenceType.AutoSize = true;
            this.lbLicenceType.BackColor = System.Drawing.Color.Transparent;
            this.lbLicenceType.Font = new System.Drawing.Font("Segoe UI Light", 15.25F);
            this.lbLicenceType.ForeColor = System.Drawing.Color.White;
            this.lbLicenceType.Location = new System.Drawing.Point(214, 37);
            this.lbLicenceType.Name = "lbLicenceType";
            this.lbLicenceType.Size = new System.Drawing.Size(152, 30);
            this.lbLicenceType.TabIndex = 4;
            this.lbLicenceType.Text = "%LicenceType%";
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::IwLauncher_Builder.Properties.Resources.icons8_multiply_32;
            this.pbClose.Location = new System.Drawing.Point(1022, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(32, 32);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 12;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.BackColor = System.Drawing.Color.Black;
            this.btnSaveProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnSaveProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSaveProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProject.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.btnSaveProject.ForeColor = System.Drawing.Color.White;
            this.btnSaveProject.Image = global::IwLauncher_Builder.Properties.Resources.icons8_save_48;
            this.btnSaveProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProject.Location = new System.Drawing.Point(782, 555);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(132, 55);
            this.btnSaveProject.TabIndex = 9;
            this.btnSaveProject.Text = "SAVE\r\nPROJECT";
            this.btnSaveProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveProject.UseVisualStyleBackColor = false;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.BackColor = System.Drawing.Color.Black;
            this.btnLoadProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnLoadProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnLoadProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProject.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.btnLoadProject.ForeColor = System.Drawing.Color.White;
            this.btnLoadProject.Image = global::IwLauncher_Builder.Properties.Resources.icons8_import_48;
            this.btnLoadProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadProject.Location = new System.Drawing.Point(920, 555);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(132, 55);
            this.btnLoadProject.TabIndex = 13;
            this.btnLoadProject.Text = "LOAD\r\nPROJECT";
            this.btnLoadProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadProject.UseVisualStyleBackColor = false;
            this.btnLoadProject.Click += new System.EventHandler(this.btnLoadProject_Click);
            // 
            // btnSetupIwSVR
            // 
            this.btnSetupIwSVR.BackColor = System.Drawing.Color.Black;
            this.btnSetupIwSVR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnSetupIwSVR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSetupIwSVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetupIwSVR.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.btnSetupIwSVR.ForeColor = System.Drawing.Color.White;
            this.btnSetupIwSVR.Image = global::IwLauncher_Builder.Properties.Resources.icons8_upload_to_the_cloud_48;
            this.btnSetupIwSVR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetupIwSVR.Location = new System.Drawing.Point(212, 555);
            this.btnSetupIwSVR.Name = "btnSetupIwSVR";
            this.btnSetupIwSVR.Size = new System.Drawing.Size(132, 55);
            this.btnSetupIwSVR.TabIndex = 14;
            this.btnSetupIwSVR.Text = "SET UP\r\nIWSVR KEY";
            this.btnSetupIwSVR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetupIwSVR.UseVisualStyleBackColor = false;
            this.btnSetupIwSVR.Click += new System.EventHandler(this.btnSetupIwSVR_Click);
            // 
            // btnProjectSetup
            // 
            this.btnProjectSetup.BackColor = System.Drawing.Color.Black;
            this.btnProjectSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnProjectSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnProjectSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectSetup.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.btnProjectSetup.ForeColor = System.Drawing.Color.White;
            this.btnProjectSetup.Image = global::IwLauncher_Builder.Properties.Resources.icons8_engineering_48;
            this.btnProjectSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectSetup.Location = new System.Drawing.Point(350, 555);
            this.btnProjectSetup.Name = "btnProjectSetup";
            this.btnProjectSetup.Size = new System.Drawing.Size(132, 55);
            this.btnProjectSetup.TabIndex = 15;
            this.btnProjectSetup.Text = "PROJECT\r\nSETUP";
            this.btnProjectSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProjectSetup.UseVisualStyleBackColor = false;
            this.btnProjectSetup.Click += new System.EventHandler(this.btnProjectSetup_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IwLauncher_Builder.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 619);
            this.Controls.Add(this.btnProjectSetup);
            this.Controls.Add(this.btnSetupIwSVR);
            this.Controls.Add(this.btnLoadProject);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lbLicenceType);
            this.Controls.Add(this.HostingPanel);
            this.Controls.Add(this.Panel_HoldButtons);
            this.Controls.Add(this.lbUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IwLauncher Builder";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Panel_HoldButtons.ResumeLayout(false);
            this.Panel_HoldButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPoweredBy;
        private System.Windows.Forms.Panel Panel_HoldButtons;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAppTitle;
        private System.Windows.Forms.Button btnGameUpdatesSetup;
        private System.Windows.Forms.Button btnGameLicensingSetup;
        private System.Windows.Forms.Button btnGameNewsSetup;
        private System.Windows.Forms.Button btnLauncherDesign;
        private System.Windows.Forms.Button btnLauncherAPIIntegrations;
        private System.Windows.Forms.Panel HostingPanel;
        private System.Windows.Forms.Label lbLicenceType;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.Button btnLoadProject;
        private System.Windows.Forms.Button btnSetupIwSVR;
        private System.Windows.Forms.Button btnProjectSetup;
    }
}

