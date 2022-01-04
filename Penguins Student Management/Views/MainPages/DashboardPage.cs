using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using Penguins_Student_Management.Views.CourseViews;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.MainPages
{
    public partial class DashboardPage : Form, IObserver
    {
        public MainView OwnerForm;
        TheRiver River;
        AuthController Auth;

        public DashboardPage()
        {
            InitializeComponent();
            this.FormClosing += Dashboard_FormClosing;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            Auth = Hook.of<AuthController>(River);
            InitDashboardState();
        }


        private void InitDashboardState()
        {

            PictureBoxUserAvatar.Image = Auth.GetCurrentUser.Type == User.AccountType.Student ? Properties.Resources.icons8_student_male_48 : Auth.GetCurrentUser.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48;
            LabelUsername.Text = Hook.of<AuthController>(River).GetCurrentUser.Name;
            LabelUserID.Text = Hook.of<AuthController>(River).GetCurrentUser.ID;


            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            Hook.of<CourseController>(River).GetCourseOfUser(Hook.of<AuthController>(River).GetCurrentUser).ForEach(course =>
            {
                ListItem item = new ListItem
                {
                    ID = course.ID,
                    PrefixIcon = Properties.Resources.icons8_read_48,
                    IconRadius = 0,
                    Title = course.Name,
                    Size = new Size(572, 72)
                };

                item.Click += ListItemClickHandle;

                Panel.Controls.Add(item);

            });
        }

        private void ListItemClickHandle(object sender, EventArgs e)
        {
            string id = ((ListItem)sender).ID;

            CourseDetailView view = new CourseDetailView(id);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();

        }

        private void SideMenuItemChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordView view = new ChangePasswordView();
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

        private void SideMenuItemSignOut_Cick(object sender, EventArgs e)
        {
            Auth.SignOut();

            if (Auth.State == AuthState.NONE)
            {
                OwnerForm.Hide();

                OwnerForm.TabPages.ForEach(page =>
                {
                    River.DisposeObservable((IObserver)page);
                });

                River.DisposeObservable(OwnerForm);

                LoginView view = new LoginView();
                River.CreateObservableWithoutNotify(view);
                view.ShowDialog();
                OwnerForm.Close();
            }

        }

        private void SideMenuItemLogInfo_Click(object sender, EventArgs e)
        {
            LoginDetailView view = new LoginDetailView(Auth.GetCurrentUser.ID);
            view.SetState(River);
            view.ShowDialog();
        }
    }
}
