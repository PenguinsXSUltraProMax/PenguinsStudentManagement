using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;

namespace Penguins_Student_Management.Controllers.ClassController
{
    partial class ClassController
    {

        public List<User> GetAllUserOfClass(List<string> UserIDs)
        {
            List<User> users = new List<User>();

            UserIDs.ForEach(id => {
                User user;
                Global.Database.Collections.Users.TryGetValue(id, out user);

                if(user != null)
                {
                    users.Add(user);
                }
            });

            return users;
        }

    }
}
