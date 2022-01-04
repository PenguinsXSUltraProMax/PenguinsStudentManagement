
namespace Penguins_Student_Management.Views.MainPages
{
    partial class TeacherPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Animated = true;
            this.ButtonAdd.BorderRadius = 3;
            this.ButtonAdd.CheckedState.Parent = this.ButtonAdd;
            this.ButtonAdd.CustomImages.Parent = this.ButtonAdd;
            this.ButtonAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ButtonAdd.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.Black;
            this.ButtonAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.ButtonAdd.HoverState.Parent = this.ButtonAdd;
            this.ButtonAdd.Image = global::Penguins_Student_Management.Properties.Resources.icons8_plus___24;
            this.ButtonAdd.ImageOffset = new System.Drawing.Point(-5, 0);
            this.ButtonAdd.ImageSize = new System.Drawing.Size(12, 12);
            this.ButtonAdd.Location = new System.Drawing.Point(772, 24);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.ShadowDecoration.Parent = this.ButtonAdd;
            this.ButtonAdd.Size = new System.Drawing.Size(110, 29);
            this.ButtonAdd.TabIndex = 17;
            this.ButtonAdd.Text = "Thêm";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.AutoScroll = true;
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Location = new System.Drawing.Point(28, 76);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(878, 527);
            this.Panel.TabIndex = 16;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Google Sans", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.gunaLabel7.Location = new System.Drawing.Point(24, 24);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(165, 24);
            this.gunaLabel7.TabIndex = 15;
            this.gunaLabel7.Text = "Quản lý giáo viên";
            // 
            // TeacherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penguins_Student_Management.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 603);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.gunaLabel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherPage";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherPage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ButtonAdd;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
    }
}