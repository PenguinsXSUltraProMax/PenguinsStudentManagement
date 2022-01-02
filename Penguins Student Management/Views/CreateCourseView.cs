using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class CreateCourseView : Form, IObserver
    {

        TheRiver River;

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
            CategoryComboBox.DataSource = Hook.of<CourseController>(River).GetAllCourseCategory();
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "ID";
            CategoryComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string ID = Global.GenerateID();
            string Name = CourseNameTextBox.Text;
            string Category = CategoryComboBox.SelectedValue.ToString();
            string Owner = Hook.of<AuthController>(River).GetCurrentUser.ID;

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

            Hook.of<CourseController>(River).CreateCourse(course);
            MessageBox.Show("Tạo khóa học thành công!");

            River.Refesh();

        }

    }
}
