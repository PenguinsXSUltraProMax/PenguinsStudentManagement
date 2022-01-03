using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguins_Student_Management.Controllers.SearchController
{
    partial class SearchController {

        public List<Course> SearchCourses(string SearchQuery)
        {
            List<Course> courses = new List<Course>();

            Global.Database.Collections.Courses.Values.ToList().ForEach(course => {

                if(course.Name.Contains(SearchQuery) || course.Owner.Contains(SearchQuery))
                {
                    courses.Add(course);
                }
            
            });

            return courses;
        }
    
    }
}
