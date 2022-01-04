using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using Penguins_Student_Management.Views.UserViews;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.MainPages
{
    public partial class TeacherPage : Form, IObserver
    {
        TheRiver River;
        public TeacherPage()
        {
            InitializeComponent();
            this.FormClosing += TeacherPage_FormClosing;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }

        private void TeacherPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            InitTeacherState();
        }

        private void InitTeacherState()
        {

            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            Hook.of<UserController>(River).GetAllTeacher().ForEach(user => {

                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = user.Type == User.AccountType.Teacher ? Properties.Resources.icons8_school_director_48 : Properties.Resources.icons8_user_shield_48,
                    Title = user.Name,
                    Description = user.Type.ToString(),
                    RightTitle = user.ID,
                    Size = new System.Drawing.Size(855, 72)
                };


                item.Click += ListItemClickHandle;
                
                Panel.Controls.Add(item);
            });
        }

        private void ListItemClickHandle(object sender, EventArgs e)
        {
            string id = ((ListItem)sender).ID;

            UserDetailView view = new UserDetailView(id);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            CreateUserView view = new CreateUserView(User.AccountType.Teacher);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

    }
}
