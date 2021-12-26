using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class EditUserView : Form, IObserver
    {

        TheRiver River;

        public EditUserView()
        {
            InitializeComponent();
        }

        private void EditUserView_Load(object sender, EventArgs e)
        {

        }
        public void SetState(TheRiver value)
        {
            River = value;
        }
    }
}
