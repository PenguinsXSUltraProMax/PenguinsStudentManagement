using Newtonsoft.Json;
using System.IO;

namespace Penguins_Student_Management.JsonDatabase
{
    partial class Database
    {
        public void ExportToJson()
        {
            string serializeObject = JsonConvert.SerializeObject(Root, Formatting.Indented);
            File.WriteAllText("DatabaseOutput.JSON", serializeObject);
        }
    }
}
