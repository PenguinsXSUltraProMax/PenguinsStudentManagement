using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class UserDetailView : Form, IObserver
    {
        TheRiver River;
        User user;
        string id;

        public UserDetailView(string value)
        {
            InitializeComponent();
            id = value;
            this.FormClosing += UserDetailView_FormClosing;
        }

        private void UserDetailView_Load(object sender, EventArgs e)
        {

        }
        private void UserDetailView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            user = Hook.of<UserController>(River).GetUserById(id);
            ShowUserDetail();
        }

        private void ShowUserDetail()
        {
            idLabel.Text = user.ID;
            nameLabel.Text = user.Name;
            birthdayLabel.Text = user.Birthday;
            genderLabel.Text = user.Gender;
            ethnicLabel.Text = user.Ethnic;
            hometownLabel.Text = user.Hometown;
            nationalityLabel.Text = user.Nationality;
            classLabel.Text = user.Classes[0];
            typeLabel.Text = user.Type.ToString();
            passwordLabel.Text = user.Password;
        }

        private void editGradientButton_Click(object sender, EventArgs e)
        {
            EditUserView editUserView = new EditUserView(user);
            River.CreateObservable(editUserView);
            editUserView.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa người dùng này không?", "", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                Hook.of<UserController>(River).DeleteUserByID(id);
                this.Close();
                River.Refesh();
            }
        }
    }
}
