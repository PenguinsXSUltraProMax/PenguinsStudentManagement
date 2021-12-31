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
    public partial class TeacherPage : Form, IObserver
    {
        TheRiver River;
        public TeacherPage()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }

        public void SetState(TheRiver value)
        {
            River = value;
            InitTeacherState();
        }

        private void InitTeacherState()
        {

            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            Hook.of<UserController>(River).GetAllTeacher().ForEach(user => {

                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = user.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48,
                    IconRadius = 0,
                    Title = user.Name,
                    Size = new System.Drawing.Size(855, 72)
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
            CreateUserView createUserView = new CreateUserView(User.AccountType.Teacher);
            River.CreateObservable(createUserView);
            createUserView.ShowDialog();
        }
    }
}
