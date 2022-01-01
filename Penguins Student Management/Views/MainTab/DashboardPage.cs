using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.Controllers.CourseController;
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
    public partial class DashboardPage : Form, IObserver
    {
        public MainView OwnerForm;
        TheRiver River;
        public DashboardPage()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
            this.FormClosing += Dashboard_FormClosing;
        }
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            InitDashboardState();
        }


        private void InitDashboardState()
        {
            userAvatar.Load("https://ui-avatars.com/api/?background=random&size=32&font-size=0.3&color=fff&name=" + Hook.of<AuthController>(River).GetCurrentUser.Name ?? "https://api.minimalavatars.com/avatar/random/png");

            usernameLabel.Text = Hook.of<AuthController>(River).GetCurrentUser.Name;
            useridLabel.Text = Hook.of<AuthController>(River).GetCurrentUser.ID;


            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            Hook.of<CourseController>(River).GetCoursesOfUser(Hook.of<AuthController>(River).GetCurrentUser).ForEach(course =>
            {
                ListItem item = new ListItem
                {
                    PrefixIcon = Properties.Resources.icons8_read_48,
                    IconRadius = 0,
                    Title = course.Name,
                    Size = new Size(572, 72)
                };

                Panel.Controls.Add(item);

            });
        }

        private void sideMenuItemChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordView changePasswordView = new ChangePasswordView();
            River.CreateObservable(changePasswordView);
            changePasswordView.ShowDialog();
        }

        private void sideMenuItemSignOut_Cick(object sender, EventArgs e)
        {
            Hook.of<AuthController>(River).SignOut();

            if (Hook.of<AuthController>(River).State == AuthState.NONE)
            {
                OwnerForm.Hide();

                OwnerForm.TabPages.ForEach(page =>
                {
                    River.DisposeObservable((IObserver)page);
                });

                River.DisposeObservable(OwnerForm);

                LoginView loginView = new LoginView();
                River.CreateObservable(loginView);
                loginView.ShowDialog();
                OwnerForm.Close();
            }

        }
    }
}
