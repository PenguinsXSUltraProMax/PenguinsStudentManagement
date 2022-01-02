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

        public void RemoveUsers(List<string> userIDs, string courseID) {
            userIDs.ForEach(id => {
                Global.Database.Collections.Users[id].Courses.Remove(courseID);
                Global.Database.Collections.Courses[courseID].Users.Remove(id);
            });
            Global.Database.ExportToJson();
        }

    }
}
