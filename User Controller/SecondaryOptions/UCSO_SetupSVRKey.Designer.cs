namespace IwLauncher_Builder.User_Controller.SecondaryOptions
{
    partial class UCSO_SetupSVRKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSO_SetupSVRKey));
            this.tbIwSVRKey = new System.Windows.Forms.TextBox();
            this.cbUseIwSVR = new System.Windows.Forms.CheckBox();
            this.lbSVRPoweredKey = new System.Windows.Forms.Label();
            this.lbIwSVRDescription = new System.Windows.Forms.Label();
            this.btnBuyKey = new System.Windows.Forms.Button();
            this.btnTryIwSVRKey = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIwSVRKey
            // 
            this.tbIwSVRKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIwSVRKey.Enabled = false;
            this.tbIwSVRKey.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIwSVRKey.Location = new System.Drawing.Point(19, 93);
            this.tbIwSVRKey.MaxLength = 24;
            this.tbIwSVRKey.Name = "tbIwSVRKey";
            this.tbIwSVRKey.Size = new System.Drawing.Size(276, 26);
            this.tbIwSVRKey.TabIndex = 2;
            this.tbIwSVRKey.TextChanged += new System.EventHandler(this.tbIwSVRKey_TextChanged);
            // 
            // cbUseIwSVR
            // 
            this.cbUseIwSVR.AutoSize = true;
            this.cbUseIwSVR.BackColor = System.Drawing.Color.Transparent;
            this.cbUseIwSVR.FlatAppearance.BorderSize = 0;
            this.cbUseIwSVR.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.cbUseIwSVR.ForeColor = System.Drawing.Color.White;
            this.cbUseIwSVR.Location = new System.Drawing.Point(19, 17);
            this.cbUseIwSVR.Name = "cbUseIwSVR";
            this.cbUseIwSVR.Size = new System.Drawing.Size(259, 34);
            this.cbUseIwSVR.TabIndex = 1;
            this.cbUseIwSVR.Text = "Use Ironiawn SVR powered";
            this.cbUseIwSVR.UseCompatibleTextRendering = true;
            this.cbUseIwSVR.UseVisualStyleBackColor = false;
            this.cbUseIwSVR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbUseIwSVR_MouseClick);
            // 
            // lbSVRPoweredKey
            // 
            this.lbSVRPoweredKey.AutoSize = true;
            this.lbSVRPoweredKey.BackColor = System.Drawing.Color.Transparent;
            this.lbSVRPoweredKey.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSVRPoweredKey.ForeColor = System.Drawing.Color.White;
            this.lbSVRPoweredKey.Location = new System.Drawing.Point(12, 53);
            this.lbSVRPoweredKey.Name = "lbSVRPoweredKey";
            this.lbSVRPoweredKey.Size = new System.Drawing.Size(131, 37);
            this.lbSVRPoweredKey.TabIndex = 14;
            this.lbSVRPoweredKey.Text = "IwSVR Key";
            // 
            // lbIwSVRDescription
            // 
            this.lbIwSVRDescription.AutoSize = true;
            this.lbIwSVRDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbIwSVRDescription.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.lbIwSVRDescription.ForeColor = System.Drawing.Color.White;
            this.lbIwSVRDescription.Location = new System.Drawing.Point(22, 122);
            this.lbIwSVRDescription.Name = "lbIwSVRDescription";
            this.lbIwSVRDescription.Size = new System.Drawing.Size(226, 115);
            this.lbIwSVRDescription.TabIndex = 17;
            this.lbIwSVRDescription.Text = "Use IwServer to allow:\r\n\r\n- Easy game version checking\r\n- Easy game news updating" +
    "\r\n- Easy game licensing options";
            // 
            // btnBuyKey
            // 
            this.btnBuyKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuyKey.FlatAppearance.BorderSize = 0;
            this.btnBuyKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnBuyKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnBuyKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyKey.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnBuyKey.ForeColor = System.Drawing.Color.White;
            this.btnBuyKey.Image = global::IwLauncher_Builder.Properties.Resources.icons8_speed_up_48;
            this.btnBuyKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyKey.Location = new System.Drawing.Point(464, 129);
            this.btnBuyKey.Name = "btnBuyKey";
            this.btnBuyKey.Size = new System.Drawing.Size(146, 55);
            this.btnBuyKey.TabIndex = 3;
            this.btnBuyKey.Text = "BUY NEW\r\nIWSVR KEY";
            this.btnBuyKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuyKey.UseVisualStyleBackColor = false;
            this.btnBuyKey.Click += new System.EventHandler(this.btnBuyKey_Click);
            // 
            // btnTryIwSVRKey
            // 
            this.btnTryIwSVRKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTryIwSVRKey.Enabled = false;
            this.btnTryIwSVRKey.FlatAppearance.BorderSize = 0;
            this.btnTryIwSVRKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnTryIwSVRKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnTryIwSVRKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryIwSVRKey.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.btnTryIwSVRKey.ForeColor = System.Drawing.Color.White;
            this.btnTryIwSVRKey.Image = global::IwLauncher_Builder.Properties.Resources.icons8_restart_48;
            this.btnTryIwSVRKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTryIwSVRKey.Location = new System.Drawing.Point(464, 190);
            this.btnTryIwSVRKey.Name = "btnTryIwSVRKey";
            this.btnTryIwSVRKey.Size = new System.Drawing.Size(146, 55);
            this.btnTryIwSVRKey.TabIndex = 4;
            this.btnTryIwSVRKey.Text = "VERIFY \r\nIWSVR KEY";
            this.btnTryIwSVRKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTryIwSVRKey.UseVisualStyleBackColor = false;
            this.btnTryIwSVRKey.Click += new System.EventHandler(this.btnTryIwSVRKey_Click);
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
            // UCSO_SetupSVRKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(622, 257);
            this.Controls.Add(this.btnBuyKey);
            this.Controls.Add(this.lbIwSVRDescription);
            this.Controls.Add(this.btnTryIwSVRKey);
            this.Controls.Add(this.tbIwSVRKey);
            this.Controls.Add(this.cbUseIwSVR);
            this.Controls.Add(this.lbSVRPoweredKey);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UCSO_SetupSVRKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCSO_SetupSVRKey";
            this.Load += new System.EventHandler(this.UCSO_SetupSVRKey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnTryIwSVRKey;
        private System.Windows.Forms.TextBox tbIwSVRKey;
        private System.Windows.Forms.CheckBox cbUseIwSVR;
        private System.Windows.Forms.Label lbSVRPoweredKey;
        private System.Windows.Forms.Label lbIwSVRDescription;
        private System.Windows.Forms.Button btnBuyKey;
    }
}