using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;

namespace Penguins_Student_Management.Controllers.SearchController
{
    partial class SearchController {
    
        public Dictionary<string, object> Search(string SearchQuery)
        {

            Dictionary<string, object> Result = new Dictionary<string, object> {
                {"Teacher", new List<User>()},
                {"Student", new List<User>()},
                {"Classes", new List<Class>()},
                {"Courses", new List<Course>()},
            };

            if(Filter.All)
            {
                Result["Teacher"] = SearchUsers(SearchQuery, User.AccountType.Teacher);
                Result["Student"] = SearchUsers(SearchQuery, User.AccountType.Student);
                Result["Classes"] = SearchClasses(SearchQuery);
                Result["Courses"] = SearchCourses(SearchQuery);
            } else
            {

                if(Filter.Teacher)
                {
                    Result["Teacher"] = SearchUsers(SearchQuery, User.AccountType.Teacher);
                }

                if (Filter.Student)
                {
                    Result["Student"] = SearchUsers(SearchQuery, User.AccountType.Student);
                }

                if (Filter.Class)
                {
                    Result["Classes"] = SearchClasses(SearchQuery);
                }

                if (Filter.Course)
                {
                    Result["Courses"] = SearchCourses(SearchQuery);
                }

            }

            return Result;
        }
    
    }
}
