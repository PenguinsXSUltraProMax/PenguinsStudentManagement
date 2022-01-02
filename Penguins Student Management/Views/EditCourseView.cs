using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class EditCourseView : Form, IObserver
    {
        TheRiver River;
        Course course;

        List<User> users;

        public EditCourseView(Course value)
        {
            InitializeComponent();
            course = value;
            this.FormClosing += EditCourseView_FormClosing;
        }

        private void EditCourseView_Load(object sender, EventArgs e)
        {

        }
        private void EditCourseView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }
        public void SetState(TheRiver value)
        {
            River = value;
            LoadDataToView();
        }

        private void LoadDataToView()
        {
            CourseNameTextBox.Text = course.Name;
            CategoryComboBox.Text = course.Category;

            Global.DisposeControls(MainPanel.Controls);
            MainPanel.Controls.Clear();

            course.Sections.ForEach(section =>
            {

                ListItem item = new ListItem
                {

                    ID = section.ID,
                    PrefixIcon = Properties.Resources.icons8_documents_48,
                    Title = section.Name,
                    Size = new System.Drawing.Size(560, 72)
                };

                MainPanel.Controls.Add(item);

            });

            Global.DisposeControls(UserPanel.Controls);
            UserPanel.Controls.Clear();

            users = Hook.of<CourseController>(River).GetAllUserOfCourse(course.Users);

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

                UserPanel.Controls.Add(item);

            });
        }

        private void InitState()
        {
            //course = Hook.of<CourseController>(River).GetCourseByID(id);

            //FormLabel.Text = course.Name;
            //CategoryLabel.Text = course.Category;

            //Global.DisposeControls(MainPanel.Controls);
            //MainPanel.Controls.Clear();

            //course.Sections.ForEach(section =>
            //{

            //    ListItem item = new ListItem
            //    {

            //        ID = section.ID,
            //        PrefixIcon = Properties.Resources.icons8_documents_48,
            //        Title = section.Name,
            //        Size = new System.Drawing.Size(560, 72)
            //    };

            //    MainPanel.Controls.Add(item);

            //});

            //Global.DisposeControls(UserPanel.Controls);
            //UserPanel.Controls.Clear();

            //users = Hook.of<CourseController>(River).GetAllUserOfCourse(course.Users);

            //users.ForEach(user =>
            //{

            //    ListItem item = new ListItem
            //    {
            //        ID = user.ID,
            //        PrefixIcon = user.Type == User.AccountType.Student ? Properties.Resources.icons8_student_male_48 : user.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48,
            //        Title = user.Name,
            //        Description = user.Type.ToString(),
            //        RightTitle = user.ID,
            //        Size = new System.Drawing.Size(375, 72)
            //    };

            //    UserPanel.Controls.Add(item);

            //});
        }


        private void editGradientButton_Click(object sender, EventArgs e)
        {
            //EditClassView view = new EditClassView(@class);
            //River.CreateObservable(view);
            //view.ShowDialog();
        }

        private void deleteGradientButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khóa học này không?", "", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                //if(Hook.of<ClassController>(River).DeleteClass(@class))
                //{
                //    this.Close();
                //    River.Refesh();
                //}
            }
        }

    }
}
