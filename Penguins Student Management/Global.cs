using Penguins_Student_Management.JsonDatabase;
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
    }
}
