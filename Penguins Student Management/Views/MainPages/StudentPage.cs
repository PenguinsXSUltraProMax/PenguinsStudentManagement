using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using Penguins_Student_Management.Views.UserViews;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.MainPages
{
    public partial class StudentPage : Form, IObserver
    {
        TheRiver River;
        public StudentPage()
        {
            InitializeComponent();
            this.FormClosing += StudentPage_FormClosing;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }

        private void StudentPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            InitStudentState();
        }

        private void InitStudentState()
        {

            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            Hook.of<UserController>(River).GetAllStudent().ForEach(user => {

                ListItem item = new ListItem
                {
                    ID = user.ID,
                    PrefixIcon = Properties.Resources.icons8_student_male_48,
                    Title = user.Name,
                    Description = user.Class,
                    RightTitle = user.ID,
                    Size = new Size(855, 72)
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
            CreateUserView view = new CreateUserView(User.AccountType.Student);
            River.CreateObservableWithoutNotify(view);
            view.ShowDialog();
        }

    }
}
