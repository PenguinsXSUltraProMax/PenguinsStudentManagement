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

        private void ChangePasswordView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            Auth = Hook.of<AuthController>(River);
        }


        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            string OLD_PASSWORD = TextBoxOldPassword.Text;
            string NEW_PASSWORD = TextBoxNewPassword.Text;
            string RETYPE_PASSWORD = TextBoxRetype.Text;

            Auth.ChangePassword(OLD_PASSWORD, NEW_PASSWORD, RETYPE_PASSWORD);
        }
    }
}
