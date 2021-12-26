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
    public partial class CourseListItem : UserControl
    {

        #region Properties
        private string courseLabel;
        
        public string CourseLabel { get => courseLabel; set { courseLabel = value; label.Text = value; } }
        #endregion

        public CourseListItem()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
