using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public List<User> GetAllUserOfCourse(List<string> userIDs)
        {
            List<User> users = new List<User>();
            
            userIDs.ForEach(id => {
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
