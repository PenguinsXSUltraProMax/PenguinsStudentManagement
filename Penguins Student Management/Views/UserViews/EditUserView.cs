using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.UserViews
{
    public partial class EditUserView : Form, IObserver
    {

        TheRiver River;
        User @User;

        public EditUserView(User value)
        {
            InitializeComponent();
            this.FormClosing += EditUserView_FormClosing;
            @User = value;
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
            TextBoxName.Text = @User.Name;
            DateTimePicker.Value = DateTime.ParseExact(@User.Birthday, "d/M/yyyy", null);
            ComboBoxGender.SelectedIndex = @User.Gender == "Nam" ? 0 : @User.Gender == "Nữ" ? 1 : 2;
            TextBoxEthnic.Text = @User.Ethnic;
            TextBoxHometown.Text = @User.Hometown;
            TextBoxNationality.Text = @User.Nationality;
            ComboBoxClass.DataSource = Hook.of<ClassController>(River).GetAllClasses();
            ComboBoxClass.DisplayMember = "Name";
            ComboBoxClass.ValueMember = "ID";
            ComboBoxClass.SelectedIndex = ComboBoxClass.FindString(@User.Class);
            ComboBoxType.DataSource = Enum.GetValues(typeof(User.AccountType));
            ComboBoxType.SelectedItem = @User.Type;
            TextBoxPassword.Text = @User.Password;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string Name = TextBoxName.Text;
            string Birthday = DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Year;
            string Gender = ComboBoxGender.SelectedItem.ToString();
            string Ethnic = TextBoxEthnic.Text;
            string Hometown = TextBoxHometown.Text;
            string Nationality = TextBoxNationality.Text;
            string Class = ComboBoxClass.SelectedValue.ToString();
            User.AccountType Type = (User.AccountType)ComboBoxType.SelectedItem;
            string Password = TextBoxPassword.Text;

            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Ethnic) || string.IsNullOrEmpty(Hometown) || string.IsNullOrEmpty(Nationality) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Điền hết tất cả thông tin để tiếp tục!");
                return;
            }

            @User.Name = Name;
            @User.Birthday = Birthday;
            @User.Gender = Gender;
            @User.Ethnic = Ethnic;
            @User.Hometown = Hometown;
            @User.Nationality = Nationality;
            @User.Class = Class;
            @User.Type = Type;
            @User.Password = Password;

            Hook.of<UserController>(River).UpdateUser(@User);

            MessageBox.Show("Sửa thông tin thành công!");
            
            River.Notify();

        }
    }
}
