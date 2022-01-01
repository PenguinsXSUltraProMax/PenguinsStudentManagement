using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class LoginDetailView : Form, IObserver
    {
        TheRiver River;
        User user;
        string id;

        public LoginDetailView(string value)
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
            classLabel.Text = user.Class;
            typeLabel.Text = user.Type.ToString();
            passwordLabel.Text = user.Password;
        }

    }
}
