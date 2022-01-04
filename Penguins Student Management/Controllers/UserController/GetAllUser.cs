using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;
using System.Linq;

namespace Penguins_Student_Management.Controllers.UserController
{
    partial class UserController
    {
        public List<User> GetAllUser()
        {
            return Global.Database.Collections.Users.Values.ToList();
        }

    }
}
