using System;

namespace Penguins_Student_Management.Controllers.UserController
{
    partial class UserController
    {
        public void DeleteUserByID(string id)
        {
            Global.Database.Collections.Users.Remove(id);
            Global.Database.ExportToJson();
        }

    }
}
