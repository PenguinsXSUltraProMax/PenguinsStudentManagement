using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Linq;

namespace Penguins_Student_Management.Controllers.UserController
{
    partial class UserController
    {
        public void UpdateUser(User user)
        {
            Global.Database.Collections.Users[user.ID] = user;
            Global.Database.Collections.Classes.Values.ToList().Find(c => c.Users.Contains(user.ID)).Users.Remove(user.ID);
            Global.Database.Collections.Classes[user.Class].Users.Add(user.ID);
            Global.Database.ExportToJson();
        }

    }
}
