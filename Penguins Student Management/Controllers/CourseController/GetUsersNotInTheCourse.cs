using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;
using System.Linq;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public List<User> GetUsersNotInTheCourse(Course course) {
            List<User> users = new List<User>();

            Global.Database.Collections.Users.Values.ToList().ForEach(user => {

                if (!course.Users.Contains(user.ID))
                {
                    User clone = new User()
                    {
                        ID = user.ID,
                        Name = user.Name,
                        Gender = user.Gender,
                        Birthday = user.Birthday,
                        Ethnic = user.Ethnic,
                        Hometown = user.Hometown,
                        Nationality = user.Nationality,
                        Class = Global.Database.Collections.Classes[user.Class].Name,
                        Password = user.Password,
                        Courses = user.Courses,
                        Type = user.Type
                    };

                    users.Add(clone);
                }
            });

            return users;
        }

    }
}
