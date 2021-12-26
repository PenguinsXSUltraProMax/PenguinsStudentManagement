using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.Controllers.UserController;

namespace Penguins_Student_Management.Views
{
    public partial class MainView : Form, IObserver
    {

        TheRiver River;
        AuthController authController;

        public MainView()
        {
            InitializeComponent();

            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            
        }

        public void SetState(TheRiver value)
        {
            River = value;
            authController = Hook.of<AuthController>(River);

            ShowHideMenuItem();
            InitDashboardState();
            InitStudentState();
        }

        private void ShowHideMenuItem()
        {
            sideMenuItemStudent.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
            sideMenuItemTeacher.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
            sideMenuItemClass.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
            sideMenuItemCourse.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
        }

        private void InitDashboardState()
        {
            userAvatar.Load(authController.GetCurrentUser.ImgUrl ?? "https://api.minimalavatars.com/avatar/random/png");
            userAvatar.Image = cropImage(userAvatar.Image, Rectangle.FromLTRB(0, 0, userAvatar.Image.Width, userAvatar.Image.Width));

            usernameLabel.Text = authController.GetCurrentUser.Name;
            useridLabel.Text = authController.GetCurrentUser.ID;

            coursePanel.Controls.Clear();
            List<Course> courses = Hook.of<CourseController>(River).GetCoursesOfUser(authController.GetCurrentUser);

            courses.ForEach(course =>
            {
                CourseListItem courseListItem = new CourseListItem();
                courseListItem.CourseLabel = course.Name;
                coursePanel.Controls.Add(courseListItem);

            });
        }

        private void InitStudentState()
        {
            studentPanel.Controls.Clear();
            List<User> users = Hook.of<UserController>(River).GetAllStudent();

            users.ForEach(user => {
                UserListItem userListItem = new UserListItem();
                userListItem.Image = user.ImgUrl;
                userListItem.Id = user.ID;
                userListItem.Username = user.Name;
                userListItem.Classes = user.Classes[0];

                userListItem.Click += UserListItemClickHandle;

                studentPanel.Controls.Add(userListItem);
            });
        }

        private void UserListItemClickHandle(object sender, EventArgs e)
        {
            string id = ((UserListItem)sender).Id;

            EditUserView editUserView = new EditUserView(id);
            River.CreateObservable(editUserView);
            editUserView.ShowDialog();
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        private void SideMenuItemDashboard_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }
        private void SideMenuItemMessages_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }
        private void SideMenuItemStudent_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void sideMenuItemTeacher_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }
        private void sideMenuItemClass_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }
        private void sideMenuItemCourse_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 5;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    {
                        SideMenuItemActiveHandle(0);
                        break;
                    }
                case 1:
                    {
                        SideMenuItemActiveHandle(1);
                        break;
                    }
                case 2:
                    {
                        SideMenuItemActiveHandle(2);
                        break;
                    }
                case 3:
                    {
                        SideMenuItemActiveHandle(3);
                        break;
                    }
                case 4:
                    {
                        SideMenuItemActiveHandle(4);
                        break;
                    }
                case 5:
                    {
                        SideMenuItemActiveHandle(5);
                        break;
                    }
            }
        }

        private void SideMenuItemActiveHandle(int index)
        {
            List<SideMenuItem> sideMenuItems = new List<SideMenuItem>() {
                sideMenuItemDashboard, sideMenuItemMessages, sideMenuItemStudent, sideMenuItemTeacher, sideMenuItemClass, sideMenuItemCourse
            };

            for(int i = 0; i < sideMenuItems.Count; i++)
            {
                sideMenuItems[i].IsActive = i == index ? true : false;
            }
        }

        private void sideMenuItemChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordView changePasswordView = new ChangePasswordView();
            River.CreateObservable(changePasswordView);
            changePasswordView.ShowDialog();
        }

        private void sideMenuItemSignOut_Click(object sender, EventArgs e)
        {
            authController.SignOut();

            if(authController.State == AuthState.NONE)
            {
                River.DisposeObservable(this);
                this.Hide();
                LoginView loginView = new LoginView();
                River.CreateObservable(loginView);
                loginView.ShowDialog();
                this.Close();
            }
            
        }

    }
}
