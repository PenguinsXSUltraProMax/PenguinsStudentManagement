using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System;

namespace Penguins_Student_Management.Controllers.UserController
{
    partial class UserController
    {
        public bool IsIDExists(string id)
        {
            return Global.Database.Collections.Users.ContainsKey(id);
        }

    }
}
