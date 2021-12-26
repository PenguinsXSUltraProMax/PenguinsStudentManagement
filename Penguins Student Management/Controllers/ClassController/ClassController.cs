using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguins_Student_Management.Controllers.ClassController
{
    partial class ClassController : IRiverSubject
    {

        public List<String> GetAllClasses()
        {
            return Global.Database.Collections.Classes;
        }

        public bool IsClassExists(string name)
        {
            return Global.Database.Collections.Classes.Contains(name);
        }

    }
}
