using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class CourseDetailView : Form, IObserver
    {
        TheRiver River;
        Course course;
        string id;

        List<User> users;

        public CourseDetailView(string value)
        {
            InitializeComponent();
            id = value;
            this.FormClosing += CourseDetailView_FormClosing;
        }

        private void CourseDetailView_Load(object sender, EventArgs e)
        {

        }
        private void CourseDetailView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }
        public void SetState(TheRiver value)
        {
            River = value;
            InitState();
        }

        private void InitState()
        {
            course = Hook.of<CourseController>(River).GetCourseByID(id);

            CourseNameLabel.Text = course.Name;
            CategoryLabel.Text = course.Category;

            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

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
                    Size = new System.Drawing.Size(463, 72)
                };

                Panel.Controls.Add(item);

            });
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
