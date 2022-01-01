using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.CustomUserControls;
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

namespace Penguins_Student_Management.Views.MainTab
{
    public partial class CoursePage : Form, IObserver
    {
        TheRiver River;
        public CoursePage()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }

        public void SetState(TheRiver value)
        {
            River = value;
            InitCourseState();
        }

        private void InitCourseState()
        {
            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            Hook.of<CourseController>(River).GetAllCourse().ForEach(course =>
            {

                ListItem item = new ListItem
                {
                    ID = course.ID,
                    PrefixIcon = Properties.Resources.icons8_read_48,
                    Title = course.Name,
                    Description = "#" + course.Category,
                    RightTitle = course.Owner,
                    Size = new Size(855, 72)
                };

                //item.Click += ListItemClickHandle;

                Panel.Controls.Add(item);

            });
        }
    }
}
