using System;
using System.Drawing;
using System.Windows.Forms;

namespace Penguins_Student_Management.CustomUserControls
{
    public partial class SideMenuItem : UserControl
    {
        #region Properties
        private string label = "Label";
        private Image iconImage;
        private bool isActive = false;

        private readonly Color NORMAL_BACKGROUND_COLOR = Color.Transparent;
        private readonly Color ACTIVE_BACKGROUND_COLOR = Color.FromArgb(236, 232, 240);
        private readonly Color ACTIVE_BAR_COLOR = Color.FromArgb(0, 103, 192);

        public string Label { get => label; set { label = value; text.Text = value; } }
        public Image IconImage { get => iconImage; set { iconImage = value; Icon.Image = value; } }
        public bool IsActive {
            get => isActive;
            set {
                isActive = value;
                activeBar.FillColor = isActive == true ? ACTIVE_BAR_COLOR : Color.Transparent;
                Background.FillColor = isActive == true ? ACTIVE_BACKGROUND_COLOR : NORMAL_BACKGROUND_COLOR;
            }
        }
        #endregion
        public SideMenuItem()
        {
            InitializeComponent();
            text.Text = Label;
            Icon.Image = IconImage;
            WireAllControls(this.Controls);
        }

        private void WireAllControls(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.Click += Control_Click;
                control.MouseHover += SideMenuItem_MouseHover;
                control.MouseLeave += SideMenuItem_MouseLeave;
                if (control.HasChildren)
                {
                    WireAllControls(control.Controls);
                }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

        private void SideMenuItem_MouseHover(object sender, EventArgs e)
        {
            Background.FillColor = ACTIVE_BACKGROUND_COLOR;
        }

        private void SideMenuItem_MouseLeave(object sender, EventArgs e)
        {
            Background.FillColor = this.IsActive == true ? ACTIVE_BACKGROUND_COLOR : NORMAL_BACKGROUND_COLOR;
        }
    }
}
