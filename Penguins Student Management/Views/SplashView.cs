using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.Controllers.StudentController;
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
            TheRiver.CreateSubject(new StudentController())
        });

        public SplashView()
        {
            InitializeComponent();
            Global.Database.Initialize("Database.JSON");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Enabled = false;

            this.Hide();
            LoginView loginView = new LoginView();
            River.CreateObservable(loginView);
            loginView.ShowDialog();
            this.Close();
        }
    }
}
