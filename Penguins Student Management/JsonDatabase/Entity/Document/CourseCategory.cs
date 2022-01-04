using System.Collections.Generic;

namespace Penguins_Student_Management.JsonDatabase.Entity.Document
{
    class CourseCategory : IDocument
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
