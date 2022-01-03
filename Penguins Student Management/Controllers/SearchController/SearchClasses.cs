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

        public List<Class> SearchClasses(string SearchQuery)
        {
            List<Class> classes = new List<Class>();

            Global.Database.Collections.Classes.Values.ToList().ForEach(@class => {

                if(@class.Name.Contains(SearchQuery) || @class.Faculty.Contains(SearchQuery))
                {
                    classes.Add(@class);
                }
            
            });

            return classes;
        }
    
    }
}
