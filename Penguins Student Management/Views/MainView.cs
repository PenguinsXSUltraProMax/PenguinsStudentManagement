using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Penguins_Student_Management.Views.MainPages;

namespace Penguins_Student_Management.Views
{
    public partial class MainView : Form, IObserver
    {

        TheRiver River;
        AuthController Auth;

        // TabControl
        public List<Form> TabPages = new List<Form>() {
            new DashboardPage(),
            new StudentPage(),
            new TeacherPage(),
            new ClassPage(),
            new CoursePage(),
            new SearchPage()
        };

        public MainView()
        {
            InitializeComponent();
            this.FormClosing += MainView_FormClosing;

            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            ((DashboardPage)TabPages[0]).OwnerForm = this;
            River.CreateObservableWithoutNotify((IObserver)TabPages[0]);
            TabPageDashboard.Controls.Add(TabPages[0]);

            River.CreateObservableWithoutNotify((IObserver)TabPages[1]);
            TabPageStudent.Controls.Add(TabPages[1]);

            River.CreateObservableWithoutNotify((IObserver)TabPages[2]);
            TabPageTeacher.Controls.Add(TabPages[2]);

            River.CreateObservableWithoutNotify((IObserver)TabPages[3]);
            TabPageClass.Controls.Add(TabPages[3]);

            River.CreateObservableWithoutNotify((IObserver)TabPages[4]);
            TabPageCourse.Controls.Add(TabPages[4]);

            River.CreateObservableWithoutNotify((IObserver)TabPages[5]);
            TabPageSearch.Controls.Add(TabPages[5]);
        }


        public void SetState(TheRiver value)
        {
            River = value;
            Auth = Hook.of<AuthController>(River);

            ShowHideMenuItem();
        }

        private void ShowHideMenuItem()
        {
            bool IsStudent = Auth.GetCurrentUser.Type == User.AccountType.Student;

            SideMenuItemStudent.Visible = !IsStudent;
            SideMenuItemTeacher.Visible = !IsStudent;
            SideMenuItemClass.Visible = !IsStudent;
            SideMenuItemCourse.Visible = !IsStudent;
            TextBoxSearch.Enabled = !IsStudent;
        }


        private void SideMenuItemClickHandle(object sender, EventArgs e) {
            TabControl.SelectedIndex = ((SideMenuItem)sender).Index;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SideMenuItemActiveHandle(TabControl.SelectedIndex);
        }

        private void SideMenuItemActiveHandle(int index)
        {
            List<SideMenuItem> sideMenuItems = new List<SideMenuItem>() {
                SideMenuItemDashboard, SideMenuItemStudent, SideMenuItemTeacher, SideMenuItemClass, SideMenuItemCourse
            };

            for(int i = 0; i < sideMenuItems.Count; i++)
            {
                sideMenuItems[i].IsActive = i == index;
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(TextBoxSearch.Text.Length > 2)
            {
                TabControl.SelectedIndex = 5;
                TextBoxSearch.Focus();
                ((SearchPage)TabPages[5]).BindingSearchQuery(TextBoxSearch.Text.ToLower());
            } else
            {
                TabControl.SelectedIndex = 0;
                TextBoxSearch.Focus();
            }
        }
    }
}
