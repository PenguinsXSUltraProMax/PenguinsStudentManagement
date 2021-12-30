using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class EditUserView : Form, IObserver
    {

        TheRiver River;
        User user;

        public EditUserView(User value)
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
            classComboBox.DataSource = Hook.of<ClassController>(River).GetAllClasses();
            classComboBox.DisplayMember = "Name";
            classComboBox.ValueMember = "ID";
            classComboBox.SelectedValue = user.Class;
            typeComboBox.DataSource = Enum.GetValues(typeof(User.AccountType));
            typeComboBox.SelectedItem = user.Type;
            passwordTextBox.Text = user.Password;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string Name = nameTextBox.Text;
            string Birthday = birthdayDateTimePicker.Value.Day + "/" + birthdayDateTimePicker.Value.Month + "/" + birthdayDateTimePicker.Value.Year;
            string Gender = genderComboBox.SelectedItem.ToString();
            string Ethnic = ethnicTextBox.Text;
            string Hometown = hometownTextBox.Text;
            string Nationality = nationalityTextBox.Text;
            string Class = classComboBox.SelectedValue.ToString();
            User.AccountType Type = (User.AccountType)typeComboBox.SelectedItem;
            string Password = passwordTextBox.Text;

            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Ethnic) || string.IsNullOrEmpty(Hometown) || string.IsNullOrEmpty(Nationality) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Điền hết tất cả thông tin để tiếp tục!");
                return;
            }

            user.Name = Name;
            user.Birthday = Birthday;
            user.Gender = Gender;
            user.Ethnic = Ethnic;
            user.Hometown = Hometown;
            user.Nationality = Nationality;
            user.Class = Class;
            user.Type = Type;
            user.Password = Password;

            Hook.of<UserController>(River).UpdateUser(user);

            MessageBox.Show("Sửa thông tin thành công!");
            
            River.Refesh();

        }
    }
}
