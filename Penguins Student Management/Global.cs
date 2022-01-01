using Penguins_Student_Management.JsonDatabase;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Penguins_Student_Management
{
    static class Global
    {
        static public Database Database = new Database();

        static public void DisposeControls(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.Dispose();

                if (control.HasChildren) DisposeControls(control.Controls);
            }
        }

        static public string GenerateID()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(15)
                .ToList().ForEach(e => builder.Append(e));

            return builder.ToString();
        }
    }
}
