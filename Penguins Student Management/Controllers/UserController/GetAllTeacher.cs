﻿using Penguins_Student_Management.JsonDatabase.Entity.Document;
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
            List<User> teachers = new List<User>();

            Global.Database.Collections.Users.Values.ToList().ForEach(user =>
            {
                if (user.Type == User.AccountType.Teacher || user.Type == User.AccountType.Admin) {

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

                    teachers.Add(clone);
                };
            });

            return teachers;
        }

    }
}
