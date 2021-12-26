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
    public partial class UserListItem : UserControl
    {
        #region Properties
        private string id;
        private string name;
        private string classes;
        private string imageUrl;

        public string Id { get => id; set { id = value; idLabel.Text = value; } }
        public string Username { get => name; set { name = value; nameLabel.Text = value; } }
        public string Classes { get => classes; set { classes = value; classLabel.Text = value; } }

        public string Image { get => imageUrl; set { imageUrl = value; image.Load(value); } }

        #endregion

        public UserListItem()
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
