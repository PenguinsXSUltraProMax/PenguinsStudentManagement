
namespace Penguins_Student_Management.Views.MainTab
{
    partial class Student
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
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.studentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Animated = true;
            this.addButton.BorderRadius = 3;
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.addButton.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Image = global::Penguins_Student_Management.Properties.Resources.icons8_plus___24;
            this.addButton.ImageOffset = new System.Drawing.Point(-5, 0);
            this.addButton.ImageSize = new System.Drawing.Size(12, 12);
            this.addButton.Location = new System.Drawing.Point(772, 24);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(110, 29);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Thêm";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // studentPanel
            // 
            this.studentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentPanel.AutoScroll = true;
            this.studentPanel.BackColor = System.Drawing.Color.Transparent;
            this.studentPanel.Location = new System.Drawing.Point(28, 76);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(878, 527);
            this.studentPanel.TabIndex = 16;
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
            this.gunaLabel7.Size = new System.Drawing.Size(162, 24);
            this.gunaLabel7.TabIndex = 15;
            this.gunaLabel7.Text = "Quản lý sinh viên";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penguins_Student_Management.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 603);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.gunaLabel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button addButton;
        private System.Windows.Forms.FlowLayoutPanel studentPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
    }
}