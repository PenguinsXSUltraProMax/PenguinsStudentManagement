using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguins_Student_Management.Controllers.ClassController
{
    partial class ClassController
    {
        public void CreateClass(Class @class)
        {
            Global.Database.Collections.Classes.Add(@class.ID, @class);
            Global.Database.ExportToJson();
        }
    }
}
