﻿using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Penguins_Student_Management.Views.MainTab;

namespace Penguins_Student_Management.Views
{
    public partial class MainView : Form, IObserver
    {

        TheRiver River;
        AuthController authController;

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

            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            ((DashboardPage)TabPages[0]).OwnerForm = this;
            River.CreateObservable((IObserver)TabPages[0]);
            dashboardTab.Controls.Add(TabPages[0]);

            River.CreateObservable((IObserver)TabPages[1]);
            studentTab.Controls.Add(TabPages[1]);

            River.CreateObservable((IObserver)TabPages[2]);
            teacherTab.Controls.Add(TabPages[2]);

            River.CreateObservable((IObserver)TabPages[3]);
            classTab.Controls.Add(TabPages[3]);

            River.CreateObservable((IObserver)TabPages[4]);
            courseTab.Controls.Add(TabPages[4]);

            River.CreateObservable((IObserver)TabPages[5]);
            searchTab.Controls.Add(TabPages[5]);
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            authController = Hook.of<AuthController>(River);

            ShowHideMenuItem();
        }

        private void ShowHideMenuItem()
        {
            sideMenuItemStudent.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
            sideMenuItemTeacher.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
            sideMenuItemClass.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
            sideMenuItemCourse.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
        }


        private void SideMenuItemClickHandle(object sender, EventArgs e) {
            tabControl.SelectedIndex = ((SideMenuItem)sender).Index;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SideMenuItemActiveHandle(tabControl.SelectedIndex);
        }

        private void SideMenuItemActiveHandle(int index)
        {
            List<SideMenuItem> sideMenuItems = new List<SideMenuItem>() {
                sideMenuItemDashboard, sideMenuItemStudent, sideMenuItemTeacher, sideMenuItemClass, sideMenuItemCourse
            };

            for(int i = 0; i < sideMenuItems.Count; i++)
            {
                sideMenuItems[i].IsActive = i == index;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if(searchTextBox.Text.Length != 0)
            {
                tabControl.SelectedIndex = 5;
                searchTextBox.Focus();
            } else
            {
                tabControl.SelectedIndex = 0;
            }
        }
    }
}
