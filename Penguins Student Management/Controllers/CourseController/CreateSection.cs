using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public void CreateSection(Section section, Course course)
        {
            Global.Database.Collections.Courses[course.ID].Sections.Add(section);
            Global.Database.ExportToJson();
        }

    }
}
