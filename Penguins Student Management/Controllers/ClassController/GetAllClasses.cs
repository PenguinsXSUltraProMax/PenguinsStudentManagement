using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;
using System.Linq;

namespace Penguins_Student_Management.Controllers.ClassController
{
    partial class ClassController
    {
        public List<Class> GetAllClasses()
        {
            return Global.Database.Collections.Classes.Values.ToList();
        }
    }
}
