using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.MainTab
{
    public partial class StudentPage : Form, IObserver
    {
        TheRiver River;
        public StudentPage()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }

        public void SetState(TheRiver value)
        {
            River = value;
            InitStudentState();
        }

        private void InitStudentState()
        {

            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            Hook.of<UserController>(River).GetAllStudent().ForEach(user => {

                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = Properties.Resources.icons8_student_male_48,
                    Title = user.Name,
                    Description = user.Class,
                    RightTitle = user.ID,
                    Size = new Size(855, 72)
                };

                item.Click += ListItemClickHandle;

                Panel.Controls.Add(item);

            });
        }

        private void ListItemClickHandle(object sender, EventArgs e)
        {
            string id = ((ListItem)sender).ID;

            UserDetailView userDetailView = new UserDetailView(id);
            River.CreateObservable(userDetailView);
            userDetailView.ShowDialog();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CreateUserView createUserView = new CreateUserView(User.AccountType.Student);
            River.CreateObservable(createUserView);
            createUserView.ShowDialog();
        }
    }
}
