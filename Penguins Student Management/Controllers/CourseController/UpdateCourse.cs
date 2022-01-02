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

        public void UpdateCourse(Course course) {
            Global.Database.Collections.Courses[course.ID].Name = course.Name;
            Global.Database.Collections.Courses[course.ID].Category = course.Category;
            Global.Database.ExportToJson();
        }

    }
}
