using Penguins_Student_Management.Controllers.AuthController;
using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.Controllers.UserController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class SectionDetailView : Form, IObserver
    {
        TheRiver River;
        CourseController courseController;
        string cid;
        string sid;
    
        public SectionDetailView(string cvalue, string svalue)
        {
            InitializeComponent();
            this.FormClosing += SectionDetailView_FormClosing;
            cid = cvalue;
            sid = svalue;
        }

        private void SectionDetailView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            courseController = Hook.of<CourseController>(River);

            Course course = courseController.GetCourseByID(cid);

            if(course.Owner == Hook.of<AuthController>(River).GetCurrentUser.ID || Hook.of<AuthController>(River).GetCurrentUser.Type == User.AccountType.Admin)
            {
                editGradientButton.Visible = true;
            } else
            {
                editGradientButton.Visible = false;
            }

            LoadData();
        }

        private void LoadData()
        {
            Section section = courseController.GetSectionByID(cid, sid);
            SectionNameLabel.Text = section.Name;
            ContentLabel.Text = section.Content;
        }

        private void editGradientButton_Click(object sender, EventArgs e)
        {

        }
    }
}
