using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.CourseViews
{
    public partial class EditCourseView : Form, IObserver
    {
        TheRiver River;
        CourseController CourseController;
        Course Course;
        List<User> Users;
        List<string> SectionIDs;
        List<string> UserIDs;
        string CourseID;


        public EditCourseView(string value)
        {
            InitializeComponent();
            this.FormClosing += EditCourseView_FormClosing;
            CourseID = value;
            SectionIDs = new List<string>();
            UserIDs = new List<string>();
        }

        private void EditCourseView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            CourseController = Hook.of<CourseController>(River);
            Course = CourseController.GetCourseByID(CourseID);
            LoadDataToView();
        }

        private void LoadDataToView()
        {
            TextBoxCourseName.Text = Course.Name;
            ComboBoxCategory.DataSource = CourseController.GetAllCourseCategory();
            ComboBoxCategory.DisplayMember = "Name";
            ComboBoxCategory.ValueMember = "ID";
            ComboBoxCategory.SelectedIndex = ComboBoxCategory.FindString(Course.Category);

            Global.DisposeControls(SectionPanel.Controls);
            SectionPanel.Controls.Clear();

            Course.Sections.ForEach(section =>
            {

                ListItem item = new ListItem
                {

                    ID = section.ID,
                    PrefixIcon = Properties.Resources.icons8_documents_48,
                    Title = section.Name,
                    Size = new System.Drawing.Size(560, 72)
                };

                item.Click += SectionListItemSelectedHandle;

                SectionPanel.Controls.Add(item);

            });

            Global.DisposeControls(UserPanel.Controls);
            UserPanel.Controls.Clear();

            Users = CourseController.GetAllUserOfCourse(Course.Users);

            Users.ForEach(user =>
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
                SectionIDs.Add(item.ID);
            }
            else
            {
                SectionIDs.Remove(item.ID);
            }
        }

        private void UserListItemSelectedHandle(object sender, EventArgs e)
        {
            ListItem item = (ListItem)sender;
            item.Selected = !item.Selected;

            if(item.Selected)
            {
                UserIDs.Add(item.ID);
            } else
            {
                UserIDs.Remove(item.ID);
            }
        }

        private void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            if(UserIDs.Count == 0)
            {
                MessageBox.Show("Cần chọn ít nhất một người dùng để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                CourseController.RemoveUsers(UserIDs, Course.ID);
                UserIDs.Clear();
                MessageBox.Show("Xóa thành công!");

                River.Notify();
            }
        }

        private void ButtonDeleteSection_Click(object sender, EventArgs e)
        {
            if (SectionIDs.Count == 0)
            {
                MessageBox.Show("Cần chọn ít nhất một bài giảng dùng để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                CourseController.RemoveSections(SectionIDs, Course.ID);
                SectionIDs.Clear();
                MessageBox.Show("Xóa thành công!");

                River.Notify();
            }
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            string Name = TextBoxCourseName.Text;

            if(string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            Course.Name = Name;
            Course.Category = ComboBoxCategory.SelectedValue.ToString();

            CourseController.UpdateCourse(Course);

            MessageBox.Show("Cập nhật thành công!");
            River.Notify();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            CourseAddUserView view = new CourseAddUserView(CourseID);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }
        private void ButtonAddSection_Click(object sender, EventArgs e)
        {
            CreateSectionView view = new CreateSectionView(Course);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

    }
}
