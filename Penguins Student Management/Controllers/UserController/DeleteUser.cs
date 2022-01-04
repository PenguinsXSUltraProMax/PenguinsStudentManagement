using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.Controllers.UserController
{
    partial class UserController
    {
        public void DeleteUser(User user)
        {
            Global.Database.Collections.Classes[Global.Database.Collections.Users[user.ID].Class].Users.Remove(user.ID);
            Global.Database.Collections.Users.Remove(user.ID);
            Global.Database.ExportToJson();
        }

    }
}
