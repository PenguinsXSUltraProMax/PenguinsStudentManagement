using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;
using System.Linq;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public List<CourseCategory> GetAllCourseCategory() {
            return Global.Database.Collections.CourseCategory.Values.ToList();
        }

    }
}
