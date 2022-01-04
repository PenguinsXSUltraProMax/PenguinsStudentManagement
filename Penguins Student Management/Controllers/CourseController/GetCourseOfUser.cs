using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public List<Course> GetCourseOfUser(User user) {
            List<Course> courses = new List<Course>();

            user.Courses.ForEach(courseKey =>
            {
                Course course;
                Global.Database.Collections.Courses.TryGetValue(courseKey, out course);

                if (course != null) courses.Add(course);
            });

            return courses;
        }

    }
}
