using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public void CreateCourse(Course course)
        {
            Global.Database.Collections.Courses.Add(course.ID, course);

            Global.Database.ExportToJson();
        }

    }
}
