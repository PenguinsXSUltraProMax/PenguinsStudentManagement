using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.CourseViews
{
    public partial class CreateSectionView : Form, IObserver
    {
        TheRiver River;
        CourseController CourseController;
        Course Course;

        public CreateSectionView(Course value)
        {
            InitializeComponent();
            Course = value;
        }

        public void SetState(TheRiver value)
        {
            River = value;
            CourseController = Hook.of<CourseController>(River);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string id = Global.GenerateID();
            string Name = TextBoxSectionName.Text;
            string Content = TextBoxContent.Text;

            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Content))
            {
                MessageBox.Show("Không được bỏ trống!");
                return;
            }

            CourseController.CreateSection(
                new Section() {
                    ID = id,
                    Name = Name,
                    Content = Content
                },
                Course
            );

            MessageBox.Show("Tạo thành công!");
            River.Notify();
        }
    }
}
