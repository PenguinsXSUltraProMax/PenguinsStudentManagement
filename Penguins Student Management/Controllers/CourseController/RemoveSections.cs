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

        public void RemoveSections(List<string> sectionIDs, string courseID) {
            sectionIDs.ForEach(id => {
                Global.Database.Collections.Courses[courseID].Sections.Remove(Global.Database.Collections.Courses[courseID].Sections.Find(section => section.ID == id));
            });
            Global.Database.ExportToJson();
        }

    }
}
