using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;

namespace Penguins_Student_Management.Controllers.CourseController
{
    partial class CourseController
    {

        public void AddUsers(List<string> UserIDs, Course course)
        {
            UserIDs.ForEach(id => {
                if(!Global.Database.Collections.Courses[course.ID].Users.Contains(id)) Global.Database.Collections.Courses[course.ID].Users.Add(id);
            });

            Global.Database.ExportToJson();
        }

    }
}
