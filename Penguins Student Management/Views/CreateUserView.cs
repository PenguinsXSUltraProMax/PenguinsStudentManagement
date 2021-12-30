using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class CreateUserView : Form, IObserver
    {

        TheRiver River;
        User.AccountType type;

        public CreateUserView(User.AccountType value)
        {
            InitializeComponent();
            this.FormClosing += CreateUserView_FormClosing;
            type = value;
        }

        private void CreateUserView_Load(object sender, EventArgs e)
        {
        }
        private void CreateUserView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }
        public void SetState(TheRiver value)
        {
            River = value;
            InitData();
        }

        private void InitData()
        {
            genderComboBox.SelectedIndex = 0;
            classesComboBox.DataSource = Hook.of<ClassController>(River).GetAllClasses();
            typeComboBox.DataSource = Enum.GetValues(typeof(User.AccountType));
            idTextBox.Text = "000001";
            
            if(type == User.AccountType.Student)
            {
                this.Text = "Thêm sinh viên";
                gunaLabel1.Text = this.Text;

                List<String> prefixs = new List<string>();

                for (int i = 100; i < 200; i++) {
                    prefixs.Add(i.ToString());
                }

                prefixComboBox.DataSource = prefixs;
                prefixComboBox.SelectedIndex = 0;

                typeComboBox.SelectedItem = User.AccountType.Student;
                typeComboBox.Enabled = false;

            } else
            {
                this.Text = "Thêm giáo viên";
                gunaLabel1.Text = this.Text;

                prefixComboBox.DataSource = new string[] {"GV"};
                prefixComboBox.SelectedIndex = 0;
                prefixComboBox.Enabled = false;

                

                typeComboBox.SelectedItem = User.AccountType.Teacher;
                typeComboBox.Enabled = false;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if(idTextBox.Text.Length != 6)
            {
                MessageBox.Show("ID phải dài 6 chữ số!");
                return;
            }

            string id = prefixComboBox.SelectedItem.ToString() + idTextBox.Text;
            string name = nameTextBox.Text;
            string birthday = birthdayDateTimePicker.Value.Day + "/" + birthdayDateTimePicker.Value.Month + "/" + birthdayDateTimePicker.Value.Year;
            string gender = genderComboBox.SelectedItem.ToString();
            string ethnic = ethnicTextBox.Text;
            string hometown = hometownTextBox.Text;
            string nationality = nationalityTextBox.Text;
            string classes = classesComboBox.SelectedItem.ToString();
            User.AccountType type = (User.AccountType)typeComboBox.SelectedItem;
            string password = passwordTextBox.Text;

            if(Hook.of<UserController>(River).IsIDExists(id))
            {
                MessageBox.Show("ID này đã được dùng. Vui lòng sử dụng ID khác!");
                return;
            }

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ethnic) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(hometown) || string.IsNullOrEmpty(nationality) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Điền hết tất cả thông tin để tiếp tục!");
                return;
            }

            User user = new User();

            user.ID = id;
            user.Name = name;
            user.Birthday = birthday;
            user.Gender = gender;
            user.Ethnic = ethnic;
            user.Hometown = hometown;
            user.Nationality = nationality;
            user.Classes = new List<string>(){classes};
            user.Type = type;
            user.Password = password;
            user.ImgUrl = "https://api.minimalavatars.com/avatar/random/png";
            user.Courses = new List<string>();
            user.Messages = new List<string>();

            Hook.of<UserController>(River).CreateUser(user);
            River.Refesh();

            MessageBox.Show("Tạo thành công!");

        }
    }
}
