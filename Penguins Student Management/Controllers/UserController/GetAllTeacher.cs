using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguins_Student_Management.Controllers.UserController
{
    partial class UserController
    {
        public List<User> GetAllTeacher()
        {
            List<User> students = new List<User>();

            Global.Database.Collections.Users.Values.ToList().ForEach(user =>
            {
                if (user.Type == User.AccountType.Teacher || user.Type == User.AccountType.Admin) students.Add(user);
            });

            return students;
        }

    }
}
