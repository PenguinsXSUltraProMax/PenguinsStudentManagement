﻿using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
        }

        private void ShowHideMenuItem()
        {
            sideMenuItemStudent.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
            sideMenuItemTeacher.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
            sideMenuItemClass.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
            sideMenuItemCourse.Visible = !(authController.GetCurrentUser.Type == User.AccountType.Student);
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
            
        }

    }
}