using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.UserViews
{
    public partial class UserDetailView : Form, IObserver
    {
        TheRiver River;
        UserController UserController;
        User @User;
        string id;

        public UserDetailView(string value)
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
            UserController = Hook.of<UserController>(River);
            @User = UserController.GetUserById(id);
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

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditUserView view = new EditUserView(@User);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa người dùng này không?", "", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                UserController.DeleteUser(@User);
                this.Close();
                River.Notify();
            }
        }
    }
}
