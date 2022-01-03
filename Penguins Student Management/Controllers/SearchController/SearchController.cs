using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguins_Student_Management.Controllers.SearchController
{
    partial class SearchController : IRiverSubject {

        public List<User> Users;
        public List<Class> Classes;
        public List<Course> Courses;

        public SearchController()
        {
            Users = new List<User>();
            Classes = new List<Class>();
            Courses = new List<Course>();
        }
    
    }
}
