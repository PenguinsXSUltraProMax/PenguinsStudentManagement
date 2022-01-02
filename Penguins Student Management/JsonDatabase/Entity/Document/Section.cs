using System.Collections.Generic;

namespace Penguins_Student_Management.JsonDatabase.Entity.Document
{
    public class Section : IDocument
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
