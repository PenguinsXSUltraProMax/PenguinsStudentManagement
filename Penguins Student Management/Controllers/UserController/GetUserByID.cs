using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.Controllers.UserController
{
    partial class UserController
    {

        public User GetUserById(string id)
        {
            User user;
            Global.Database.Collections.Users.TryGetValue(id, out user);

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

            return clone;
        }

    }
}
