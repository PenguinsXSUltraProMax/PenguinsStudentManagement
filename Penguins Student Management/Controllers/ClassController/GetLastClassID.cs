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
        public int GetLastClassID()
        {
            return Global.Database.LastClassID;
        }
    }
}
