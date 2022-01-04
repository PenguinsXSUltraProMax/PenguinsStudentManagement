using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public Course GetCourseByID(string id) {

            Course course;
            Global.Database.Collections.Courses.TryGetValue(id, out course);

            Course clone = new Course()
            {
                ID = course.ID,
                Name = course.Name,
                Category = Global.Database.Collections.CourseCategory[course.Category].Name,
                Owner = course.Owner,
                Users = course.Users,
                Sections = course.Sections
            };


            return clone;
        }

    }
}
