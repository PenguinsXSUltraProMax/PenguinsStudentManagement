using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.Controllers.UserController
{
    partial class UserController
    {
        public void CreateUser(User user)
        {
            Global.Database.Collections.Users.Add(user.ID, user);
            Global.Database.Collections.Classes[user.Class].Users.Add(user.ID);
            Global.Database.ExportToJson();
        }

    }
}
