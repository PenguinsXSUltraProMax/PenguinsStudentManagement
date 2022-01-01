using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class CreateClassView : Form, IObserver
    {

        TheRiver River;

        public CreateClassView()
        {
            InitializeComponent();
            this.FormClosing += EditUserView_FormClosing;
        }

        private void EditUserView_Load(object sender, EventArgs e)
        {
        }
        private void EditUserView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }
        public void SetState(TheRiver value)
        {
            River = value;
            IDTextBox.Text = (Hook.of<ClassController>(River).GetLastClassID() + 1).ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string Name = ClassNameTextBox.Text;
            string Faculty = FacultyTextBox.Text;

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Faculty))
            {
                MessageBox.Show("Điền hết tất cả thông tin để tiếp tục!");
                return;
            }

            Class @class = new Class();

            @class.ID = IDTextBox.Text;
            @class.Name = Name;
            @class.Faculty = Faculty;
            @class.Users = new List<string>();

            Hook.of<ClassController>(River).CreateClass(@class);

            MessageBox.Show("Tạo lớp thành công!");

            River.Refesh();

        }
    }
}
