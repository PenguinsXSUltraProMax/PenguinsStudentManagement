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

        public void DeleteCourse(Course course)
        {
            course.Users.ForEach(id =>
            {
                Global.Database.Collections.Users[id].Courses.Remove(course.ID);
            });

            Global.Database.Collections.Courses.Remove(course.ID);

            Global.Database.ExportToJson();
        }

    }
}
