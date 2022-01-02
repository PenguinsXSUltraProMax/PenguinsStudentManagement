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

        public Section GetSectionByID(string course_id,string id)
        {
            return Global.Database.Collections.Courses[course_id].Sections.Find(s => s.ID == id);
        }

    }
}
