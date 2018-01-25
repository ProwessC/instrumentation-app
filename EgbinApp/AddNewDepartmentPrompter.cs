using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace EgbinApp
{
    class AddNewDepartmentPrompter
    {
        PictureBox NewDepartmentIcon;
        TextBox DepartmentNameTextBox;
        TextBox DepartmenticonTextbox;
        WelcomePage welcomePageForm;
        Form NewDepartmentDetailsForm;
        string deptName, deptImage;
        Button done;
        public AddNewDepartmentPrompter(WelcomePage welcomePageForm)
        {
            this.welcomePageForm = welcomePageForm;
        }
        public void ShowDialog()
        {
            NewDepartmentDetailsForm = new Form()
            {
                Width = 400,
                Height = 340,
                MaximizeBox = false,
                Icon=EgbinApp.Properties.Resources.addredpicicon,
                StartPosition = FormStartPosition.CenterParent
            };
            FlowLayoutPanel fp = new FlowLayoutPanel();
            fp.Width = NewDepartmentDetailsForm.Width;
            Label EnterDepartmentNameLabel = new Label()
            {
                Text = "Enter Department Name:",
                Location = new Point(2, 2),
                TextAlign = ContentAlignment.MiddleLeft,
                Height = 28,
                AutoSize = false,
                Width = (int)(0.9 * NewDepartmentDetailsForm.Width),
                Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular)
            };
            DepartmentNameTextBox = new TextBox()
            {
                Width = fp.Width - 50,
                Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular),
                TextAlign = HorizontalAlignment.Left
            };
            Label DepartmentIconLabel = new Label()
            {
                Text = "Department Icon:",
                Location = new Point(2, 50),
                TextAlign = ContentAlignment.MiddleLeft,
                Height = 28,
                AutoSize = false,
                Width = (int)(0.9 * NewDepartmentDetailsForm.Width),
                Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular)
            };
            Panel SelectIconPanel = new Panel();
            SelectIconPanel.Width = fp.Width;

            DepartmenticonTextbox = new TextBox()
            {
                Width = fp.Width - 90,
                Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular),
                TextAlign = HorizontalAlignment.Left,
                
            };

            Button selectButton = new Button()
            {
                Text = "Select",
                Width = 65,
                Height = DepartmenticonTextbox.Height + 2,
                Location = new Point(DepartmenticonTextbox.Location.X + DepartmenticonTextbox.Width, DepartmenticonTextbox.Location.Y - 1)
            };

            selectButton.Click += new EventHandler(showChooser);

            NewDepartmentDetailsForm.Controls.Add(EnterDepartmentNameLabel);
            fp.Controls.Add(DepartmentNameTextBox);
            fp.Controls.Add(DepartmentIconLabel);

            SelectIconPanel.Controls.Add(DepartmenticonTextbox);
            SelectIconPanel.Controls.Add(selectButton);

            fp.Controls.Add(SelectIconPanel);
            fp.Location = new Point(2, 2 + EnterDepartmentNameLabel.Height + 2);

            NewDepartmentIcon = new PictureBox()
            {
                Width = 80,
                Height = 80,
                Location = new Point(fp.Location.X+160, fp.Location.Y + fp.Height + 20),
                BackColor=Color.IndianRed
            };

            done = new Button()
            {
                Text = "DONE",
                Location = new Point(NewDepartmentIcon.Location.X, NewDepartmentIcon.Location.Y + NewDepartmentIcon.Height + 10),
                AutoSize = true
            };
            done.Click += new EventHandler(doneHandler);

            NewDepartmentDetailsForm.Controls.Add(fp);
            NewDepartmentDetailsForm.Controls.Add(NewDepartmentIcon);
            NewDepartmentDetailsForm.Controls.Add(done);
            NewDepartmentDetailsForm.ShowDialog();
        }
        public void showChooser(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files (*.jpeg, *.jpg, *.png, *.gif. *.bmp)|*.jpeg; *.jpg; *.png; *.gif; *.bmp";
            DialogResult result = op.ShowDialog();
            DepartmenticonTextbox.Text = op.FileName;
            NewDepartmentIcon.Image = Image.FromFile(op.FileName);
            NewDepartmentIcon.SizeMode = PictureBoxSizeMode.Zoom;
            Button bb = (Button)sender;
            //bb.BackColor = Color.Red;
        }
        public void doneHandler(object sender, EventArgs e)
        {

            deptName = DepartmentNameTextBox.Text;
            deptImage = DepartmenticonTextbox.Text;
            welcomePageForm.addDepartment(deptName, deptImage);//this is where the add deartment method with the string imagename argument is used
            NewDepartmentDetailsForm.Dispose();
        }
    }
}
