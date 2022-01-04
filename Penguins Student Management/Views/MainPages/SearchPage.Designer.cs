
namespace Penguins_Student_Management.Views.MainPages
{
    partial class SearchPage
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
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.AllCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CourseCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ClassCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.StudentCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TeacherCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
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
            this.gunaLabel7.Size = new System.Drawing.Size(91, 24);
            this.gunaLabel7.TabIndex = 16;
            this.gunaLabel7.Text = "Tìm kiếm";
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
            this.Panel.TabIndex = 17;
            // 
            // AllCheckBox
            // 
            this.AllCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllCheckBox.AutoSize = true;
            this.AllCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllCheckBox.CheckedState.BorderRadius = 2;
            this.AllCheckBox.CheckedState.BorderThickness = 0;
            this.AllCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllCheckBox.Location = new System.Drawing.Point(454, 31);
            this.AllCheckBox.Name = "AllCheckBox";
            this.AllCheckBox.Size = new System.Drawing.Size(57, 17);
            this.AllCheckBox.TabIndex = 0;
            this.AllCheckBox.Text = "Tất cả";
            this.AllCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AllCheckBox.UncheckedState.BorderRadius = 2;
            this.AllCheckBox.UncheckedState.BorderThickness = 0;
            this.AllCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AllCheckBox.UseVisualStyleBackColor = true;
            this.AllCheckBox.CheckedChanged += new System.EventHandler(this.AllCheckBox_CheckedChanged);
            // 
            // CourseCheckBox
            // 
            this.CourseCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseCheckBox.AutoSize = true;
            this.CourseCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseCheckBox.CheckedState.BorderRadius = 2;
            this.CourseCheckBox.CheckedState.BorderThickness = 0;
            this.CourseCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CourseCheckBox.Location = new System.Drawing.Point(805, 31);
            this.CourseCheckBox.Name = "CourseCheckBox";
            this.CourseCheckBox.Size = new System.Drawing.Size(72, 17);
            this.CourseCheckBox.TabIndex = 18;
            this.CourseCheckBox.Text = "Khóa học";
            this.CourseCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CourseCheckBox.UncheckedState.BorderRadius = 2;
            this.CourseCheckBox.UncheckedState.BorderThickness = 0;
            this.CourseCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CourseCheckBox.UseVisualStyleBackColor = true;
            this.CourseCheckBox.CheckedChanged += new System.EventHandler(this.CourseCheckBox_CheckedChanged);
            // 
            // ClassCheckBox
            // 
            this.ClassCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassCheckBox.AutoSize = true;
            this.ClassCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClassCheckBox.CheckedState.BorderRadius = 2;
            this.ClassCheckBox.CheckedState.BorderThickness = 0;
            this.ClassCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClassCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassCheckBox.Location = new System.Drawing.Point(718, 31);
            this.ClassCheckBox.Name = "ClassCheckBox";
            this.ClassCheckBox.Size = new System.Drawing.Size(65, 17);
            this.ClassCheckBox.TabIndex = 19;
            this.ClassCheckBox.Text = "Lớp học";
            this.ClassCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ClassCheckBox.UncheckedState.BorderRadius = 2;
            this.ClassCheckBox.UncheckedState.BorderThickness = 0;
            this.ClassCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ClassCheckBox.UseVisualStyleBackColor = true;
            this.ClassCheckBox.CheckedChanged += new System.EventHandler(this.ClassCheckBox_CheckedChanged);
            // 
            // StudentCheckBox
            // 
            this.StudentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentCheckBox.AutoSize = true;
            this.StudentCheckBox.Checked = true;
            this.StudentCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentCheckBox.CheckedState.BorderRadius = 2;
            this.StudentCheckBox.CheckedState.BorderThickness = 0;
            this.StudentCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StudentCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentCheckBox.Location = new System.Drawing.Point(626, 31);
            this.StudentCheckBox.Name = "StudentCheckBox";
            this.StudentCheckBox.Size = new System.Drawing.Size(70, 17);
            this.StudentCheckBox.TabIndex = 20;
            this.StudentCheckBox.Text = "Sinh viên";
            this.StudentCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.StudentCheckBox.UncheckedState.BorderRadius = 2;
            this.StudentCheckBox.UncheckedState.BorderThickness = 0;
            this.StudentCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.StudentCheckBox.UseVisualStyleBackColor = true;
            this.StudentCheckBox.CheckedChanged += new System.EventHandler(this.StudentCheckBox_CheckedChanged);
            // 
            // TeacherCheckBox
            // 
            this.TeacherCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TeacherCheckBox.AutoSize = true;
            this.TeacherCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeacherCheckBox.CheckedState.BorderRadius = 2;
            this.TeacherCheckBox.CheckedState.BorderThickness = 0;
            this.TeacherCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeacherCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeacherCheckBox.Location = new System.Drawing.Point(533, 31);
            this.TeacherCheckBox.Name = "TeacherCheckBox";
            this.TeacherCheckBox.Size = new System.Drawing.Size(71, 17);
            this.TeacherCheckBox.TabIndex = 21;
            this.TeacherCheckBox.Text = "Giáo viên";
            this.TeacherCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TeacherCheckBox.UncheckedState.BorderRadius = 2;
            this.TeacherCheckBox.UncheckedState.BorderThickness = 0;
            this.TeacherCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TeacherCheckBox.UseVisualStyleBackColor = true;
            this.TeacherCheckBox.CheckedChanged += new System.EventHandler(this.TeacherCheckBox_CheckedChanged);
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penguins_Student_Management.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 603);
            this.Controls.Add(this.TeacherCheckBox);
            this.Controls.Add(this.StudentCheckBox);
            this.Controls.Add(this.ClassCheckBox);
            this.Controls.Add(this.CourseCheckBox);
            this.Controls.Add(this.AllCheckBox);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.gunaLabel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchPage";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private Guna.UI2.WinForms.Guna2CheckBox AllCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox CourseCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox ClassCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox StudentCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox TeacherCheckBox;
    }
}