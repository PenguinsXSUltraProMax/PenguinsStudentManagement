using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Controllers.AuthController
{
    partial class AuthController
    {
        public AuthState SignInWithIDAndPassword(string ID, string PASSWORD)
        {
            if (String.IsNullOrEmpty(ID) || String.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("Tài khoản không được để trống!");
                return AuthState.NONE;
            }

            if (String.IsNullOrEmpty(PASSWORD) || String.IsNullOrWhiteSpace(PASSWORD))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return AuthState.NONE;
            }

            ID = ID.ToUpper();

            Global.Database.Collections.Users.TryGetValue(ID, out user);

            if (GetCurrentUser == null)
            {
                MessageBox.Show("StudentID không tồn tại!");
                return AuthState.NONE;
            }

            if(GetCurrentUser.Password != PASSWORD)
            {
                MessageBox.Show("Mật khẩu không đúng!");
                return AuthState.NONE;
            }

            State = AuthState.AUTHENTICATED;

            return AuthState.AUTHENTICATED;
        }
    }
}
