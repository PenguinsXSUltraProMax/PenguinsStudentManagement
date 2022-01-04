using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;
using System.Linq;

namespace Penguins_Student_Management.Controllers.SearchController
{
    partial class SearchController {

        public List<Class> SearchClasses(string SearchQuery)
        {
            List<Class> classes = new List<Class>();

            Global.Database.Collections.Classes.Values.ToList().ForEach(@class => {

                if(@class.Name.ToLower().Contains(SearchQuery) || @class.Faculty.ToLower().Contains(SearchQuery))
                {
                    classes.Add(@class);
                }
            
            });

            return classes;
        }
    
    }
}
