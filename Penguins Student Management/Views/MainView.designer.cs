
namespace Penguins_Student_Management.Views
{
    partial class MainView
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
            this.sideMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.penguinsButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.SideMenuItemDashboard = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.SideMenuItemStudent = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.SideMenuItemTeacher = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.SideMenuItemClass = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.SideMenuItemCourse = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPageDashboard = new System.Windows.Forms.TabPage();
            this.TabPageStudent = new System.Windows.Forms.TabPage();
            this.TabPageTeacher = new System.Windows.Forms.TabPage();
            this.TabPageClass = new System.Windows.Forms.TabPage();
            this.TabPageCourse = new System.Windows.Forms.TabPage();
            this.TabPageSearch = new System.Windows.Forms.TabPage();
            this.sideMenuPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penguinsButton)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.sideMenuPanel.Controls.Add(this.flowLayoutPanel1);
            this.sideMenuPanel.Controls.Add(this.TextBoxSearch);
            this.sideMenuPanel.Controls.Add(this.SideMenuItemDashboard);
            this.sideMenuPanel.Controls.Add(this.SideMenuItemStudent);
            this.sideMenuPanel.Controls.Add(this.SideMenuItemTeacher);
            this.sideMenuPanel.Controls.Add(this.SideMenuItemClass);
            this.sideMenuPanel.Controls.Add(this.SideMenuItemCourse);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Padding = new System.Windows.Forms.Padding(18, 24, 18, 18);
            this.sideMenuPanel.Size = new System.Drawing.Size(280, 611);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.penguinsButton);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 24);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 42);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // penguinsButton
            // 
            this.penguinsButton.Image = global::Penguins_Student_Management.Properties.Resources.penguin;
            this.penguinsButton.Location = new System.Drawing.Point(0, 0);
            this.penguinsButton.Margin = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.penguinsButton.Name = "penguinsButton";
            this.penguinsButton.ShadowDecoration.Parent = this.penguinsButton;
            this.penguinsButton.Size = new System.Drawing.Size(42, 42);
            this.penguinsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.penguinsButton.TabIndex = 1;
            this.penguinsButton.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.gunaLabel1);
            this.flowLayoutPanel2.Controls.Add(this.gunaLabel2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(60, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(135, 42);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Google Sans", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(92, 24);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Penguins";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Google Sans", 5.890909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.gunaLabel2.Location = new System.Drawing.Point(3, 24);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 56);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 10);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "STUDENT MANAGEMENT";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Animated = true;
            this.TextBoxSearch.BorderRadius = 3;
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.DefaultText = "";
            this.TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.DisabledState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.FocusedState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.HoverState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Location = new System.Drawing.Point(18, 98);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 19);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderText = "Tìm kiếm";
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.ShadowDecoration.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Size = new System.Drawing.Size(240, 34);
            this.TextBoxSearch.TabIndex = 9;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // SideMenuItemDashboard
            // 
            this.SideMenuItemDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemDashboard.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_dashboard_layout_48;
            this.SideMenuItemDashboard.Index = 0;
            this.SideMenuItemDashboard.IsActive = true;
            this.SideMenuItemDashboard.Label = "Dashboard";
            this.SideMenuItemDashboard.Location = new System.Drawing.Point(18, 151);
            this.SideMenuItemDashboard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.SideMenuItemDashboard.Name = "SideMenuItemDashboard";
            this.SideMenuItemDashboard.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemDashboard.TabIndex = 3;
            this.SideMenuItemDashboard.Click += new System.EventHandler(this.SideMenuItemClickHandle);
            // 
            // SideMenuItemStudent
            // 
            this.SideMenuItemStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemStudent.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_student_male_48;
            this.SideMenuItemStudent.Index = 1;
            this.SideMenuItemStudent.IsActive = false;
            this.SideMenuItemStudent.Label = "Quản lý sinh viên";
            this.SideMenuItemStudent.Location = new System.Drawing.Point(18, 199);
            this.SideMenuItemStudent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.SideMenuItemStudent.Name = "SideMenuItemStudent";
            this.SideMenuItemStudent.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemStudent.TabIndex = 6;
            this.SideMenuItemStudent.Click += new System.EventHandler(this.SideMenuItemClickHandle);
            // 
            // SideMenuItemTeacher
            // 
            this.SideMenuItemTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemTeacher.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_school_director_48;
            this.SideMenuItemTeacher.Index = 2;
            this.SideMenuItemTeacher.IsActive = false;
            this.SideMenuItemTeacher.Label = "Quản lý giáo viên";
            this.SideMenuItemTeacher.Location = new System.Drawing.Point(18, 247);
            this.SideMenuItemTeacher.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.SideMenuItemTeacher.Name = "SideMenuItemTeacher";
            this.SideMenuItemTeacher.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemTeacher.TabIndex = 7;
            this.SideMenuItemTeacher.Click += new System.EventHandler(this.SideMenuItemClickHandle);
            // 
            // SideMenuItemClass
            // 
            this.SideMenuItemClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemClass.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_class_48;
            this.SideMenuItemClass.Index = 3;
            this.SideMenuItemClass.IsActive = false;
            this.SideMenuItemClass.Label = "Quản lý lớp học";
            this.SideMenuItemClass.Location = new System.Drawing.Point(18, 295);
            this.SideMenuItemClass.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.SideMenuItemClass.Name = "SideMenuItemClass";
            this.SideMenuItemClass.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemClass.TabIndex = 12;
            this.SideMenuItemClass.Click += new System.EventHandler(this.SideMenuItemClickHandle);
            // 
            // SideMenuItemCourse
            // 
            this.SideMenuItemCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemCourse.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_read_48;
            this.SideMenuItemCourse.Index = 4;
            this.SideMenuItemCourse.IsActive = false;
            this.SideMenuItemCourse.Label = "Quản lý khóa học";
            this.SideMenuItemCourse.Location = new System.Drawing.Point(18, 343);
            this.SideMenuItemCourse.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.SideMenuItemCourse.Name = "SideMenuItemCourse";
            this.SideMenuItemCourse.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemCourse.TabIndex = 10;
            this.SideMenuItemCourse.Click += new System.EventHandler(this.SideMenuItemClickHandle);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TabPageDashboard);
            this.TabControl.Controls.Add(this.TabPageStudent);
            this.TabControl.Controls.Add(this.TabPageTeacher);
            this.TabControl.Controls.Add(this.TabPageClass);
            this.TabControl.Controls.Add(this.TabPageCourse);
            this.TabControl.Controls.Add(this.TabPageSearch);
            this.TabControl.Location = new System.Drawing.Point(274, -9);
            this.TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(0, 0);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(914, 629);
            this.TabControl.TabIndex = 2;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // TabPageDashboard
            // 
            this.TabPageDashboard.BackColor = System.Drawing.Color.Transparent;
            this.TabPageDashboard.Location = new System.Drawing.Point(4, 22);
            this.TabPageDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.TabPageDashboard.Name = "TabPageDashboard";
            this.TabPageDashboard.Size = new System.Drawing.Size(906, 603);
            this.TabPageDashboard.TabIndex = 0;
            this.TabPageDashboard.Text = "Dashboard";
            // 
            // TabPageStudent
            // 
            this.TabPageStudent.BackColor = System.Drawing.Color.Transparent;
            this.TabPageStudent.Location = new System.Drawing.Point(4, 22);
            this.TabPageStudent.Margin = new System.Windows.Forms.Padding(0);
            this.TabPageStudent.Name = "TabPageStudent";
            this.TabPageStudent.Size = new System.Drawing.Size(906, 603);
            this.TabPageStudent.TabIndex = 1;
            this.TabPageStudent.Text = "Quản lý sinh viên";
            // 
            // TabPageTeacher
            // 
            this.TabPageTeacher.Location = new System.Drawing.Point(4, 22);
            this.TabPageTeacher.Name = "TabPageTeacher";
            this.TabPageTeacher.Size = new System.Drawing.Size(906, 603);
            this.TabPageTeacher.TabIndex = 3;
            this.TabPageTeacher.Text = "Quản lý giáo viên";
            this.TabPageTeacher.UseVisualStyleBackColor = true;
            // 
            // TabPageClass
            // 
            this.TabPageClass.Location = new System.Drawing.Point(4, 22);
            this.TabPageClass.Margin = new System.Windows.Forms.Padding(0);
            this.TabPageClass.Name = "TabPageClass";
            this.TabPageClass.Size = new System.Drawing.Size(906, 603);
            this.TabPageClass.TabIndex = 5;
            this.TabPageClass.Text = "Quản lý lớp học ";
            this.TabPageClass.UseVisualStyleBackColor = true;
            // 
            // TabPageCourse
            // 
            this.TabPageCourse.Location = new System.Drawing.Point(4, 22);
            this.TabPageCourse.Name = "TabPageCourse";
            this.TabPageCourse.Size = new System.Drawing.Size(906, 603);
            this.TabPageCourse.TabIndex = 4;
            this.TabPageCourse.Text = "Quản lý khóa học";
            this.TabPageCourse.UseVisualStyleBackColor = true;
            // 
            // TabPageSearch
            // 
            this.TabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.TabPageSearch.Name = "TabPageSearch";
            this.TabPageSearch.Size = new System.Drawing.Size(906, 603);
            this.TabPageSearch.TabIndex = 6;
            this.TabPageSearch.Text = "Tìm kiếm";
            this.TabPageSearch.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Penguins_Student_Management.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.TabControl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penguins Student Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.penguinsButton)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideMenuPanel;
        private Guna.UI2.WinForms.Guna2PictureBox penguinsButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private CustomUserControls.SideMenuItem SideMenuItemDashboard;
        private CustomUserControls.SideMenuItem SideMenuItemStudent;
        private CustomUserControls.SideMenuItem SideMenuItemTeacher;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPageDashboard;
        private System.Windows.Forms.TabPage TabPageStudent;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
        private CustomUserControls.SideMenuItem SideMenuItemCourse;
        private CustomUserControls.SideMenuItem SideMenuItemClass;
        private System.Windows.Forms.TabPage TabPageTeacher;
        private System.Windows.Forms.TabPage TabPageClass;
        private System.Windows.Forms.TabPage TabPageCourse;
        private System.Windows.Forms.TabPage TabPageSearch;
    }
}