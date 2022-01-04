using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using Penguins_Student_Management.Views.UserViews;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.ClassViews
{
    public partial class ClassDetailView : Form, IObserver
    {
        TheRiver River;
        ClassController ClassController;
        List<User> users;
        Class @class;
        string id;


        public ClassDetailView(string value)
        {
            InitializeComponent();
            this.FormClosing += UserDetailView_FormClosing;
            id = value;
        }

        private void UserDetailView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            ClassController = Hook.of<ClassController>(River);
            InitState();
        }

        private void InitState()
        {
            @class = ClassController.GetClassByID(id);
            LabelClassName.Text = @class.Name;
            LabelFaculty.Text = @class.Faculty;

            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            users = ClassController.GetAllUserOfClass(@class.Users);
            
            users.ForEach(user => {

                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = user.Type == User.AccountType.Student ? Properties.Resources.icons8_student_male_48 : user.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48,
                    Title = user.Name,
                    Description = user.Type.ToString(),
                    RightTitle = user.ID,
                    Size = new System.Drawing.Size(463, 72)
                };

                item.Click += ListItemClickHandle;

                Panel.Controls.Add(item);

            });
        }

        private void ListItemClickHandle(object sender, EventArgs e)
        {
            string UserID = ((ListItem)sender).ID;

            UserDetailView view = new UserDetailView(UserID);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditClassView view = new EditClassView(@class);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            if(users.Count == 0)
            {
                MessageBox.Show("Danh sách lớp trống! Không thể xuất file.");
                return;
            }

            ClassController.ExportUser(@class, users);

            MessageBox.Show("Xuất file thành công!");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lớp học này không?", "", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                if(ClassController.DeleteClass(@class))
                {
                    this.Close();
                    River.Notify();
                }
            }
        }

    }
}
