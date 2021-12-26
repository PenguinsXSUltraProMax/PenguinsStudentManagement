using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class ChangePasswordView : Form, IObserver
    {

        TheRiver River;
        AuthController Auth;

        public ChangePasswordView()
        {
            InitializeComponent();
            this.FormClosing += ChangePasswordView_FormClosing;
        }

        public void SetState(TheRiver value)
        {
            River = value;
            Auth = Hook.of<AuthController>(River);
        }

        private void ChangePasswordView_Load(object sender, EventArgs e)
        {
        }

        private void ChangePasswordView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string OLD_PASSWORD = oldPasswordTextBox.Text;
            string NEW_PASSWORD = newPasswordTextBox.Text;
            string RETYPE_PASSWORD = reTypeTextBox.Text;

            Auth.ChangePassword(OLD_PASSWORD, NEW_PASSWORD, RETYPE_PASSWORD);
        }
    }
}
