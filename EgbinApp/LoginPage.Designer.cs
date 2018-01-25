namespace EgbinApp
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.LoginBtn = new System.Windows.Forms.Button();
            this.forgotLbl = new System.Windows.Forms.Label();
            this.StaffIdPanel = new System.Windows.Forms.Panel();
            this.StaffIdLabel = new System.Windows.Forms.Label();
            this.StaffIdTextBox = new System.Windows.Forms.TextBox();
            this.InfoIcon = new System.Windows.Forms.PictureBox();
            this.EgbinLogo = new System.Windows.Forms.PictureBox();
            this.StaffIdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EgbinLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginBtn.Location = new System.Drawing.Point(208, 367);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(176, 29);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // forgotLbl
            // 
            this.forgotLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotLbl.AutoSize = true;
            this.forgotLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotLbl.Location = new System.Drawing.Point(230, 420);
            this.forgotLbl.Name = "forgotLbl";
            this.forgotLbl.Size = new System.Drawing.Size(122, 17);
            this.forgotLbl.TabIndex = 7;
            this.forgotLbl.Text = "Forgot Password?";
            this.forgotLbl.Visible = false;
            // 
            // StaffIdPanel
            // 
            this.StaffIdPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffIdPanel.Controls.Add(this.StaffIdLabel);
            this.StaffIdPanel.Controls.Add(this.StaffIdTextBox);
            this.StaffIdPanel.Location = new System.Drawing.Point(176, 249);
            this.StaffIdPanel.Name = "StaffIdPanel";
            this.StaffIdPanel.Size = new System.Drawing.Size(443, 94);
            this.StaffIdPanel.TabIndex = 9;
            // 
            // StaffIdLabel
            // 
            this.StaffIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIdLabel.Location = new System.Drawing.Point(11, 38);
            this.StaffIdLabel.Name = "StaffIdLabel";
            this.StaffIdLabel.Size = new System.Drawing.Size(90, 30);
            this.StaffIdLabel.TabIndex = 1;
            this.StaffIdLabel.Text = "Staff ID:";
            this.StaffIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffIdTextBox
            // 
            this.StaffIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIdTextBox.Location = new System.Drawing.Point(107, 38);
            this.StaffIdTextBox.Name = "StaffIdTextBox";
            this.StaffIdTextBox.Size = new System.Drawing.Size(324, 30);
            this.StaffIdTextBox.TabIndex = 2;
            // 
            // InfoIcon
            // 
            this.InfoIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoIcon.Image = ((System.Drawing.Image)(resources.GetObject("InfoIcon.Image")));
            this.InfoIcon.Location = new System.Drawing.Point(12, 409);
            this.InfoIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoIcon.Name = "InfoIcon";
            this.InfoIcon.Size = new System.Drawing.Size(56, 40);
            this.InfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoIcon.TabIndex = 1;
            this.InfoIcon.TabStop = false;
            this.InfoIcon.Click += new System.EventHandler(this.InfoIcon_Click);
            // 
            // EgbinLogo
            // 
            this.EgbinLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EgbinLogo.Image = ((System.Drawing.Image)(resources.GetObject("EgbinLogo.Image")));
            this.EgbinLogo.Location = new System.Drawing.Point(-11, 36);
            this.EgbinLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EgbinLogo.Name = "EgbinLogo";
            this.EgbinLogo.Size = new System.Drawing.Size(682, 243);
            this.EgbinLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EgbinLogo.TabIndex = 0;
            this.EgbinLogo.TabStop = false;
            // 
            // LoginPage
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.StaffIdPanel);
            this.Controls.Add(this.forgotLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.InfoIcon);
            this.Controls.Add(this.EgbinLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginPage_FormClosed);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.Resize += new System.EventHandler(this.LoginPage_Resize);
            this.StaffIdPanel.ResumeLayout(false);
            this.StaffIdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EgbinLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EgbinLogo;
        private System.Windows.Forms.PictureBox InfoIcon;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label forgotLbl;
        private System.Windows.Forms.Panel StaffIdPanel;
        private System.Windows.Forms.Label StaffIdLabel;
        private System.Windows.Forms.TextBox StaffIdTextBox;
    }
}

