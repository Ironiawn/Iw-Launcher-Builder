namespace IwLauncher_Builder.User_Controller
{
    partial class IW_UC_GameLicensingSetup
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
            this.groupLicenseKeys = new System.Windows.Forms.GroupBox();
            this.lbRecommendation = new System.Windows.Forms.Label();
            this.lbDevSteamWebAPIKey = new System.Windows.Forms.Label();
            this.tbLicenceKeys = new System.Windows.Forms.TextBox();
            this.btnCreateKeysFile = new System.Windows.Forms.Button();
            this.cbUseLicesingValidation = new System.Windows.Forms.CheckBox();
            this.btnLoadKeysFile = new System.Windows.Forms.Button();
            this.cbUseAccountValidation = new System.Windows.Forms.CheckBox();
            this.tbACPKey = new System.Windows.Forms.TextBox();
            this.lbACPKey = new System.Windows.Forms.Label();
            this.btnTryACPKey = new System.Windows.Forms.Button();
            this.lbServerURLKey = new System.Windows.Forms.Label();
            this.tbServerURLKey = new System.Windows.Forms.TextBox();
            this.btnTryServer = new System.Windows.Forms.Button();
            this.groupLicenseKeys.SuspendLayout();
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
            this.lbDescription.Size = new System.Drawing.Size(366, 37);
            this.lbDescription.TabIndex = 2;
            this.lbDescription.Text = "GAME LICENSING VALIDATION";
            // 
            // groupLicenseKeys
            // 
            this.groupLicenseKeys.Controls.Add(this.btnTryServer);
            this.groupLicenseKeys.Controls.Add(this.tbServerURLKey);
            this.groupLicenseKeys.Controls.Add(this.lbDevSteamWebAPIKey);
            this.groupLicenseKeys.Controls.Add(this.tbLicenceKeys);
            this.groupLicenseKeys.Controls.Add(this.lbServerURLKey);
            this.groupLicenseKeys.Controls.Add(this.lbRecommendation);
            this.groupLicenseKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupLicenseKeys.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.groupLicenseKeys.ForeColor = System.Drawing.Color.White;
            this.groupLicenseKeys.Location = new System.Drawing.Point(10, 71);
            this.groupLicenseKeys.Name = "groupLicenseKeys";
            this.groupLicenseKeys.Size = new System.Drawing.Size(820, 309);
            this.groupLicenseKeys.TabIndex = 8;
            this.groupLicenseKeys.TabStop = false;
            this.groupLicenseKeys.Text = "GAME KEYS";
            // 
            // lbRecommendation
            // 
            this.lbRecommendation.AutoSize = true;
            this.lbRecommendation.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.lbRecommendation.Location = new System.Drawing.Point(6, 246);
            this.lbRecommendation.Name = "lbRecommendation";
            this.lbRecommendation.Size = new System.Drawing.Size(652, 38);
            this.lbRecommendation.TabIndex = 3;
            this.lbRecommendation.Text = "We recommend the use of https://www.allkeysgenerator.com/Random/Security-Encrypti" +
    "on-Key-Generator.aspx\r\nSelect \"GUID\" > \"Uppercase? Yes\" > \"Hyphens? Yes\"";
            // 
            // lbDevSteamWebAPIKey
            // 
            this.lbDevSteamWebAPIKey.AutoSize = true;
            this.lbDevSteamWebAPIKey.BackColor = System.Drawing.Color.Transparent;
            this.lbDevSteamWebAPIKey.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevSteamWebAPIKey.ForeColor = System.Drawing.Color.White;
            this.lbDevSteamWebAPIKey.Location = new System.Drawing.Point(6, 39);
            this.lbDevSteamWebAPIKey.Name = "lbDevSteamWebAPIKey";
            this.lbDevSteamWebAPIKey.Size = new System.Drawing.Size(555, 37);
            this.lbDevSteamWebAPIKey.TabIndex = 2;
            this.lbDevSteamWebAPIKey.Text = "PUT YOUR GAME KEYS BELOW (ONE PER LINE)";
            // 
            // tbLicenceKeys
            // 
            this.tbLicenceKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLicenceKeys.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLicenceKeys.Location = new System.Drawing.Point(13, 79);
            this.tbLicenceKeys.MaxLength = 999999;
            this.tbLicenceKeys.Multiline = true;
            this.tbLicenceKeys.Name = "tbLicenceKeys";
            this.tbLicenceKeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLicenceKeys.Size = new System.Drawing.Size(795, 129);
            this.tbLicenceKeys.TabIndex = 1;
            this.tbLicenceKeys.TextChanged += new System.EventHandler(this.tbLicenceKeys_TextChanged);
            // 
            // btnCreateKeysFile
            // 
            this.btnCreateKeysFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateKeysFile.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnCreateKeysFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateKeysFile.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnCreateKeysFile.ForeColor = System.Drawing.Color.White;
            this.btnCreateKeysFile.Image = global::IwLauncher_Builder.Properties.Resources.icons8_key_48;
            this.btnCreateKeysFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateKeysFile.Location = new System.Drawing.Point(701, 37);
            this.btnCreateKeysFile.Name = "btnCreateKeysFile";
            this.btnCreateKeysFile.Size = new System.Drawing.Size(129, 47);
            this.btnCreateKeysFile.TabIndex = 3;
            this.btnCreateKeysFile.Text = "GENERATE\r\nKEYS FILE";
            this.btnCreateKeysFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateKeysFile.UseVisualStyleBackColor = false;
            this.btnCreateKeysFile.Click += new System.EventHandler(this.btnCreateKeysFile_Click);
            // 
            // cbUseLicesingValidation
            // 
            this.cbUseLicesingValidation.AutoSize = true;
            this.cbUseLicesingValidation.BackColor = System.Drawing.Color.Transparent;
            this.cbUseLicesingValidation.FlatAppearance.BorderSize = 0;
            this.cbUseLicesingValidation.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.cbUseLicesingValidation.ForeColor = System.Drawing.Color.White;
            this.cbUseLicesingValidation.Location = new System.Drawing.Point(10, 40);
            this.cbUseLicesingValidation.Name = "cbUseLicesingValidation";
            this.cbUseLicesingValidation.Size = new System.Drawing.Size(427, 34);
            this.cbUseLicesingValidation.TabIndex = 7;
            this.cbUseLicesingValidation.Text = "Use licensing validation after launcher opening";
            this.cbUseLicesingValidation.UseCompatibleTextRendering = true;
            this.cbUseLicesingValidation.UseVisualStyleBackColor = false;
            this.cbUseLicesingValidation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbUseLicesingValidation_MouseClick);
            // 
            // btnLoadKeysFile
            // 
            this.btnLoadKeysFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLoadKeysFile.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnLoadKeysFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadKeysFile.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnLoadKeysFile.ForeColor = System.Drawing.Color.White;
            this.btnLoadKeysFile.Image = global::IwLauncher_Builder.Properties.Resources.icons8_import_48;
            this.btnLoadKeysFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadKeysFile.Location = new System.Drawing.Point(566, 37);
            this.btnLoadKeysFile.Name = "btnLoadKeysFile";
            this.btnLoadKeysFile.Size = new System.Drawing.Size(129, 47);
            this.btnLoadKeysFile.TabIndex = 4;
            this.btnLoadKeysFile.Text = "LOAD\r\nKEYS FILE";
            this.btnLoadKeysFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadKeysFile.UseVisualStyleBackColor = false;
            this.btnLoadKeysFile.Click += new System.EventHandler(this.btnLoadKeysFile_Click);
            // 
            // cbUseAccountValidation
            // 
            this.cbUseAccountValidation.AutoSize = true;
            this.cbUseAccountValidation.BackColor = System.Drawing.Color.Transparent;
            this.cbUseAccountValidation.FlatAppearance.BorderSize = 0;
            this.cbUseAccountValidation.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.cbUseAccountValidation.ForeColor = System.Drawing.Color.White;
            this.cbUseAccountValidation.Location = new System.Drawing.Point(10, 374);
            this.cbUseAccountValidation.Name = "cbUseAccountValidation";
            this.cbUseAccountValidation.Size = new System.Drawing.Size(485, 34);
            this.cbUseAccountValidation.TabIndex = 9;
            this.cbUseAccountValidation.Text = "Use Account Product Activation (ACP) through IwSVR";
            this.cbUseAccountValidation.UseCompatibleTextRendering = true;
            this.cbUseAccountValidation.UseVisualStyleBackColor = false;
            this.cbUseAccountValidation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbUseAccountValidation_MouseClick);
            // 
            // tbACPKey
            // 
            this.tbACPKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbACPKey.Enabled = false;
            this.tbACPKey.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.tbACPKey.Location = new System.Drawing.Point(23, 438);
            this.tbACPKey.MaxLength = 25;
            this.tbACPKey.Name = "tbACPKey";
            this.tbACPKey.Size = new System.Drawing.Size(346, 26);
            this.tbACPKey.TabIndex = 2;
            // 
            // lbACPKey
            // 
            this.lbACPKey.AutoSize = true;
            this.lbACPKey.BackColor = System.Drawing.Color.Transparent;
            this.lbACPKey.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbACPKey.ForeColor = System.Drawing.Color.White;
            this.lbACPKey.Location = new System.Drawing.Point(16, 398);
            this.lbACPKey.Name = "lbACPKey";
            this.lbACPKey.Size = new System.Drawing.Size(111, 37);
            this.lbACPKey.TabIndex = 4;
            this.lbACPKey.Text = "ACP Key";
            // 
            // btnTryACPKey
            // 
            this.btnTryACPKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTryACPKey.Enabled = false;
            this.btnTryACPKey.FlatAppearance.BorderSize = 0;
            this.btnTryACPKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnTryACPKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnTryACPKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryACPKey.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnTryACPKey.ForeColor = System.Drawing.Color.White;
            this.btnTryACPKey.Image = global::IwLauncher_Builder.Properties.Resources.icons8_restart_48;
            this.btnTryACPKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTryACPKey.Location = new System.Drawing.Point(375, 421);
            this.btnTryACPKey.Name = "btnTryACPKey";
            this.btnTryACPKey.Size = new System.Drawing.Size(146, 55);
            this.btnTryACPKey.TabIndex = 10;
            this.btnTryACPKey.Text = "VERIFY \r\nACP KEY";
            this.btnTryACPKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTryACPKey.UseVisualStyleBackColor = false;
            this.btnTryACPKey.Click += new System.EventHandler(this.btnTryACPKey_Click);
            // 
            // lbServerURLKey
            // 
            this.lbServerURLKey.AutoSize = true;
            this.lbServerURLKey.BackColor = System.Drawing.Color.Transparent;
            this.lbServerURLKey.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServerURLKey.ForeColor = System.Drawing.Color.White;
            this.lbServerURLKey.Location = new System.Drawing.Point(23, 206);
            this.lbServerURLKey.Name = "lbServerURLKey";
            this.lbServerURLKey.Size = new System.Drawing.Size(205, 37);
            this.lbServerURLKey.TabIndex = 4;
            this.lbServerURLKey.Text = "SERVER URL KEY";
            // 
            // tbServerURLKey
            // 
            this.tbServerURLKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbServerURLKey.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.tbServerURLKey.Location = new System.Drawing.Point(225, 214);
            this.tbServerURLKey.MaxLength = 555555;
            this.tbServerURLKey.Name = "tbServerURLKey";
            this.tbServerURLKey.Size = new System.Drawing.Size(583, 26);
            this.tbServerURLKey.TabIndex = 11;
            this.tbServerURLKey.TextChanged += new System.EventHandler(this.tbServerURLKey_TextChanged);
            // 
            // btnTryServer
            // 
            this.btnTryServer.BackColor = System.Drawing.Color.Teal;
            this.btnTryServer.FlatAppearance.BorderSize = 0;
            this.btnTryServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnTryServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnTryServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryServer.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnTryServer.ForeColor = System.Drawing.Color.White;
            this.btnTryServer.Image = global::IwLauncher_Builder.Properties.Resources.icons8_restart_48;
            this.btnTryServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTryServer.Location = new System.Drawing.Point(682, 246);
            this.btnTryServer.Name = "btnTryServer";
            this.btnTryServer.Size = new System.Drawing.Size(126, 57);
            this.btnTryServer.TabIndex = 11;
            this.btnTryServer.Text = "TEST \r\nSERVER";
            this.btnTryServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTryServer.UseVisualStyleBackColor = false;
            this.btnTryServer.Click += new System.EventHandler(this.btnTryServer_Click);
            // 
            // IW_UC_GameLicensingSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.btnTryACPKey);
            this.Controls.Add(this.lbACPKey);
            this.Controls.Add(this.tbACPKey);
            this.Controls.Add(this.btnLoadKeysFile);
            this.Controls.Add(this.btnCreateKeysFile);
            this.Controls.Add(this.cbUseLicesingValidation);
            this.Controls.Add(this.groupLicenseKeys);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.cbUseAccountValidation);
            this.DoubleBuffered = true;
            this.Name = "IW_UC_GameLicensingSetup";
            this.Size = new System.Drawing.Size(840, 479);
            this.Load += new System.EventHandler(this.IW_UC_GameLicensingSetup_Load);
            this.groupLicenseKeys.ResumeLayout(false);
            this.groupLicenseKeys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btnCreateKeysFile;
        private System.Windows.Forms.GroupBox groupLicenseKeys;
        private System.Windows.Forms.Label lbDevSteamWebAPIKey;
        private System.Windows.Forms.TextBox tbLicenceKeys;
        private System.Windows.Forms.CheckBox cbUseLicesingValidation;
        private System.Windows.Forms.Button btnLoadKeysFile;
        private System.Windows.Forms.Label lbRecommendation;
        private System.Windows.Forms.CheckBox cbUseAccountValidation;
        private System.Windows.Forms.TextBox tbACPKey;
        private System.Windows.Forms.Label lbACPKey;
        private System.Windows.Forms.Button btnTryACPKey;
        private System.Windows.Forms.TextBox tbServerURLKey;
        private System.Windows.Forms.Label lbServerURLKey;
        private System.Windows.Forms.Button btnTryServer;
    }
}
