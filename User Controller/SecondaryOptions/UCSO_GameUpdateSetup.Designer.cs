namespace IwLauncher_Builder.User_Controller.SecondaryOptions
{
    partial class UCSO_GameUpdateSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSO_GameUpdateSetup));
            this.lbCurrentVersion = new System.Windows.Forms.Label();
            this.tbCurrentVersion = new System.Windows.Forms.TextBox();
            this.lbNewVersion = new System.Windows.Forms.Label();
            this.tbNewVersion = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btnSaveVersion = new System.Windows.Forms.Button();
            this.btnUploadNewVersionSVR = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCurrentVersion
            // 
            this.lbCurrentVersion.AutoSize = true;
            this.lbCurrentVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbCurrentVersion.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentVersion.ForeColor = System.Drawing.Color.White;
            this.lbCurrentVersion.Location = new System.Drawing.Point(12, 9);
            this.lbCurrentVersion.Name = "lbCurrentVersion";
            this.lbCurrentVersion.Size = new System.Drawing.Size(317, 37);
            this.lbCurrentVersion.TabIndex = 4;
            this.lbCurrentVersion.Text = "CURRENT GAME VERSION";
            // 
            // tbCurrentVersion
            // 
            this.tbCurrentVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCurrentVersion.Enabled = false;
            this.tbCurrentVersion.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentVersion.Location = new System.Drawing.Point(19, 49);
            this.tbCurrentVersion.MaxLength = 5;
            this.tbCurrentVersion.Name = "tbCurrentVersion";
            this.tbCurrentVersion.Size = new System.Drawing.Size(96, 26);
            this.tbCurrentVersion.TabIndex = 999;
            this.tbCurrentVersion.TextChanged += new System.EventHandler(this.tbCurrentVersion_TextChanged);
            // 
            // lbNewVersion
            // 
            this.lbNewVersion.AutoSize = true;
            this.lbNewVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbNewVersion.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewVersion.ForeColor = System.Drawing.Color.White;
            this.lbNewVersion.Location = new System.Drawing.Point(12, 78);
            this.lbNewVersion.Name = "lbNewVersion";
            this.lbNewVersion.Size = new System.Drawing.Size(405, 37);
            this.lbNewVersion.TabIndex = 6;
            this.lbNewVersion.Text = "SET NEW VERSION OF THE GAME";
            // 
            // tbNewVersion
            // 
            this.tbNewVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewVersion.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewVersion.Location = new System.Drawing.Point(19, 118);
            this.tbNewVersion.MaxLength = 5;
            this.tbNewVersion.Name = "tbNewVersion";
            this.tbNewVersion.Size = new System.Drawing.Size(96, 26);
            this.tbNewVersion.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(15, 156);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(472, 92);
            this.lbDescription.TabIndex = 10;
            this.lbDescription.Text = "Use this to create a new update file version.\r\nAfter the creation, upload it to y" +
    "our server!\r\n\r\nWhen your users launch the game, the launcher will check for it.";
            // 
            // btnSaveVersion
            // 
            this.btnSaveVersion.BackColor = System.Drawing.Color.Black;
            this.btnSaveVersion.FlatAppearance.BorderSize = 0;
            this.btnSaveVersion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnSaveVersion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSaveVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveVersion.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnSaveVersion.ForeColor = System.Drawing.Color.White;
            this.btnSaveVersion.Image = global::IwLauncher_Builder.Properties.Resources.icons8_save_48;
            this.btnSaveVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveVersion.Location = new System.Drawing.Point(447, 172);
            this.btnSaveVersion.Name = "btnSaveVersion";
            this.btnSaveVersion.Size = new System.Drawing.Size(163, 55);
            this.btnSaveVersion.TabIndex = 4;
            this.btnSaveVersion.Text = "SAVE/CREATE\r\nVERSION\r\n";
            this.btnSaveVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveVersion.UseVisualStyleBackColor = false;
            this.btnSaveVersion.Click += new System.EventHandler(this.btnSaveVersion_Click);
            // 
            // btnUploadNewVersionSVR
            // 
            this.btnUploadNewVersionSVR.BackColor = System.Drawing.Color.Black;
            this.btnUploadNewVersionSVR.FlatAppearance.BorderSize = 0;
            this.btnUploadNewVersionSVR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnUploadNewVersionSVR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnUploadNewVersionSVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadNewVersionSVR.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnUploadNewVersionSVR.ForeColor = System.Drawing.Color.White;
            this.btnUploadNewVersionSVR.Image = global::IwLauncher_Builder.Properties.Resources.icons8_upload_to_the_cloud_481;
            this.btnUploadNewVersionSVR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadNewVersionSVR.Location = new System.Drawing.Point(447, 50);
            this.btnUploadNewVersionSVR.Name = "btnUploadNewVersionSVR";
            this.btnUploadNewVersionSVR.Size = new System.Drawing.Size(163, 55);
            this.btnUploadNewVersionSVR.TabIndex = 2;
            this.btnUploadNewVersionSVR.Text = "UPDATE VER.\r\nAT IWSVR\r\n";
            this.btnUploadNewVersionSVR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUploadNewVersionSVR.UseVisualStyleBackColor = false;
            this.btnUploadNewVersionSVR.Click += new System.EventHandler(this.btnUploadNewVersionSVR_Click);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::IwLauncher_Builder.Properties.Resources.icons8_multiply_32;
            this.pbClose.Location = new System.Drawing.Point(578, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(32, 32);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 11;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.Black;
            this.btnSaveFile.FlatAppearance.BorderSize = 0;
            this.btnSaveFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnSaveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnSaveFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.Image = global::IwLauncher_Builder.Properties.Resources.icons8_versions_48;
            this.btnSaveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveFile.Location = new System.Drawing.Point(447, 111);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(163, 55);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "CREATE\r\nUPDATE FILE\r\n";
            this.btnSaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // UCSO_GameUpdateSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(622, 257);
            this.Controls.Add(this.btnSaveVersion);
            this.Controls.Add(this.btnUploadNewVersionSVR);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.lbNewVersion);
            this.Controls.Add(this.tbNewVersion);
            this.Controls.Add(this.lbCurrentVersion);
            this.Controls.Add(this.tbCurrentVersion);
            this.Controls.Add(this.lbDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UCSO_GameUpdateSetup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update file Creator";
            this.Load += new System.EventHandler(this.UCSO_GameUpdateSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrentVersion;
        private System.Windows.Forms.TextBox tbCurrentVersion;
        private System.Windows.Forms.Label lbNewVersion;
        private System.Windows.Forms.TextBox tbNewVersion;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnUploadNewVersionSVR;
        private System.Windows.Forms.Button btnSaveVersion;
    }
}