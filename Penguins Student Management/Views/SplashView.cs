using System;
using System.Windows.Forms;

namespace Penguins_Student_Management.Views
{
    public partial class SplashView : Form
    {

        public SplashView()
        {
            InitializeComponent();
            Global.Database.Initialize("Database.JSON");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Enabled = false;

            this.Hide();
            this.Close();
        }
    }
}
