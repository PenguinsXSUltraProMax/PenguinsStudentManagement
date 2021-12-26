using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement.Entity;

namespace Penguins_Student_Management.Controllers.AuthController
{

    public enum AuthState
    {
        AUTHENTICATED,
        NONE
    }

    public partial class AuthController : IRiverSubject
    {
        private User user;
        private AuthState state = AuthState.NONE;

        public AuthState State { get => state; set => state = value; }
        public User GetCurrentUser { get => user; set => user = value; }
    }
}
