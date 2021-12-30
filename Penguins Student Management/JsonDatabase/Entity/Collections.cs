using System.Collections.Generic;
using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.JsonDatabase.Entity
{
    class Collections
    {
        public Dictionary<string, User> Users { get; set; }
        public Dictionary<string, Class> Classes { get; set; }
        public Dictionary<string, Course> Courses { get; set; }
        public Dictionary<string, CourseCategory> CourseCategory { get; set; }
    }
}
