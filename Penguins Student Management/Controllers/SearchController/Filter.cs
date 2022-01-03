using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguins_Student_Management.Controllers.SearchController
{
    public class Filter
    {
        [DefaultValue(true)]
        static public bool All { get; set; }
        [DefaultValue(true)]
        static public bool Teacher { get; set; }
        [DefaultValue(true)]
        static public bool Student { get; set; }
        [DefaultValue(true)]
        static public bool Class { get; set; }
        [DefaultValue(true)]
        static public bool Course { get; set; }
    }
}
