using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgbinApp
{
    public partial class WelcomePage : Form

    {
        int departmentChosen = 0;
        Form AboutPage;
        Panel DepartmentInformationPanel;
        Panel DepartmentHeaderPanel;
        PictureBox DefaultDepartmentPictureBox;
        Label DepartmentDescriptionHeaderLabel;
        Label DepartmentDescriptionLabel;
        Label DefaultDepartmentLabel;
        Button EditButton;

        Panel MachinesPanel;
        Panel SelectMachinePanel;
        Label SelectUnitLabel;
        ComboBox SelectUnitComboBox;
        Label SelectVoltageLabel;
        ComboBox SelectVoltageComboBox;
        Button FindEquipmentButton;
        ListBox EquipmentListBox;
        Button AddNewMachineButton;
        Panel MachineInformationPanel;
        Label MachineNameLabel;
        Label MachineDescriptionLabel;
        Label MaintenanceRecordsLabel;
        TextBox SearchTextBox;
        Button SearchButton;
        Label SNLabel;
        Label JobDescriptionLabel;
        Label DateStartedLabel;
        Label DateFinishedLabel;
        Button AddNewRecordButton;
        FlowLayoutPanel MaintenanceRecordFlowPanel;

        public WelcomePage()
        {
            InitializeComponent();
            //MenuPnl.BringToFront();
            addDepartment("BOILER", EgbinApp.Properties.Resources.boiler);
            addDepartment("ELECTRICAL", EgbinApp.Properties.Resources.electrical);
            addDepartment("I AND C", EgbinApp.Properties.Resources.ic);
            addDepartment("TURBINE", EgbinApp.Properties.Resources.turbine);
            addDepartment("WORKSHOP", EgbinApp.Properties.Resources.workshop);


        }

        private void EgbinPic_Click(object sender, EventArgs e)
        {

        }

        private void MenuIcon_Click(object sender, EventArgs e)
        { 
            //to display the menu panel which is visible when the picture changes to the x-shape
            MenuPnl.Visible = !MenuPnl.Visible;
            MenuIcon.Image = MenuPnl.Visible ?
                //global::EgbinInstrumentInfoApp.Properties.Resources.makefg : global::EgbinInstrumentInfoApp.Properties.Resources.hamburger;
                global::EgbinApp.Properties.Resources.makefg : global::EgbinApp.Properties.Resources.hamburger;
        }

       
        private void CategoryPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
        private void WelcomePage_Resize(object sender, EventArgs e)
        {
            //when the form is resized
            HeaderPnl.Width = this.Width- 40;
            DepartmentsFlowLayoutPanel.Height = (int)(this.Height - HeaderPnl.Height - 219);
            WelcomePanel.Height = this.Height - WelcomePanel.Location.Y - 50;
            WelcomePanel.Width = this.Width - (DepartmentsFlowLayoutPanel.Width + 40);

            if (departmentChosen==1)
            {
                //when the button is clicked
                DepartmentInformationPanel.Width = WelcomePanel.Width;
                DepartmentInformationPanel.Height = WelcomePanel.Height;

                DepartmentHeaderPanel.Width = DepartmentInformationPanel.Width;
                DefaultDepartmentPictureBox.Location = new System.Drawing.Point(390, 3);
                DefaultDepartmentLabel.Location = new Point(448, 9);
                EditButton.Location = new System.Drawing.Point(WelcomePanel.Width - 90, 9);

                MachinesPanel.Height = (int)(this.Height - 290);
                MachinesPanel.Width = WelcomePanel.Width - 20;

                SelectMachinePanel.Height = (int)(SelectMachinePanel.Parent.Height - 8);
                EquipmentListBox.Height = (int)(EquipmentListBox.Parent.Height - 200);
                EquipmentListBox.Location = new Point(7, 157);
                AddNewMachineButton.Location = new Point((SelectMachinePanel.Width - 130) / 2, EquipmentListBox.Location.Y + EquipmentListBox.Height + 10);

                MachineInformationPanel.Height = SelectMachinePanel.Height;
                MachineInformationPanel.Width = (int)(MachinesPanel.Width - SelectMachinePanel.Width - 15);

                

                SearchTextBox.Width = MachineInformationPanel.Width - MaintenanceRecordsLabel.Width - MaintenanceRecordsLabel.Location.X - 100;
                SearchButton.Location = new Point(SearchTextBox.Location.X + SearchTextBox.Width, SearchTextBox.Location.Y);
                MaintenanceRecordFlowPanel.Width = (int)(0.94 * MachineInformationPanel.Width);
                //MaintenanceRecordFlowPanel.Width = (int)(MachineInfoPanel.Width - 15);
                MaintenanceRecordFlowPanel.Height = (int)(MachineInformationPanel.Height - SNLabel.Location.Y - SNLabel.Height - 8.9);
                //JobDescriptionLabel.Location = new Point(SNLabel.Location.X + SNLabel.Width, SNLabel.Location.Y);
                JobDescriptionLabel.Width = MaintenanceRecordFlowPanel.Width - (32 + 65 + 70 + 128);
                DateStartedLabel.Location = new Point(SNLabel.Location.X + SNLabel.Width + JobDescriptionLabel.Width, SNLabel.Location.Y);
                DateFinishedLabel.Location = new Point(SNLabel.Location.X + SNLabel.Width + JobDescriptionLabel.Width + DateStartedLabel.Width, SNLabel.Location.Y);
                AddNewRecordButton.Location = new Point(MachineInformationPanel.Width - 13 - 75, DateFinishedLabel.Location.Y);
            }
            


        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }

        private void SignOutOptn_Click(object sender, EventArgs e)
        {
            //when the sign out button is clicked
            this.Dispose();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void AboutOptn_Click(object sender, EventArgs e)
        {
            //a dialog pops up with information about the application
            AboutPage = new Form()
            {
                Width = 400,
                Height = (this.Height / 2) + 20,
                MaximizeBox = false,
                StartPosition = FormStartPosition.CenterScreen,
                Icon = EgbinApp.Properties.Resources.about,
                BackColor = Color.White

            };

            Label AboutLabel = new Label()
            {
                Text = "ABOUT",
                Font = new Font("Cambria", 20F, FontStyle.Bold),
                AutoSize = true,
                Left = (AboutPage.Width / 2) - 60
            };

            Label AboutInfoLabel = new Label()
            {
                Font = new Font("Calibri", 12F, FontStyle.Regular),
                Text = "The Instrument Information app is a platform that provides you with basic information and maintenance records of the various equipment in Egbin Power Plc.\nWith Instrument Information you are able to see all the jobs done on an equipment with detailed explanation of what was done and how it was carried out.\nIt aims at helping to reduce downtime and makes rectifying faults faster than ever with the aid of a guide.\nIt provides you with a wealth of experience at your finger tips. \n\nThis app was designed and built by: \nRichard-Chukkas Prowess (08089000806) \nOyefeso Oluwagbemileke (08088658898)",
                Width = AboutPage.Width - 25,
                Height = AboutPage.Height - 10,
                Left = 5,
                Top = AboutLabel.Location.Y + AboutLabel.Height + 15,
            };

            AboutPage.Controls.Add(AboutLabel);
            AboutPage.Controls.Add(AboutInfoLabel);
            AboutPage.ShowDialog();
        }

        private void AddDepartmentInformationPanel(Image departmentImage, String departmentName)
        {
            DepartmentInformationPanel = new Panel()
            {
                BackColor = System.Drawing.SystemColors.MenuBar,
                ForeColor=SystemColors.ControlText,
                //BackColor=SystemColors.InactiveCaption,
                Location = new System.Drawing.Point(297, 80),
                Padding = new System.Windows.Forms.Padding(10),
                Size = WelcomePanel.Size,
                TabIndex = 4
            };
            DepartmentHeaderPanel = new Panel()
            {
                BackColor = System.Drawing.SystemColors.Menu,
                //BackColor=SystemColors.InactiveCaption,
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(WelcomePanel.Width, 48),
                TabIndex = 0
            };
            DefaultDepartmentPictureBox = new PictureBox()
            {
                Anchor = System.Windows.Forms.AnchorStyles.None,
                Image = departmentImage,
                Location = new System.Drawing.Point(283, 3),
                Size = new System.Drawing.Size(55, 42),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
                TabIndex = 6,
                TabStop = false
            };

            DefaultDepartmentLabel = new Label()
            {
                Anchor = System.Windows.Forms.AnchorStyles.None,
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular),
                ForeColor = System.Drawing.SystemColors.ControlText,
                Location = new System.Drawing.Point(341, 9),
                Size = new System.Drawing.Size(167, 29),
                TabIndex = 0,
                Text = departmentName
            };
            EditButton = new Button()
            {
                Location = new System.Drawing.Point(DepartmentInformationPanel.Width - 90, 9),
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 7,
                Text = "EDIT"
            };

            DepartmentHeaderPanel.Controls.Add(DefaultDepartmentPictureBox);
            DepartmentHeaderPanel.Controls.Add(DefaultDepartmentLabel);
            DepartmentHeaderPanel.Controls.Add(EditButton);

            DepartmentDescriptionHeaderLabel = new Label()
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline),
                ForeColor = System.Drawing.SystemColors.ControlText,
                Location = new System.Drawing.Point(0, 72),
                Size = new System.Drawing.Size(209, 25),
                TabIndex = 1,
                Text = "Descriptive Information",
            };
            DepartmentDescriptionLabel = new Label()
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular),
                Location = new System.Drawing.Point(2, 108),
                Size = new System.Drawing.Size(475, 17),
                TabIndex = 2,
                Text = "Brief description to guide first time users or just for the sake of being there",
            };
            
           
            DepartmentInformationPanel.Controls.Add(DepartmentHeaderPanel);
            DepartmentInformationPanel.Controls.Add(DepartmentDescriptionHeaderLabel);
            DepartmentInformationPanel.Controls.Add(DepartmentDescriptionLabel);
            //DepartmentInformationPanel.BringToFront();

            //AddMachinesPanel();
            AddMachinesPanel(DepartmentInformationPanel);
            this.Controls.Add(DepartmentInformationPanel);
        }

        private void AddMachinesPanel(Panel parentPanel)
        {
            MachinesPanel = new Panel()
            {
                BackColor = Color.DimGray,
                Height = (int)(this.Height - 290),
                Width = WelcomePanel.Width - 20,
                Top = 150,
                Left = 10,
                //Margin = new Padding() { All = (int)(0.01 * MachineInfoPanel.Width)}
                //Padding Margin
                //Padding = new Padding() { All = 10, /*Top=10, Bottom=10, Left=10, Right=10*/}
            };

            AddSelectMachinePanel(MachinesPanel);
            AddMachineInformationPanel(MachinesPanel);
            //DepartmentInformationPanel.Controls.Add(MachinesPanel);
            parentPanel.Controls.Add(MachinesPanel);
            MachinesPanel.BringToFront();

        }

        private void AddSelectMachinePanel(Panel parentPanel)
        {
            //this panel is created to allow the operator select the equipment of his choice
            SelectMachinePanel = new Panel()
            {
                BackColor = SystemColors.MenuBar,
                Height = (int)(parentPanel.Height - 8),
                Width = (int)(250),
                Left = (int)(0.005 * parentPanel.Width),
                Top = (int)(0.005 * parentPanel.Width),

                //Padding=new Padding() {All=5 }

            };

            SelectUnitLabel = new Label()
            {
                Text = "Select Unit",
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular),
                ForeColor = SystemColors.ControlText,
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(4, 22),
                Size = new Size(90, 20),
                TabIndex = 0

            };

            SelectUnitComboBox = new ComboBox()
            {
                Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular), /*System.Drawing.GraphicsUnit.Point, ((byte)(0))),*/
                FormattingEnabled = true,
                Location = new Point(95, 22),
                Size = new Size(145, 28),
                TabIndex = 2,
                Text = "--Select--"

            };
            SelectUnitComboBox.Items.AddRange(new object[] { "Unit 1", "Unit 2", "Unit 3", "Unit 4", "Unit 5", "Unit 6", "Common Equipment" });

            SelectVoltageLabel = new Label()
            {
                Location = new Point(4, 68),
                Size = new Size(100, 45),
                TabIndex = 1,
                Text = "Select Voltage\nRating",
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular),
                ForeColor = SystemColors.ControlText
            };

            SelectVoltageComboBox = new ComboBox()
            {
                Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular),
                FormattingEnabled = true,
                Location = new Point(105, 68),
                Size = new Size(135, 28),
                TabIndex = 3,
                Text = "--Select--",

            };
            SelectVoltageComboBox.Items.AddRange(new object[] { "6.6kV", "415V", "240V", "110V" });


            FindEquipmentButton = new Button()
            {
                Size = new Size(175, 27),
                TabIndex = 4,
                Text = "FIND",
                Location = new Point(35, 119),
                UseVisualStyleBackColor = true
            };

            EquipmentListBox = new ListBox()
            {
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                FormattingEnabled = true,
                ItemHeight = 20,
                Location = new Point(7, 157),
                Size = new Size(233, (int)(SelectMachinePanel.Height - 200)),
                TabIndex = 5


            };
            AddNewMachineButton = new Button()
            {
                Size = new Size(130, 27),
                TabIndex = 4,
                Text = "New Machine",
                Location = new Point((SelectMachinePanel.Width - 130) / 2, EquipmentListBox.Location.Y + EquipmentListBox.Height),
                UseVisualStyleBackColor = true
            };
            //SelectUnitComboBox.SelectedIndexChanged += SelectUnitComboBox_SelectedIndexChanged;
            //SelectUnitComboBox.SelectedIndexChanged+=  
            //this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            //this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            //this.button4.Click += new System.EventHandler(this.button4_Click)};
            //this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);


            SelectMachinePanel.Controls.Add(SelectUnitLabel);
            SelectMachinePanel.Controls.Add(SelectUnitComboBox);
            SelectMachinePanel.Controls.Add(SelectVoltageLabel);
            SelectMachinePanel.Controls.Add(SelectVoltageComboBox);
            SelectMachinePanel.Controls.Add(FindEquipmentButton);
            SelectMachinePanel.Controls.Add(EquipmentListBox);
            SelectMachinePanel.Controls.Add(AddNewMachineButton);
            //SelectMachinePanel.Controls.AddRange(Control[]controls = new Control { SelectUnitLabel, });

            parentPanel.Controls.Add(SelectMachinePanel);
            SelectMachinePanel.BringToFront();


        }

        private void AddMachineInformationPanel(Panel parentPanel)
        {
            //this is to display the machine information as a result of what was clicked in the select machines panel
            MachineInformationPanel = new Panel()
            {
                BackColor = SystemColors.MenuBar,
                Height = (int)(parentPanel.Height - 8),
                Width = (int)(MachinesPanel.Width - SelectMachinePanel.Width - 15),
                Left = (int)(SelectMachinePanel.Width + 10),
                Top = (int)(0.005 * parentPanel.Width),
                AutoScroll = true
            };

            MachineNameLabel = new Label()
            {

                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 15.75F, /*FontStyle.Regular*/ System.Drawing.FontStyle.Underline),
                ForeColor = SystemColors.ControlText,
                Location = new Point(12, 22),
                Size = new Size(156, 25),
                TabIndex = 8,
                Text = "Machine Name",
                Anchor = AnchorStyles.Top | AnchorStyles.Left

            };


            MachineDescriptionLabel = new Label()
            {

                Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular),
                Location = new Point(16, 55),
                //Size = new Size(600, 56),
                AutoSize = true,
                TabIndex = 9,
                Text = "Brief description and information about the selected machine"
            };

            MaintenanceRecordsLabel = new Label()
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular),
                Location = new Point(20, 100),
                Left = 20,
                Size = new Size(165, 25),
                TabIndex = 7,
                Text = "Maintenance Records"
            };

            SearchTextBox = new TextBox()
            {
                //the maintenace records will be changing as operator is inputing his search
                Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular),
                Location = new Point(MaintenanceRecordsLabel.Location.X + MaintenanceRecordsLabel.Width, 100),
                //Size = new Size(400, 24),
                Width = MachineInformationPanel.Width - MaintenanceRecordsLabel.Width - MaintenanceRecordsLabel.Location.X - 100,
                Height = 19,
                TabIndex = 2,
            };

            SearchButton = new Button()
            {
                //we might not have need for this button, let us just be searching as the operator is typing his search
                Location = new Point(SearchTextBox.Location.X + SearchTextBox.Width, SearchTextBox.Location.Y),
                Width = 75,
                Visible = false,
                Height = SearchTextBox.Height,
                TabIndex = 3,
                Text = "SEARCH",
                UseVisualStyleBackColor = true,
                //this.button3.Click += new System.EventHandler(this.button3_Click);
            };
            SNLabel = new Label()
            {
                BackColor = Color.LightGray,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular),
                Location = new Point(22, 130),
                Left = 22,
                Size = new Size(32, 28),
                TabIndex = 4,
                Text = "S/N",
                TextAlign = ContentAlignment.MiddleLeft
            };
            JobDescriptionLabel = new Label()
            {
                BackColor = Color.DarkGray,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular),
                Location = new Point(SNLabel.Location.X + SNLabel.Width, SNLabel.Location.Y),
                Width = DepartmentHeaderPanel.Width - 420 - (32 + 65 + 70 + 128),
                Height = 28,
                TabIndex = 5,
                Text = "JOB DESCRIPTION",
                TextAlign = ContentAlignment.MiddleLeft
            };

            DateStartedLabel = new Label()
            {
                BackColor = Color.LightGray,
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular),
                Location = new Point(SNLabel.Location.X + SNLabel.Width + JobDescriptionLabel.Width, SNLabel.Location.Y),
                Size = new Size(65, 28),
                TabIndex = 6,
                Text = "Date Started",
                TextAlign = ContentAlignment.TopLeft,
                AutoEllipsis = true

            };

            DateFinishedLabel = new Label()
            {
                BackColor = Color.LightGray,
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular),
                Location = new Point(SNLabel.Location.X + SNLabel.Width + JobDescriptionLabel.Width + DateStartedLabel.Width, SNLabel.Location.Y),
                Size = new Size(70, 28),
                TabIndex = 6,
                Text = "Date Finished",
                TextAlign = ContentAlignment.TopLeft,
                AutoEllipsis = true

            };
            AddNewRecordButton = new Button()
            {
                Text = "New Record",
                Width = 75,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular),
                Height = SNLabel.Height,
                Location = new Point(MachineInformationPanel.Width - 13 - 75, DateFinishedLabel.Location.Y),
                UseVisualStyleBackColor = true
            };


            MaintenanceRecordFlowPanel = new FlowLayoutPanel()
            {
                //this is where the maintenance records will be displayed
                BackColor = Color.DarkGray,
                Location = new Point(22, 160),
                Size = new Size(670, 167),
                Width = (int)(0.94 * MachineInformationPanel.Width),
                Height = (int)(MachineInformationPanel.Height - SNLabel.Location.Y - SNLabel.Height - 9),
                TabIndex = 10,
                AutoScroll = true
            };
            //MessageBox.Show(MachineInfoPanel.Height.ToString() + "--" + MachineNameLabel.Location.Y.ToString()+"-" + MaintenanceRecordsLabel.Location.Y.ToString());
            MachineInformationPanel.Controls.Add(MachineNameLabel);
            MachineInformationPanel.Controls.Add(MachineDescriptionLabel);
            MachineInformationPanel.Controls.Add(MaintenanceRecordsLabel);
            MachineInformationPanel.Controls.Add(SearchTextBox);
            MachineInformationPanel.Controls.Add(SearchButton);
            MachineInformationPanel.Controls.Add(SNLabel);
            MachineInformationPanel.Controls.Add(JobDescriptionLabel);
            MachineInformationPanel.Controls.Add(DateStartedLabel);
            MachineInformationPanel.Controls.Add(DateFinishedLabel);
            MachineInformationPanel.Controls.Add(AddNewRecordButton);

            MachineInformationPanel.Controls.Add(MaintenanceRecordFlowPanel);
            //AddMaintenanceRecord(numberOfRecords, MaintenanceRecordFlowPanel.Height / 30);



            parentPanel.Controls.Add(MachineInformationPanel);
            MachineInformationPanel.BringToFront();
        }

        public void addDepartment(String s, String imageName)
        {
            //TO POPULATE DEPARTMENTS FLOW PANEL
            Button departmentButton = new Button();
            departmentButton.Text = s.ToUpper();
            departmentButton.BackColor = System.Drawing.SystemColors.MenuBar;
            departmentButton.Size = new System.Drawing.Size(250, 71);
            departmentButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            departmentButton.ImageAlign = ContentAlignment.MiddleLeft;
            //b.Image = Image.FromFile("c:\\Users\\Prowess\\Documents\\Visual Studio 2015\\Projects\\view (3).png");
            Image img = Image.FromFile(imageName);
            departmentButton.ForeColor = SystemColors.ControlText;
            departmentButton.Image = resizeImage(img, new Size(62, 56));
            departmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentButton.Click += new EventHandler(ShowDepartmentInformationPanelHandler);
            DepartmentsFlowLayoutPanel.Controls.Add(departmentButton);

        }
        public void addDepartment(String s, Image imageName)
        {
            //this is what is called in the constructor for the department flow panel to show
            Button departmentButton = new Button();
            departmentButton.Text = s.ToUpper();
            departmentButton.ForeColor = SystemColors.ControlText;
            departmentButton.Width = 150;
            departmentButton.Height = 50;
            departmentButton.BackColor = System.Drawing.SystemColors.MenuBar;
            departmentButton.Size = new System.Drawing.Size(250, 71);
            departmentButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            departmentButton.ImageAlign = ContentAlignment.MiddleLeft;
            //b.Image = Image.FromFile("c:\\Users\\Prowess\\Documents\\Visual Studio 2015\\Projects\\view (3).png");
            departmentButton.Image = resizeImage(imageName, new Size(62, 56));
            departmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            
            departmentButton.Click += new EventHandler(ShowDepartmentInformationPanelHandler);//when a department is clicked the panel changes
            DepartmentsFlowLayoutPanel.Controls.Add(departmentButton);

        }

        public Image resizeImage(Image imageToResize, Size size)
        {
            //this method is to RESIZE images to fit the required size for the department button
            //image is converted to a bitmap of required size then casted back to image format
            return (Image)(new Bitmap(imageToResize, size));
        }

        public void ShowDepartmentInformationPanelHandler(object sender, EventArgs e)
        {
            //event to display the department information when the department button is clicked
            Button source = (Button)sender;
            departmentChosen = 1; // when the button is clicked, this changes from 0 to 1
            WelcomePanel.Dispose();
            AddDepartmentInformationPanel(source.Image, source.Text);
            DepartmentInformationPanel.BringToFront();

            DefaultDepartmentPictureBox.Location = new System.Drawing.Point(390, 3);
            DefaultDepartmentLabel.Location = new Point(448, 9);

            
        }

        private void WelcomePage_RightToLeftLayoutChanged(object sender, EventArgs e)
        {

        }

        //the mouse up and mousedown events for a newPic and newLbl is to give thwm a blinking effect together whaen they are clicked
        //and also to tie them to the same method to enable the operator add a new department
        //i.e when they are clicked, they blink and the operator is prompted for an admin password after which it allows you add a new department 
        private void newLbl_MouseUp(object sender, MouseEventArgs e)
        {
            newLbl.Visible = true;
            newPic.Visible = true;
            ConfirmAdministratorPassword();
        }

        private void newLbl_MouseDown(object sender, MouseEventArgs e)
        {
            newLbl.Visible = false;
            newPic.Visible = false;
        }

        private void newPic_MouseUp(object sender, MouseEventArgs e)
        {
            newLbl.Visible = true;
            newPic.Visible = true;
            ConfirmAdministratorPassword();
        }

        private void newPic_MouseDown(object sender, MouseEventArgs e)
        {
            newLbl.Visible = false;
            newPic.Visible = false;
        }

        public void ConfirmAdministratorPassword()
        {
            //this is called when a button that requires administrator permission is clicked
            new AdminPasswordPrompter(this).ShowDialog();
        }

        public void ConfirmAddNewDepartment()
        {
            // this is called to located the class that allows operator input name and icon of department 
            //he wishes to add
            //and afterwards adds this department to the database(still pending)
            new AddNewDepartmentPrompter(this).ShowDialog();
        }
    }
    }
