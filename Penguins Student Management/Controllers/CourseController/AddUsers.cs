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

        public void AddUsers(List<string> userIDs, Course course)
        {
            userIDs.ForEach(id => {
                if(!Global.Database.Collections.Courses[course.ID].Users.Contains(id)) Global.Database.Collections.Courses[course.ID].Users.Add(id);
            });

            Global.Database.ExportToJson();
        }

    }
}
