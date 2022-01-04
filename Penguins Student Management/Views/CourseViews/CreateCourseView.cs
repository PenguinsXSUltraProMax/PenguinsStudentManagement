using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.CourseViews
{
    public partial class CreateCourseView : Form, IObserver
    {

        TheRiver River;
        AuthController Auth;
        CourseController CourseController;

        public CreateCourseView()
        {
            InitializeComponent();
            this.FormClosing += CreateCourseView_FormClosing;
        }

        private void CreateCourseView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }
  
        public void SetState(TheRiver value)
        {
            River = value;
            Auth = Hook.of<AuthController>(River);
            CourseController = Hook.of<CourseController>(River);

            ComboBoxCategory.DataSource = CourseController.GetAllCourseCategory();
            ComboBoxCategory.DisplayMember = "Name";
            ComboBoxCategory.ValueMember = "ID";
            ComboBoxCategory.SelectedIndex = 0;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string ID = Global.GenerateID();
            string Name = TextBoxCourseName.Text;
            string Category = ComboBoxCategory.SelectedValue.ToString();
            string Owner = Auth.GetCurrentUser.ID;

            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Category))
            {
                MessageBox.Show("Không được để trống!");
                return;
            }

            Course course = new Course()
            {
                ID = ID,
                Name = Name,
                Category = Category,
                Owner = Owner,
                Users = new List<string>(),
                Sections = new List<Section>()
            };

            CourseController.CreateCourse(course);
            MessageBox.Show("Tạo khóa học thành công!");

            River.Notify();

        }

    }
}
