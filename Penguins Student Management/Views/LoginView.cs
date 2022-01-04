using System;
using System.Windows.Forms;
using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using Penguins_Student_Management.Views;

namespace Penguins_Student_Management
{
    public partial class LoginView : Form, IObserver
    {

        TheRiver River;

        public LoginView()
        {
            InitializeComponent();
            this.FormClosing += LoginView_FormClosing;
        }

        private void LoginView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string ID = TextBoxUsername.Text;
            string PASSWORD = TextBoxPassword.Text;

            AuthState state = Hook.of<AuthController>(River).SignInWithIDAndPassword(ID, PASSWORD);

            if(state == AuthState.AUTHENTICATED)
            {
                this.Hide();
                MainView mainView = new MainView();
                River.CreateObservableWithoutNotify(mainView);
                mainView.ShowDialog();
                this.Close();
            }
        }

    }
}
