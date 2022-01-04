using Newtonsoft.Json;
using Penguins_Student_Management.JsonDatabase.Entity;
using System.IO;

namespace Penguins_Student_Management.JsonDatabase
{
    partial class Database
    {
        public void Initialize(string PATH)
        {
            Root = JsonConvert.DeserializeObject<Root>(File.ReadAllText(PATH));
            Collections = Root.Collections;
            this.PATH = PATH;
        }
    }
}
