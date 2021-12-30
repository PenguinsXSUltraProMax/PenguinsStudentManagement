using System.Collections.Generic;

namespace Penguins_Student_Management.JsonDatabase.Entity.Document
{
    public class User : IDocument
    {
        public string Birthday { get; set; }
        public string Ethnic { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Password { get; set; }
        public string Class { get; set; }
        public List<string> Courses { get; set; }
        public AccountType Type { get; set; }

        public enum AccountType
        {
            Student,
            Teacher,
            Admin
        }

    }
}
