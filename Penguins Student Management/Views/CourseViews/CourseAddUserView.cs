using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.CourseViews
{
    public partial class CourseAddUserView : Form, IObserver
    {
        TheRiver River;
        CourseController CourseController;
        Course Course;
        List<string> UserIDs;
        string CourseID;

        public CourseAddUserView(string value)
        {
            InitializeComponent();
            this.FormClosing += CourseAddUser_FormClosing;
            UserIDs = new List<string>();
            CourseID = value;
        }

        private void CourseAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            CourseController = Hook.of<CourseController>(River);
            Course = CourseController.GetCourseByID(CourseID);
            LoadData();
        }

        private void LoadData()
        {
            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            CourseController.GetUsersNotInTheCourse(Course).ForEach(user => {

                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = user.Type == User.AccountType.Student ? Properties.Resources.icons8_student_male_48 : user.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48,
                    Title = user.Name,
                    RightTitle = user.ID,
                    Size = new Size(375, 72)
                };

                item.Click += ListItemSelectedHandle;

                Panel.Controls.Add(item);

            });
        }

        private void ListItemSelectedHandle(object sender, EventArgs e)
        {
            ListItem item = (ListItem)sender;
            item.Selected = !item.Selected;

            if (item.Selected)
            {
                UserIDs.Add(item.ID);
            }
            else
            {
                UserIDs.Remove(item.ID);
            }
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            CourseController.AddUsers(UserIDs, Course);
            MessageBox.Show("Thêm thành công!");
            UserIDs.Clear();
            River.Notify();
        }

    }
}
