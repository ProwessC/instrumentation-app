namespace EgbinApp
{
    partial class WelcomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.MenuIcon = new System.Windows.Forms.PictureBox();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.EgbinPic = new System.Windows.Forms.PictureBox();
            this.MenuPnl = new System.Windows.Forms.Panel();
            this.HelpOptn = new System.Windows.Forms.Button();
            this.AboutOptn = new System.Windows.Forms.Button();
            this.SignOutOptn = new System.Windows.Forms.Button();
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.DeptHdPnl = new System.Windows.Forms.Panel();
            this.AddNewPnl = new System.Windows.Forms.Panel();
            this.newLbl = new System.Windows.Forms.Label();
            this.newPic = new System.Windows.Forms.PictureBox();
            this.DeptLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DepartmentsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNewDeptToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HeaderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EgbinPic)).BeginInit();
            this.MenuPnl.SuspendLayout();
            this.DeptHdPnl.SuspendLayout();
            this.AddNewPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.Controls.Add(this.MenuIcon);
            this.HeaderPnl.Controls.Add(this.FullNameLbl);
            this.HeaderPnl.Controls.Add(this.ProfilePic);
            this.HeaderPnl.Controls.Add(this.EgbinPic);
            this.HeaderPnl.Location = new System.Drawing.Point(12, 12);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(1134, 62);
            this.HeaderPnl.TabIndex = 2;
            // 
            // MenuIcon
            // 
            this.MenuIcon.Image = global::EgbinApp.Properties.Resources.hamburger;
            this.MenuIcon.Location = new System.Drawing.Point(3, 3);
            this.MenuIcon.Name = "MenuIcon";
            this.MenuIcon.Size = new System.Drawing.Size(55, 43);
            this.MenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuIcon.TabIndex = 3;
            this.MenuIcon.TabStop = false;
            this.MenuIcon.Click += new System.EventHandler(this.MenuIcon_Click);
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.FullNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.FullNameLbl.Location = new System.Drawing.Point(835, 0);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(233, 62);
            this.FullNameLbl.TabIndex = 15;
            this.FullNameLbl.Text = "SURNAME, FIRSTNAME";
            this.FullNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProfilePic
            // 
            this.ProfilePic.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProfilePic.Image = global::EgbinApp.Properties.Resources.my_profile_icon_white;
            this.ProfilePic.Location = new System.Drawing.Point(1068, 0);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(66, 62);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 2;
            this.ProfilePic.TabStop = false;
            // 
            // EgbinPic
            // 
            this.EgbinPic.Image = ((System.Drawing.Image)(resources.GetObject("EgbinPic.Image")));
            this.EgbinPic.Location = new System.Drawing.Point(64, 3);
            this.EgbinPic.Name = "EgbinPic";
            this.EgbinPic.Size = new System.Drawing.Size(100, 43);
            this.EgbinPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EgbinPic.TabIndex = 1;
            this.EgbinPic.TabStop = false;
            this.EgbinPic.Click += new System.EventHandler(this.EgbinPic_Click);
            // 
            // MenuPnl
            // 
            this.MenuPnl.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MenuPnl.Controls.Add(this.HelpOptn);
            this.MenuPnl.Controls.Add(this.AboutOptn);
            this.MenuPnl.Controls.Add(this.SignOutOptn);
            this.MenuPnl.Location = new System.Drawing.Point(12, 64);
            this.MenuPnl.Name = "MenuPnl";
            this.MenuPnl.Size = new System.Drawing.Size(113, 111);
            this.MenuPnl.TabIndex = 2;
            this.MenuPnl.Visible = false;
            // 
            // HelpOptn
            // 
            this.HelpOptn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpOptn.Location = new System.Drawing.Point(8, 72);
            this.HelpOptn.Name = "HelpOptn";
            this.HelpOptn.Size = new System.Drawing.Size(97, 32);
            this.HelpOptn.TabIndex = 2;
            this.HelpOptn.Text = "Help";
            this.HelpOptn.UseVisualStyleBackColor = true;
            // 
            // AboutOptn
            // 
            this.AboutOptn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AboutOptn.Location = new System.Drawing.Point(8, 39);
            this.AboutOptn.Name = "AboutOptn";
            this.AboutOptn.Size = new System.Drawing.Size(97, 32);
            this.AboutOptn.TabIndex = 1;
            this.AboutOptn.Text = "About";
            this.AboutOptn.UseVisualStyleBackColor = true;
            this.AboutOptn.Click += new System.EventHandler(this.AboutOptn_Click);
            // 
            // SignOutOptn
            // 
            this.SignOutOptn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignOutOptn.Location = new System.Drawing.Point(8, 6);
            this.SignOutOptn.Name = "SignOutOptn";
            this.SignOutOptn.Size = new System.Drawing.Size(97, 32);
            this.SignOutOptn.TabIndex = 0;
            this.SignOutOptn.Text = "Sign Out";
            this.SignOutOptn.UseVisualStyleBackColor = true;
            this.SignOutOptn.Click += new System.EventHandler(this.SignOutOptn_Click);
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.AutoScroll = true;
            this.WelcomePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WelcomePanel.Location = new System.Drawing.Point(297, 80);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(849, 519);
            this.WelcomePanel.TabIndex = 4;
            // 
            // DeptHdPnl
            // 
            this.DeptHdPnl.Controls.Add(this.AddNewPnl);
            this.DeptHdPnl.Controls.Add(this.DeptLbl);
            this.DeptHdPnl.Location = new System.Drawing.Point(12, 80);
            this.DeptHdPnl.Name = "DeptHdPnl";
            this.DeptHdPnl.Size = new System.Drawing.Size(282, 48);
            this.DeptHdPnl.TabIndex = 0;
            // 
            // AddNewPnl
            // 
            this.AddNewPnl.Controls.Add(this.newLbl);
            this.AddNewPnl.Controls.Add(this.newPic);
            this.AddNewPnl.Location = new System.Drawing.Point(182, 3);
            this.AddNewPnl.Name = "AddNewPnl";
            this.AddNewPnl.Size = new System.Drawing.Size(97, 45);
            this.AddNewPnl.TabIndex = 1;
            // 
            // newLbl
            // 
            this.newLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLbl.Location = new System.Drawing.Point(37, 13);
            this.newLbl.Name = "newLbl";
            this.newLbl.Size = new System.Drawing.Size(39, 23);
            this.newLbl.TabIndex = 2;
            this.newLbl.Text = "New";
            this.newLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newLbl_MouseDown);
            this.newLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newLbl_MouseUp);
            // 
            // newPic
            // 
            this.newPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPic.Image = ((System.Drawing.Image)(resources.GetObject("newPic.Image")));
            this.newPic.Location = new System.Drawing.Point(3, 3);
            this.newPic.Name = "newPic";
            this.newPic.Size = new System.Drawing.Size(43, 39);
            this.newPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newPic.TabIndex = 0;
            this.newPic.TabStop = false;
            this.newPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPic_MouseDown);
            this.newPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newPic_MouseUp);
            // 
            // DeptLbl
            // 
            this.DeptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptLbl.Location = new System.Drawing.Point(18, 12);
            this.DeptLbl.Name = "DeptLbl";
            this.DeptLbl.Size = new System.Drawing.Size(171, 27);
            this.DeptLbl.TabIndex = 0;
            this.DeptLbl.Text = "DEPARTMENTS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 564);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // DepartmentsFlowLayoutPanel
            // 
            this.DepartmentsFlowLayoutPanel.Location = new System.Drawing.Point(12, 131);
            this.DepartmentsFlowLayoutPanel.Name = "DepartmentsFlowLayoutPanel";
            this.DepartmentsFlowLayoutPanel.Size = new System.Drawing.Size(279, 383);
            this.DepartmentsFlowLayoutPanel.TabIndex = 5;
            // 
            // AddNewDeptToolTip
            // 
            this.AddNewDeptToolTip.ToolTipTitle = "Add New Department";
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1158, 614);
            this.Controls.Add(this.MenuPnl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.HeaderPnl);
            this.Controls.Add(this.DepartmentsFlowLayoutPanel);
            this.Controls.Add(this.DeptHdPnl);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimumSize = new System.Drawing.Size(1174, 653);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Instrument Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CategoryPage_FormClosed);
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            this.RightToLeftLayoutChanged += new System.EventHandler(this.WelcomePage_RightToLeftLayoutChanged);
            this.Resize += new System.EventHandler(this.WelcomePage_Resize);
            this.HeaderPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EgbinPic)).EndInit();
            this.MenuPnl.ResumeLayout(false);
            this.DeptHdPnl.ResumeLayout(false);
            this.AddNewPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.PictureBox EgbinPic;
        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.PictureBox MenuIcon;
        private System.Windows.Forms.Panel WelcomePanel;
        private System.Windows.Forms.Panel DeptHdPnl;
        private System.Windows.Forms.Panel AddNewPnl;
        private System.Windows.Forms.Label newLbl;
        private System.Windows.Forms.PictureBox newPic;
        private System.Windows.Forms.Label DeptLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MenuPnl;
        private System.Windows.Forms.Button HelpOptn;
        private System.Windows.Forms.Button AboutOptn;
        private System.Windows.Forms.Button SignOutOptn;
        private System.Windows.Forms.FlowLayoutPanel DepartmentsFlowLayoutPanel;
        private System.Windows.Forms.ToolTip AddNewDeptToolTip;
    }
}