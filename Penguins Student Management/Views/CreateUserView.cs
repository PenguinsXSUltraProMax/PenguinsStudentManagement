using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class CreateUserView : Form, IObserver
    {

        TheRiver River;
        User user;

        public CreateUserView(User value)
        {
            InitializeComponent();
            this.FormClosing += EditUserView_FormClosing;
            user = value;
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
            LoadUserData();
        }

        private void LoadUserData()
        {
            nameTextBox.Text = user.Name;
            birthdayDateTimePicker.Value = DateTime.Parse(user.Birthday);
            genderComboBox.SelectedIndex = user.Gender == "Nam" ? 0 : user.Gender == "Nữ" ? 1 : 2;
            ethnicTextBox.Text = user.Ethnic;
            hometownTextBox.Text = user.Hometown;
            nationalityTextBox.Text = user.Nationality;
            classesComboBox.DataSource = Hook.of<ClassController>(River).GetAllClasses();
            classesComboBox.SelectedItem = user.Classes[0];
            typeComboBox.DataSource = Enum.GetValues(typeof(User.AccountType));
            typeComboBox.SelectedItem = user.Type;
            passwordTextBox.Text = user.Password;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string birthday = birthdayDateTimePicker.Value.Day + "/" + birthdayDateTimePicker.Value.Month + "/" + birthdayDateTimePicker.Value.Year;
            string gender = genderComboBox.SelectedItem.ToString();
            string ethnic = ethnicTextBox.Text;
            string hometown = hometownTextBox.Text;
            string nationality = nationalityTextBox.Text;
            string classes = classesComboBox.SelectedItem.ToString();
            User.AccountType type = (User.AccountType)typeComboBox.SelectedItem;
            string password = passwordTextBox.Text;

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ethnic) || string.IsNullOrEmpty(hometown) || string.IsNullOrEmpty(nationality) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Điền hết tất cả thông tin để tiếp tục!");
                return;
            }

            user.Name = name;
            user.Birthday = birthday;
            user.Gender = gender;
            user.Ethnic = ethnic;
            user.Hometown = hometown;
            user.Nationality = nationality;
            user.Classes[0] = classes;
            user.Type = type;
            user.Password = password;

            Hook.of<UserController>(River).UpdateUserByID(user.ID, user);

            MessageBox.Show("Sửa thông tin thành công!");
            
            River.Refesh();

        }
    }
}
