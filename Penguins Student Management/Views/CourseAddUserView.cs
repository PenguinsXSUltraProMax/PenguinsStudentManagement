using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
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
    public partial class CourseAddUserView : Form, IObserver
    {
        TheRiver River;
        string id;
        Course course;
        List<string> userIDs = new List<string>();

        public CourseAddUserView(string value)
        {
            InitializeComponent();
            this.FormClosing += CourseAddUser_FormClosing;
            id = value;
        }
        private void CourseAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            course = Hook.of<CourseController>(River).GetCourseByID(id);
            LoadData();
        }

        private void LoadData()
        {
            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            Hook.of<CourseController>(River).GetUsersNotInTheCourse(course).ForEach(user => {

                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = user.Type == User.AccountType.Student ? Properties.Resources.icons8_student_male_48 : user.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48,
                    Title = user.Name,
                    RightTitle = user.ID,
                    Size = new Size(375, 72)
                };

                item.Click += ListItemSelectedHandle;

                Panel.Controls.Add(item);

            });
        }

        private void ListItemSelectedHandle(object sender, EventArgs e)
        {
            ListItem item = (ListItem)sender;
            item.Selected = !item.Selected;

            if (item.Selected)
            {
                userIDs.Add(item.ID);
            }
            else
            {
                userIDs.Remove(item.ID);
            }
        }

        private void DoneGradientButton_Click(object sender, EventArgs e)
        {
            Hook.of<CourseController>(River).AddUsers(userIDs, course);
            MessageBox.Show("Thêm thành công!");
            userIDs.Clear();
            River.Refesh();
        }

    }
}
