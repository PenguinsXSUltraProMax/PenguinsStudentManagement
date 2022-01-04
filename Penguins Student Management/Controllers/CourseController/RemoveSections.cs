using System.Collections.Generic;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public void RemoveSections(List<string> SectionIDs, string CourseID) {
            SectionIDs.ForEach(id => {
                Global.Database.Collections.Courses[CourseID].Sections.Remove(Global.Database.Collections.Courses[CourseID].Sections.Find(section => section.ID == id));
            });
            Global.Database.ExportToJson();
        }

    }
}
