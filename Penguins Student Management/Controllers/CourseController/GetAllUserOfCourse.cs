using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public List<User> GetAllUserOfCourse(List<string> UserIDs)
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
