using System.Collections.Generic;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public void RemoveUsers(List<string> UserIDs, string CourseID) {
            UserIDs.ForEach(id => {
                Global.Database.Collections.Users[id].Courses.Remove(CourseID);
                Global.Database.Collections.Courses[CourseID].Users.Remove(id);
            });
            Global.Database.ExportToJson();
        }

    }
}
