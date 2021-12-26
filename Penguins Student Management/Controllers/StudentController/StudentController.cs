using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Penguins_Student_Management.Controllers.StudentController
{
    class StudentController : IRiverSubject
    {
        public List<User> GetAllStudent()
        {
            List<User> students = new List<User>();

            Global.Database.Collections.Users.Values.ToList().ForEach(user =>
            {
                if (user.Type == User.AccountType.Student) students.Add(user);
            });

            return students;
        }
    }
}
