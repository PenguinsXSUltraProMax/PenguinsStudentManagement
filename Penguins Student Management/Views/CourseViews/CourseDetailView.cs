using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using Penguins_Student_Management.Views.UserViews;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.CourseViews
{
    public partial class CourseDetailView : Form, IObserver
    {

        TheRiver River;
        AuthController Auth;
        CourseController CourseController;
        Course course;
        List<User> users;
        string CourseID;
        bool IsAdminOrOwner;

        public CourseDetailView(string value)
        {
            InitializeComponent();
            this.FormClosing += CourseDetailView_FormClosing;
            CourseID = value;
        }

        private void CourseDetailView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            Auth = Hook.of<AuthController>(River);
            CourseController = Hook.of<CourseController>(River);

            course = CourseController.GetCourseByID(CourseID);
            IsAdminOrOwner = Auth.GetCurrentUser.Type == User.AccountType.Admin || Auth.GetCurrentUser.ID == course.Owner;
            ButtonEdit.Visible = IsAdminOrOwner;
            ButtonDelete.Visible = IsAdminOrOwner;

            InitState();
        }

        private void InitState()
        {
            LabelCourseName.Text = course.Name;
            LabelCategory.Text = course.Category;

            Global.DisposeControls(SectionPanel.Controls);
            SectionPanel.Controls.Clear();

            course.Sections.ForEach(section => {

                ListItem item = new ListItem
                {
                
                    ID = section.ID,
                    PrefixIcon = Properties.Resources.icons8_documents_48,
                    Title = section.Name,
                    Size = new System.Drawing.Size(560, 72)
                };

                item.Click += SectionListItemClickHandle;

                SectionPanel.Controls.Add(item);
            
            });

            Global.DisposeControls(UserPanel.Controls);
            UserPanel.Controls.Clear();

            users = CourseController.GetAllUserOfCourse(course.Users);

            users.ForEach(user =>
            {

                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = user.Type == User.AccountType.Student ? Properties.Resources.icons8_student_male_48 : user.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48,
                    Title = user.Name,
                    Description = user.Type.ToString(),
                    RightTitle = user.ID,
                    Size = new System.Drawing.Size(375, 72)
                };

                if(IsAdminOrOwner) item.Click += UserListItemClickHandle;

                UserPanel.Controls.Add(item);

            });
        }

        private void SectionListItemClickHandle(object sender, EventArgs e)
        {
            string SectionID = ((ListItem)sender).ID;

            SectionDetailView view = new SectionDetailView(CourseID, SectionID);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

        private void UserListItemClickHandle(object sender, EventArgs e)
        {
            string UserID = ((ListItem)sender).ID;

            UserDetailView view = new UserDetailView(UserID);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditCourseView view = new EditCourseView(CourseID);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khóa học này không?", "", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                CourseController.DeleteCourse(course);

                this.Close();
                River.Notify();
            }
        }

    }
}
