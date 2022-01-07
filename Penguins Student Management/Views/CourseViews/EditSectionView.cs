using Penguins_Student_Management.Controllers.CourseController;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.CourseViews
{
    public partial class EditSectionView : Form, IObserver
    {
        TheRiver River;
        CourseController CourseController;
        Section section;
        string CourseID;
        string SectionID;

        public EditSectionView(string cvalue, string svalue)
        {
            InitializeComponent();
            this.FormClosing += EditSectionView_FormClosing;
            CourseID = cvalue;
            SectionID = svalue;
        }

        private void EditSectionView_FormClosing(object sender, FormClosingEventArgs e)
        {
            River.DisposeObservable(this);
        }

        public void SetState(TheRiver value)
        {
            River = value;
            CourseController = Hook.of<CourseController>(River);
            LoadData();
        }

        private void LoadData() {

            section = CourseController.GetSectionByID(CourseID, SectionID);
            TextBoxSectionName.Text = section.Name;
            TextBoxContent.Text = section.Content;

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string Name = TextBoxSectionName.Text;
            string Content = TextBoxContent.Text;

            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Content))
            {
                MessageBox.Show("Không được bỏ trống!");
                return;
            }

            section.Name = Name;
            section.Content = Content;

            CourseController.UpdateSection(CourseID, section);

            MessageBox.Show("Sửa thành công!");
            River.Notify();

            this.Close();
        }

    }
}
