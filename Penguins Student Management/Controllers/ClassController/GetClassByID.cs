using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.Controllers.ClassController
{
    partial class ClassController
    {

        public Class GetClassByID(string ID)
        {
            Class @class;
            Global.Database.Collections.Classes.TryGetValue(ID, out @class);
            return @class;
        }

    }
}
