using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public void UpdateSection(string CourseID, Section section) {
            Section sn = Global.Database.Collections.Courses[CourseID].Sections.Find(s => s.ID == section.ID);
            sn = section;
            Global.Database.ExportToJson();
        }

    }
}
