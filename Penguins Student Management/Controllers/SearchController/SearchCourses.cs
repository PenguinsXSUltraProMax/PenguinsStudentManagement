using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;
using System.Linq;

namespace Penguins_Student_Management.Controllers.SearchController
{
    partial class SearchController {

        public List<Course> SearchCourses(string SearchQuery)
        {
            List<Course> courses = new List<Course>();

            Global.Database.Collections.Courses.Values.ToList().ForEach(course => {

                if(course.Name.ToLower().Contains(SearchQuery) || course.Owner.ToLower().Contains(SearchQuery))
                {
                    courses.Add(course);
                }
            
            });

            return courses;
        }
    
    }
}
