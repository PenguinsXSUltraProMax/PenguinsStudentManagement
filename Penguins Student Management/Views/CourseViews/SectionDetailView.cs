using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.CourseViews
{
    public partial class SectionDetailView : Form, IObserver
    {
        TheRiver River;
        AuthController Auth;
        CourseController CourseController;
        string CourseID;
        string SectionID;
    
        public SectionDetailView(string cvalue, string svalue)
        {
            InitializeComponent();
            this.FormClosing += SectionDetailView_FormClosing;
            CourseID = cvalue;
            SectionID = svalue;
        }

        private void SectionDetailView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            Auth = Hook.of<AuthController>(River);
            CourseController = Hook.of<CourseController>(River);

            Course course = CourseController.GetCourseByID(CourseID);

            ButtonEdit.Visible = course.Owner == Auth.GetCurrentUser.ID || Auth.GetCurrentUser.Type == User.AccountType.Admin;

            LoadData();
        }

        private void LoadData()
        {
            Section section = CourseController.GetSectionByID(CourseID, SectionID);
            LabelSectionName.Text = section.Name;
            LabelContent.Text = section.Content;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
