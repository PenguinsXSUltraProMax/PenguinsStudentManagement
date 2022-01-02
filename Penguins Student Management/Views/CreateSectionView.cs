using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class CreateSectionView : Form, IObserver
    {
        TheRiver River;
        CourseController courseController;
        Course course;

        public CreateSectionView(Course value)
        {
            InitializeComponent();
            course = value;
        }

        public void SetState(TheRiver value)
        {
            River = value;
            courseController = Hook.of<CourseController>(River);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string id = Global.GenerateID();
            string Name = SectionNameTextBox.Text;
            string Content = ContentTextBox.Text;

            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Content))
            {
                MessageBox.Show("Không được bỏ trống!");
                return;
            }

            courseController.CreateSection(
                new Section() {
                    ID = id,
                    Name = Name,
                    Content = Content
                },
                course
            );

            MessageBox.Show("Tạo thành công!");
            River.Refesh();
        }
    }
}
