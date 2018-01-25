using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace EgbinApp
{
    class AdminPasswordPrompter
    {
        //the purpose of this class is to prompt for admin password where needed
        WelcomePage welcomePageForm;
        public AdminPasswordPrompter(WelcomePage welcomePageForm)
        {
            this.welcomePageForm = welcomePageForm;
        }
        Form ConfirmAdminPasswordForm;
        public void ShowDialog()
        {
            ConfirmAdminPasswordForm = new Form()
            {
                Width = 400,
                Height = 120,
                MaximizeBox = false,

                StartPosition = FormStartPosition.CenterParent
            };
            FlowLayoutPanel fp = new FlowLayoutPanel();
            fp.Width = ConfirmAdminPasswordForm.Width;
            Label ConfirmPasswordLabel = new Label()
            {
                Text = "Kindly confirm your admin password:",
                Location = new Point(2, 2),
                TextAlign = ContentAlignment.MiddleLeft,
                Height = 28,
                AutoSize = false,
                Width = (int)(0.9 * ConfirmAdminPasswordForm.Width),
                Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular)
            };
            TextBox EnterPasswordTextBox = new TextBox()
            {
                Width = fp.Width - 100,
                Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular),
                PasswordChar = '*',
                TextAlign = HorizontalAlignment.Left
            };
            Button ConfirmButton = new Button()
            {
                Text = "Confirm",
                Height = EnterPasswordTextBox.Height,
                Width = 70
            };
            ConfirmButton.Click += new EventHandler(clickHandler);
            ConfirmAdminPasswordForm.Controls.Add(ConfirmPasswordLabel);

            fp.Controls.Add(EnterPasswordTextBox);
            fp.Controls.Add(ConfirmButton);
            fp.Location = new Point(2, 2 + ConfirmPasswordLabel.Height + 2);

            ConfirmAdminPasswordForm.Controls.Add(fp);
            ConfirmAdminPasswordForm.ShowDialog();
        }
        public void clickHandler(object sender, EventArgs e)
        {
            //when button is clicked
            ConfirmAdminPasswordForm.Dispose(); //close this form
            welcomePageForm.ConfirmAddNewDepartment();
            //welcomePageForm.confirm2();  //navigate to the method that opens the form to input the new department
        }
    }
}
