using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.Controllers.SearchController;
using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class SplashView : Form
    {

        TheRiver River = new TheRiver(subjects: new List<IRiverSubject>() {
            TheRiver.CreateSubject(new AuthController()),
            TheRiver.CreateSubject(new CourseController()),
            TheRiver.CreateSubject(new UserController()),
            TheRiver.CreateSubject(new ClassController()),
            TheRiver.CreateSubject(new SearchController())
        });

        public SplashView()
        {
            InitializeComponent();
            Global.Database.Initialize("Database.JSON");
            Filter.All = false;
            Filter.Teacher = false;
            Filter.Student = true;
            Filter.Class = false;
            Filter.Course = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Enabled = false;

            this.Hide();
            LoginView loginView = new LoginView();
            River.CreateObservableWithoutNotify(loginView);
            loginView.ShowDialog();
            this.Close();
        }
    }
}
