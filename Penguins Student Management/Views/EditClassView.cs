using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class EditClassView : Form, IObserver
    {

        TheRiver River;
        Class @class;

        public EditClassView(Class value)
        {
            InitializeComponent();
            this.FormClosing += EditUserView_FormClosing;
            @class = value;
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
            LoadClassData();
        }

        private void LoadClassData()
        {
            IDTextBox.Text = @class.ID;
            ClassNameTextBox.Text = @class.Name;
            FacultyTextBox.Text = @class.Faculty;
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

            @class.Name = Name;
            @class.Faculty = Faculty;

            Hook.of<ClassController>(River).UpdateClass(@class);

            MessageBox.Show("Sửa thông tin thành công!");

            River.Refesh();

        }
    }
}
