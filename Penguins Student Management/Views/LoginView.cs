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
        }

        public void SetState(TheRiver value)
        {
            River = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string ID = userTextBox.Text;
            string PASSWORD = passwordTextBox.Text;

            AuthState state = Hook.of<AuthController>(River).SignInWithIDAndPassword(ID, PASSWORD);

            if(state == AuthState.AUTHENTICATED)
            {
                River.DisposeObservable(this);
                this.Hide();
                MainView mainView = new MainView();
                River.CreateObservable(mainView);
                mainView.ShowDialog();
                this.Close();
            }
        }

    }
}
