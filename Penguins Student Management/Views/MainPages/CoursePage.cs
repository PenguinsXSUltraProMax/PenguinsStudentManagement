using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using Penguins_Student_Management.Views.ClassViews;
using Penguins_Student_Management.Views.CourseViews;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.MainPages
{
    public partial class CoursePage : Form, IObserver
    {
        TheRiver River;
        public CoursePage()
        {
            InitializeComponent();
            this.FormClosing += CoursePage_FormClosing;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }

        private void CoursePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            InitCourseState();
        }

        private void InitCourseState()
        {
            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            Hook.of<CourseController>(River).GetAllCourse().ForEach(course =>
            {

                ListItem item = new ListItem
                {
                    ID = course.ID,
                    PrefixIcon = Properties.Resources.icons8_read_48,
                    Title = course.Name,
                    Description = "#" + course.Category,
                    Size = new Size(855, 72)
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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            CreateCourseView view = new CreateCourseView();
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

    }
}
