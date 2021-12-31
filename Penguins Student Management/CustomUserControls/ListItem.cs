using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguins_Student_Management.CustomUserControls
{
    public partial class ListItem : UserControl
    {

        #region Properties

        public string ID { get; set; }
        public Image PrefixIcon { get => prefixIcon.Image; set => prefixIcon.Image = value; }
        public int IconRadius { get => prefixIcon.Radius; set => prefixIcon.Radius = value; }
        public string Title { get => title.Text; set => title.Text = value; }

        #endregion

        public ListItem()
        {
            InitializeComponent();
            WireAllControls(this.Controls);
        }

        private void WireAllControls(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.Click += Control_Click;
                if (control.HasChildren)
                {
                    WireAllControls(control.Controls);
                }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

    }
}
