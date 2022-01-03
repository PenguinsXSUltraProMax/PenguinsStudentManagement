using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguins_Student_Management.Controllers.SearchController
{
    partial class SearchController {

        public List<User> SearchUsers(string SearchQuery, User.AccountType Type)
        {
            List<User> users = new List<User>();

            Global.Database.Collections.Users.Values.ToList().ForEach(user => {

                if (user.Type == Type && (user.ID.Contains(SearchQuery) || user.Name.Contains(SearchQuery) || user.Gender.Contains(SearchQuery) || user.Hometown.Contains(SearchQuery) || user.Nationality.Contains(SearchQuery)))
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
