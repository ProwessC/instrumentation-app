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
    public partial class LoginPage : Form
    {
        String password;
        String staffId;
        Form AboutPage;

        public LoginPage()
        {
            InitializeComponent();
        }
        //CategoryPage category = new CategoryPage();
        WelcomePage welcome = new WelcomePage();
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //this.Close();
            this.Visible=false;
            welcome.Show();
            //new WelcomePage().Show();

            //COME BACK FOR THIS:
            //check database to verify
            //prompt for password if admin or recorder
            //Open WelcomePage
            
            
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            StaffIdPanel.Left = (this.Width - StaffIdPanel.Width) / 2;
            LoginBtn.Left = (this.Width - LoginBtn.Width) / 2;
        }

        private void LoginPage_Resize(object sender, EventArgs e)
        {
            StaffIdPanel.Left = (this.Width - StaffIdPanel.Width) / 2;
            LoginBtn.Left = (this.Width - LoginBtn.Width) / 2;

        }

        private void InfoIcon_Click(object sender, EventArgs e)
        {
            AboutPage = new Form()
            {
                Width = 400,
                Height = 355,
                MaximizeBox = false,
                StartPosition = FormStartPosition.CenterParent,
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

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //DON'T FORGET TO CREATE METHOD TO CHECK STAFF ACCESS LEVEL

    }
}
