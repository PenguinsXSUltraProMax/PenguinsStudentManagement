using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class EditCourseView : Form, IObserver
    {
        TheRiver River;
        CourseController courseController;
        Course course;
        List<User> users;

        List<string> userIDs = new List<string>();
        List<string> sectionIDs = new List<string>();

        public EditCourseView(Course value)
        {
            InitializeComponent();
            course = value;
            this.FormClosing += EditCourseView_FormClosing;
        }

        private void EditCourseView_Load(object sender, EventArgs e)
        {

        }
        private void EditCourseView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }
        public void SetState(TheRiver value)
        {
            River = value;
            courseController = Hook.of<CourseController>(River);
            LoadDataToView();
        }

        private void LoadDataToView()
        {
            CourseNameTextBox.Text = course.Name;
            CategoryComboBox.DataSource = courseController.GetAllCourseCategory();
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "ID";
            CategoryComboBox.SelectedText = course.Category;

            Global.DisposeControls(MainPanel.Controls);
            MainPanel.Controls.Clear();

            course.Sections.ForEach(section =>
            {

                ListItem item = new ListItem
                {

                    ID = section.ID,
                    PrefixIcon = Properties.Resources.icons8_documents_48,
                    Title = section.Name,
                    Size = new System.Drawing.Size(560, 72)
                };

                item.Click += SectionListItemSelectedHandle;

                MainPanel.Controls.Add(item);

            });

            Global.DisposeControls(UserPanel.Controls);
            UserPanel.Controls.Clear();

            users = Hook.of<CourseController>(River).GetAllUserOfCourse(course.Users);

            users.ForEach(user =>
            {

                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = user.Type == User.AccountType.Student ? Properties.Resources.icons8_student_male_48 : user.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48,
                    Title = user.Name,
                    Description = user.Type.ToString(),
                    RightTitle = user.ID,
                    Size = new System.Drawing.Size(375, 72)
                };

                item.Click += UserListItemSelectedHandle;

                UserPanel.Controls.Add(item);

            });
        }
        
        private void SectionListItemSelectedHandle(object sender, EventArgs e)
        {
            ListItem item = (ListItem)sender;
            item.Selected = !item.Selected;

            if (item.Selected)
            {
                sectionIDs.Add(item.ID);
            }
            else
            {
                sectionIDs.Remove(item.ID);
            }
        }
        private void UserListItemSelectedHandle(object sender, EventArgs e)
        {
            ListItem item = (ListItem)sender;
            item.Selected = !item.Selected;

            if(item.Selected)
            {
                userIDs.Add(item.ID);
            } else
            {
                userIDs.Remove(item.ID);
            }
        }
        private void DeleteUserGradientButton_Click(object sender, EventArgs e)
        {
            if(userIDs.Count == 0)
            {
                MessageBox.Show("Cần chọn ít nhất một người dùng để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                courseController.RemoveUsers(userIDs, course.ID);
                MessageBox.Show("Xóa thành công!");

                River.Refesh();
            }
        }

        private void editGradientButton_Click(object sender, EventArgs e)
        {
            //EditClassView view = new EditClassView(@class);
            //River.CreateObservable(view);
            //view.ShowDialog();
        }

        private void deleteGradientButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khóa học này không?", "", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                //if(Hook.of<ClassController>(River).DeleteClass(@class))
                //{
                //    this.Close();
                //    River.Refesh();
                //}
            }
        }

    }
}
