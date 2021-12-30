using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguins_Student_Management.JsonDatabase.Entity.Document
{
    public class Class : IDocument
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public List<string> Users { get; set; }
    }
}
