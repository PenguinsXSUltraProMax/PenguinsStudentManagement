using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.MainTab
{
    public partial class Student : Form, IObserver
    {
        TheRiver River;
        public Student()
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
            studentPanel.Controls.Clear();
            List<User> users = Hook.of<UserController>(River).GetAllStudent();

            users.ForEach(user => {

                UserListItem userListItem = new UserListItem
                {
                    Id = user.ID,
                    Username = user.Name,
                    Classes = user.Classes[0]
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
