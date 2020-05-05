namespace IwLauncher_Builder.User_Controller
{
    partial class IW_UC_GameSetup
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbUpdateServer = new System.Windows.Forms.Label();
            this.tbUpdateServer = new System.Windows.Forms.TextBox();
            this.cbAllowUpdateChecking = new System.Windows.Forms.CheckBox();
            this.groupServerSetup = new System.Windows.Forms.GroupBox();
            this.lbMoreDescription = new System.Windows.Forms.Label();
            this.btnUpdateFileSetup = new System.Windows.Forms.Button();
            this.groupServerSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(3, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(278, 37);
            this.lbDescription.TabIndex = 1;
            this.lbDescription.Text = "GAME AUTO-UPDATER";
            // 
            // lbUpdateServer
            // 
            this.lbUpdateServer.AutoSize = true;
            this.lbUpdateServer.BackColor = System.Drawing.Color.Transparent;
            this.lbUpdateServer.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdateServer.ForeColor = System.Drawing.Color.White;
            this.lbUpdateServer.Location = new System.Drawing.Point(6, 39);
            this.lbUpdateServer.Name = "lbUpdateServer";
            this.lbUpdateServer.Size = new System.Drawing.Size(155, 37);
            this.lbUpdateServer.TabIndex = 2;
            this.lbUpdateServer.Text = "SERVER URL";
            // 
            // tbUpdateServer
            // 
            this.tbUpdateServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUpdateServer.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdateServer.Location = new System.Drawing.Point(13, 79);
            this.tbUpdateServer.Name = "tbUpdateServer";
            this.tbUpdateServer.Size = new System.Drawing.Size(801, 26);
            this.tbUpdateServer.TabIndex = 1;
            this.tbUpdateServer.TextChanged += new System.EventHandler(this.tbUpdateServer_TextChanged);
            // 
            // cbAllowUpdateChecking
            // 
            this.cbAllowUpdateChecking.AutoSize = true;
            this.cbAllowUpdateChecking.BackColor = System.Drawing.Color.Transparent;
            this.cbAllowUpdateChecking.FlatAppearance.BorderSize = 0;
            this.cbAllowUpdateChecking.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.cbAllowUpdateChecking.ForeColor = System.Drawing.Color.White;
            this.cbAllowUpdateChecking.Location = new System.Drawing.Point(11, 38);
            this.cbAllowUpdateChecking.Name = "cbAllowUpdateChecking";
            this.cbAllowUpdateChecking.Size = new System.Drawing.Size(422, 34);
            this.cbAllowUpdateChecking.TabIndex = 6;
            this.cbAllowUpdateChecking.Text = "Allow the launcher to check for game updates";
            this.cbAllowUpdateChecking.UseCompatibleTextRendering = true;
            this.cbAllowUpdateChecking.UseVisualStyleBackColor = false;
            this.cbAllowUpdateChecking.CheckedChanged += new System.EventHandler(this.cbAllowUpdateChecking_CheckedChanged);
            // 
            // groupServerSetup
            // 
            this.groupServerSetup.Controls.Add(this.lbUpdateServer);
            this.groupServerSetup.Controls.Add(this.tbUpdateServer);
            this.groupServerSetup.Enabled = false;
            this.groupServerSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupServerSetup.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.groupServerSetup.ForeColor = System.Drawing.Color.White;
            this.groupServerSetup.Location = new System.Drawing.Point(10, 78);
            this.groupServerSetup.Name = "groupServerSetup";
            this.groupServerSetup.Size = new System.Drawing.Size(820, 121);
            this.groupServerSetup.TabIndex = 7;
            this.groupServerSetup.TabStop = false;
            this.groupServerSetup.Text = "UPDATE SERVER SETUP";
            // 
            // lbMoreDescription
            // 
            this.lbMoreDescription.AutoSize = true;
            this.lbMoreDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbMoreDescription.Font = new System.Drawing.Font("Segoe UI Light", 15.25F);
            this.lbMoreDescription.ForeColor = System.Drawing.Color.White;
            this.lbMoreDescription.Location = new System.Drawing.Point(6, 202);
            this.lbMoreDescription.Name = "lbMoreDescription";
            this.lbMoreDescription.Size = new System.Drawing.Size(539, 210);
            this.lbMoreDescription.TabIndex = 6;
            this.lbMoreDescription.Text = "This feature enables the launcher to seek for game updates.\r\nUseful for:\r\n\r\n- Aut" +
    "omatic bug fixes\r\n- Automatic new features \r\n- Force user to upgrade game\r\n- Mul" +
    "tiplayer games";
            // 
            // btnUpdateFileSetup
            // 
            this.btnUpdateFileSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateFileSetup.Enabled = false;
            this.btnUpdateFileSetup.FlatAppearance.BorderSize = 0;
            this.btnUpdateFileSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnUpdateFileSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnUpdateFileSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFileSetup.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnUpdateFileSetup.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFileSetup.Image = global::IwLauncher_Builder.Properties.Resources.icons8_versions_48;
            this.btnUpdateFileSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFileSetup.Location = new System.Drawing.Point(624, 29);
            this.btnUpdateFileSetup.Name = "btnUpdateFileSetup";
            this.btnUpdateFileSetup.Size = new System.Drawing.Size(206, 55);
            this.btnUpdateFileSetup.TabIndex = 8;
            this.btnUpdateFileSetup.Text = "UPDATE VERSION\r\nSETUP\r\n";
            this.btnUpdateFileSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateFileSetup.UseVisualStyleBackColor = false;
            this.btnUpdateFileSetup.Click += new System.EventHandler(this.btnUpdateFileSetup_Click);
            // 
            // IW_UC_GameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.btnUpdateFileSetup);
            this.Controls.Add(this.lbMoreDescription);
            this.Controls.Add(this.groupServerSetup);
            this.Controls.Add(this.cbAllowUpdateChecking);
            this.Controls.Add(this.lbDescription);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "IW_UC_GameSetup";
            this.Size = new System.Drawing.Size(840, 479);
            this.Load += new System.EventHandler(this.IW_UC_GameSetup_Load);
            this.groupServerSetup.ResumeLayout(false);
            this.groupServerSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbUpdateServer;
        private System.Windows.Forms.TextBox tbUpdateServer;
        private System.Windows.Forms.CheckBox cbAllowUpdateChecking;
        private System.Windows.Forms.GroupBox groupServerSetup;
        private System.Windows.Forms.Label lbMoreDescription;
        private System.Windows.Forms.Button btnUpdateFileSetup;
    }
}
