using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.Controllers.SearchController;
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

namespace Penguins_Student_Management.Views.MainPages
{
    public partial class SearchPage : Form, IObserver
    {

        Dictionary<string, object> Result;
        TheRiver River;
        string SearchQuery;

        public SearchPage()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }

        public void SetState(TheRiver value)
        {
            River = value;
        }

        public void BindingSearchQuery(string SearchQuery)
        {
            this.SearchQuery = SearchQuery;

            Result = Hook.of<SearchController>(River).Search(SearchQuery);

            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            LoadData();
        }

        private void LoadData()
        {
            ((List<User>)Result["Teacher"]).ForEach(user =>
            {
                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = user.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48,
                    Title = user.Name,
                    Description = user.Type.ToString(),
                    RightTitle = user.ID,
                    Size = new System.Drawing.Size(855, 72)
                };

                Panel.Controls.Add(item);
            });

            ((List<User>)Result["Student"]).ForEach(user =>
            {
                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = user.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48,
                    Title = user.Name,
                    Description = user.Type.ToString(),
                    RightTitle = user.ID,
                    Size = new System.Drawing.Size(855, 72)
                };

                Panel.Controls.Add(item);
            });

            ((List<Class>)Result["Classes"]).ForEach(@class =>
            {
                ListItem item = new ListItem
                {
                    ID = @class.ID,
                    PrefixIcon = Properties.Resources.icons8_class_48,
                    Title = @class.Name,
                    Description = @class.Faculty,
                    RightTitle = @class.Users.Count + " 🐧",
                    Size = new Size(855, 72)
                };

                Panel.Controls.Add(item);
            });

            ((List<Course>)Result["Courses"]).ForEach(course =>
            {
                ListItem item = new ListItem
                {
                    ID = course.ID,
                    PrefixIcon = Properties.Resources.icons8_read_48,
                    Title = course.Name,
                    Description = "#" + course.Category,
                    Size = new Size(855, 72)
                };

                Panel.Controls.Add(item);
            });
        }

        private void AllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter.All = AllCheckBox.Checked;
            BindingSearchQuery(SearchQuery);
        }

        private void TeacherCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter.Teacher = TeacherCheckBox.Checked;
            BindingSearchQuery(SearchQuery);
        }

        private void StudentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter.Student = StudentCheckBox.Checked;
            BindingSearchQuery(SearchQuery);
        }

        private void ClassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter.Class = ClassCheckBox.Checked;
            BindingSearchQuery(SearchQuery);
        }

        private void CourseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter.Course = CourseCheckBox.Checked;
            BindingSearchQuery(SearchQuery);
        }

    }
}
