using Penguins_Student_Management.JsonDatabase.Entity.Document;

namespace Penguins_Student_Management.Controllers.ClassController
{
    partial class ClassController
    {
        public void UpdateClass(Class @class)
        {
            Global.Database.Collections.Classes[@class.ID] = @class;
            Global.Database.ExportToJson();
        }
    }
}
