using System.Windows.Forms;

namespace Penguins_Student_Management.Controllers.AuthController
{
    partial class AuthController
    {
        public void ChangePassword(string OLD_PASSWORD, string NEW_PASSWORD, string RETYPE_PASSWORD)
        {
            if(string.IsNullOrEmpty(OLD_PASSWORD) || string.IsNullOrEmpty(NEW_PASSWORD) || string.IsNullOrEmpty(RETYPE_PASSWORD) || string.IsNullOrWhiteSpace(OLD_PASSWORD) || string.IsNullOrWhiteSpace(NEW_PASSWORD) || string.IsNullOrWhiteSpace(RETYPE_PASSWORD))
            {
                MessageBox.Show("Điền hết các ô trước khi xác nhận!");
            }

            if(GetCurrentUser.Password != OLD_PASSWORD)
            {
                MessageBox.Show("Mật khẩu cũ không đùng!");
                return;
            }

            if(NEW_PASSWORD != RETYPE_PASSWORD)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp!");
                return;
            }

            if(GetCurrentUser.Password == NEW_PASSWORD)
            {
                MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ!");
                return;
            }

            GetCurrentUser.Password = NEW_PASSWORD;
            Global.Database.Collections.Users[GetCurrentUser.ID] = GetCurrentUser;
            Global.Database.ExportToJson();

            MessageBox.Show("Đổi mật khẩu thành công!");

        }
    }
}
