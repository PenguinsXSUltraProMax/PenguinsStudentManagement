using Penguins_Student_Management.Controllers.ClassController;
using Penguins_Student_Management.CustomUserControls;
using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views.MainTab
{
    public partial class ClassPage : Form, IObserver
    {
        TheRiver River;
        public ClassPage()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
        }

        public void SetState(TheRiver value)
        {
            River = value;
            InitClassState();
        }

        private void InitClassState()
        {
            Global.DisposeControls(Panel.Controls);
            Panel.Controls.Clear();

            Hook.of<ClassController>(River).GetAllClasses().ForEach(@class =>
            {
                ListItem item = new ListItem
                {
                    ID = @class.ID,
                    PrefixIcon = Properties.Resources.icons8_class_48,
                    Title = @class.Name,
                    Description = @class.Faculty,
                    RightTitle = @class.Users.Count + " 🐧",
                    Size = new Size(855, 72)
                };

                item.Click += ListItemClickHandle;

                Panel.Controls.Add(item);
            });
        }

        private void ListItemClickHandle(object sender, EventArgs e)
        {
            string id = ((ListItem)sender).ID;

            ClassDetailView view = new ClassDetailView(id);
            River.CreateObservable(view);
            view.ShowDialog();

        }
    }
}
