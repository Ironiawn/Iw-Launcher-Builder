namespace IwLauncher_Builder.User_Controller.SecondaryOptions
{
    partial class UCSO_ProjectSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSO_ProjectSetup));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.tbProjectDeveloper = new System.Windows.Forms.TextBox();
            this.lbProjectDeveloper = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::IwLauncher_Builder.Properties.Resources.icons8_multiply_32;
            this.pbClose.Location = new System.Drawing.Point(578, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(32, 32);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 12;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lbProjectName.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjectName.ForeColor = System.Drawing.Color.White;
            this.lbProjectName.Location = new System.Drawing.Point(12, 12);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(201, 37);
            this.lbProjectName.TabIndex = 13;
            this.lbProjectName.Text = "PROJECT NAME";
            // 
            // tbProjectName
            // 
            this.tbProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProjectName.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectName.Location = new System.Drawing.Point(19, 52);
            this.tbProjectName.MaxLength = 100;
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(369, 26);
            this.tbProjectName.TabIndex = 1000;
            // 
            // tbProjectDeveloper
            // 
            this.tbProjectDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProjectDeveloper.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectDeveloper.Location = new System.Drawing.Point(19, 124);
            this.tbProjectDeveloper.MaxLength = 100;
            this.tbProjectDeveloper.Name = "tbProjectDeveloper";
            this.tbProjectDeveloper.Size = new System.Drawing.Size(369, 26);
            this.tbProjectDeveloper.TabIndex = 1002;
            // 
            // lbProjectDeveloper
            // 
            this.lbProjectDeveloper.AutoSize = true;
            this.lbProjectDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.lbProjectDeveloper.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjectDeveloper.ForeColor = System.Drawing.Color.White;
            this.lbProjectDeveloper.Location = new System.Drawing.Point(12, 84);
            this.lbProjectDeveloper.Name = "lbProjectDeveloper";
            this.lbProjectDeveloper.Size = new System.Drawing.Size(267, 37);
            this.lbProjectDeveloper.TabIndex = 1001;
            this.lbProjectDeveloper.Text = "PROJECT DEVELOPER";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.Black;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnSaveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.Image = global::IwLauncher_Builder.Properties.Resources.icons8_save_48;
            this.btnSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSettings.Location = new System.Drawing.Point(447, 190);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(163, 55);
            this.btnSaveSettings.TabIndex = 1003;
            this.btnSaveSettings.Text = "SAVE\r\nSETTINGS\r\n";
            this.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // UCSO_ProjectSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(622, 257);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.tbProjectDeveloper);
            this.Controls.Add(this.lbProjectDeveloper);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.lbProjectName);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UCSO_ProjectSetup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCSO_ProjectSetup";
            this.Load += new System.EventHandler(this.UCSO_ProjectSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox tbProjectDeveloper;
        private System.Windows.Forms.Label lbProjectDeveloper;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}