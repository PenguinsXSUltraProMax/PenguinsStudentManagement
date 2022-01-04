using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.UserViews
{
    public partial class CreateUserView : Form, IObserver
    {

        TheRiver River;
        UserController UserController;
        ClassController ClassController;
        User.AccountType Type;

        public CreateUserView(User.AccountType value)
        {
            InitializeComponent();
            this.FormClosing += CreateUserView_FormClosing;
            Type = value;
        }

        private void CreateUserView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            UserController = Hook.of<UserController>(River);
            ClassController = Hook.of<ClassController>(River);
            InitData();
        }

        private void InitData()
        {
            ComboBoxGender.SelectedIndex = 0;
            ComboBoxClass.DataSource = ClassController.GetAllClasses();
            ComboBoxClass.DisplayMember = "Name";
            ComboBoxClass.SelectedIndex = 0;
            ComboBoxType.DataSource = Enum.GetValues(typeof(User.AccountType));
            TextBoxID.Text = "000001";
            
            if(Type == User.AccountType.Student)
            {
                this.Text = "Thêm sinh viên";
                gunaLabel1.Text = this.Text;

                List<String> prefixs = new List<string>();

                for (int i = 100; i < 200; i++) {
                    prefixs.Add(i.ToString());
                }

                ComboBoxPrefix.DataSource = prefixs;
                ComboBoxPrefix.SelectedIndex = 0;

                ComboBoxType.SelectedItem = User.AccountType.Student;
                ComboBoxType.Enabled = false;

            } else
            {
                this.Text = "Thêm giáo viên";
                gunaLabel1.Text = this.Text;

                ComboBoxPrefix.DataSource = new string[] {"GV"};
                ComboBoxPrefix.SelectedIndex = 0;
                ComboBoxPrefix.Enabled = false;

                

                ComboBoxType.SelectedItem = User.AccountType.Teacher;
                ComboBoxType.Enabled = false;
            }

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {

            if(TextBoxID.Text.Length != 6)
            {
                MessageBox.Show("ID phải dài 6 chữ số!");
                return;
            }

            string ID = ComboBoxPrefix.SelectedItem.ToString() + TextBoxID.Text;
            string Name = TextBoxName.Text;
            string Birthday = DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Year;
            string Gender = ComboBoxGender.SelectedItem.ToString();
            string Ethnic = TextBoxEthnic.Text;
            string Hometown = hometownTextBox.Text;
            string Nationality = TextBoxNationality.Text;
            string Class = ((Class)ComboBoxClass.SelectedItem).ID;
            User.AccountType Type = (User.AccountType)ComboBoxType.SelectedItem;
            string Password = TextBoxPassword.Text;

            if(UserController.IsIDExists(ID))
            {
                MessageBox.Show("ID này đã được dùng. Vui lòng sử dụng ID khác!");
                return;
            }

            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Ethnic) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(Hometown) || string.IsNullOrEmpty(Nationality) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Điền hết tất cả thông tin để tiếp tục!");
                return;
            }

            User user = new User();

            user.ID = ID;
            user.Name = Name;
            user.Birthday = Birthday;
            user.Gender = Gender;
            user.Ethnic = Ethnic;
            user.Hometown = Hometown;
            user.Nationality = Nationality;
            user.Class = Class;
            user.Type = Type;
            user.Password = Password;
            user.Courses = new List<string>();

            UserController.CreateUser(user);
            River.Notify();

            MessageBox.Show("Tạo thành công!");

        }
    }
}
