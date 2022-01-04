using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class LoginDetailView : Form, IObserver
    {
        TheRiver River;
        User @User;
        string id;

        public LoginDetailView(string value)
        {
            InitializeComponent();
            this.FormClosing += UserDetailView_FormClosing;

            id = value;
        }
        private void UserDetailView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            @User = Hook.of<UserController>(River).GetUserById(id);
            ShowUserDetail();
        }

        private void ShowUserDetail()
        {
            LabelID.Text = @User.ID;
            LabelName.Text = @User.Name;
            LabelBirthday.Text = @User.Birthday;
            LabelGender.Text = @User.Gender;
            LabelEthnic.Text = @User.Ethnic;
            LabelHometown.Text = @User.Hometown;
            LabelNationality.Text = @User.Nationality;
            LabelClass.Text = @User.Class;
            LabelType.Text = @User.Type.ToString();
            LabelPassword.Text = @User.Password;
        }

    }
}
