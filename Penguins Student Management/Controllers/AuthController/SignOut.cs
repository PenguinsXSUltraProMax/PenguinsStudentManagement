using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.Controllers.AuthController
{
    partial class AuthController
    {
        public void SignOut()
        {
            GetCurrentUser = null;
            State = AuthState.NONE;
        }
    }
}
