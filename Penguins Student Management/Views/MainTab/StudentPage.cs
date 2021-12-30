using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
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

            Global.DisposeControls(studentPanel.Controls);
            studentPanel.Controls.Clear();

            List<User> users = Hook.of<UserController>(River).GetAllStudent();

            users.ForEach(user => {

                UserListItem userListItem = new UserListItem
                {
                    Id = user.ID,
                    Username = user.Name,
                    Class = user.Class
                };

                userListItem.Click += UserListItemClickHandle;

                studentPanel.Controls.Add(userListItem);

            });
        }

        private void UserListItemClickHandle(object sender, EventArgs e)
        {
            string id = ((UserListItem)sender).Id;

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
