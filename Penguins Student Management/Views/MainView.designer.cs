
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
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sideMenuItemDashboard = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.sideMenuItemStudent = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.sideMenuItemTeacher = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.sideMenuItemClass = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.sideMenuItemCourse = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.studentTab = new System.Windows.Forms.TabPage();
            this.teacherTab = new System.Windows.Forms.TabPage();
            this.classTab = new System.Windows.Forms.TabPage();
            this.courseTab = new System.Windows.Forms.TabPage();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.sideMenuPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penguinsButton)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.sideMenuPanel.Controls.Add(this.flowLayoutPanel1);
            this.sideMenuPanel.Controls.Add(this.searchTextBox);
            this.sideMenuPanel.Controls.Add(this.sideMenuItemDashboard);
            this.sideMenuPanel.Controls.Add(this.sideMenuItemStudent);
            this.sideMenuPanel.Controls.Add(this.sideMenuItemTeacher);
            this.sideMenuPanel.Controls.Add(this.sideMenuItemClass);
            this.sideMenuPanel.Controls.Add(this.sideMenuItemCourse);
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
            // searchTextBox
            // 
            this.searchTextBox.Animated = true;
            this.searchTextBox.BorderRadius = 3;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.Parent = this.searchTextBox;
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.FocusedState.Parent = this.searchTextBox;
            this.searchTextBox.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.HoverState.Parent = this.searchTextBox;
            this.searchTextBox.Location = new System.Drawing.Point(18, 98);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Tìm kiếm";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.ShadowDecoration.Parent = this.searchTextBox;
            this.searchTextBox.Size = new System.Drawing.Size(240, 34);
            this.searchTextBox.TabIndex = 9;
            // 
            // sideMenuItemDashboard
            // 
            this.sideMenuItemDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideMenuItemDashboard.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_dashboard_layout_48;
            this.sideMenuItemDashboard.Index = 0;
            this.sideMenuItemDashboard.IsActive = true;
            this.sideMenuItemDashboard.Label = "Dashboard";
            this.sideMenuItemDashboard.Location = new System.Drawing.Point(18, 151);
            this.sideMenuItemDashboard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.sideMenuItemDashboard.Name = "sideMenuItemDashboard";
            this.sideMenuItemDashboard.Size = new System.Drawing.Size(240, 36);
            this.sideMenuItemDashboard.TabIndex = 3;
            this.sideMenuItemDashboard.Click += new System.EventHandler(this.SideMenuItemClickHandle);
            // 
            // sideMenuItemStudent
            // 
            this.sideMenuItemStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideMenuItemStudent.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_student_male_48;
            this.sideMenuItemStudent.Index = 1;
            this.sideMenuItemStudent.IsActive = false;
            this.sideMenuItemStudent.Label = "Quản lý sinh viên";
            this.sideMenuItemStudent.Location = new System.Drawing.Point(18, 199);
            this.sideMenuItemStudent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.sideMenuItemStudent.Name = "sideMenuItemStudent";
            this.sideMenuItemStudent.Size = new System.Drawing.Size(240, 36);
            this.sideMenuItemStudent.TabIndex = 6;
            this.sideMenuItemStudent.Click += new System.EventHandler(this.SideMenuItemClickHandle);
            // 
            // sideMenuItemTeacher
            // 
            this.sideMenuItemTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideMenuItemTeacher.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_school_director_48;
            this.sideMenuItemTeacher.Index = 2;
            this.sideMenuItemTeacher.IsActive = false;
            this.sideMenuItemTeacher.Label = "Quản lý giáo viên";
            this.sideMenuItemTeacher.Location = new System.Drawing.Point(18, 247);
            this.sideMenuItemTeacher.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.sideMenuItemTeacher.Name = "sideMenuItemTeacher";
            this.sideMenuItemTeacher.Size = new System.Drawing.Size(240, 36);
            this.sideMenuItemTeacher.TabIndex = 7;
            this.sideMenuItemTeacher.Click += new System.EventHandler(this.SideMenuItemClickHandle);
            // 
            // sideMenuItemClass
            // 
            this.sideMenuItemClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideMenuItemClass.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_class_48;
            this.sideMenuItemClass.Index = 3;
            this.sideMenuItemClass.IsActive = false;
            this.sideMenuItemClass.Label = "Quản lý lớp học";
            this.sideMenuItemClass.Location = new System.Drawing.Point(18, 295);
            this.sideMenuItemClass.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.sideMenuItemClass.Name = "sideMenuItemClass";
            this.sideMenuItemClass.Size = new System.Drawing.Size(240, 36);
            this.sideMenuItemClass.TabIndex = 12;
            this.sideMenuItemClass.Click += new System.EventHandler(this.SideMenuItemClickHandle);
            // 
            // sideMenuItemCourse
            // 
            this.sideMenuItemCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideMenuItemCourse.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_read_48;
            this.sideMenuItemCourse.Index = 4;
            this.sideMenuItemCourse.IsActive = false;
            this.sideMenuItemCourse.Label = "Quản lý khóa học";
            this.sideMenuItemCourse.Location = new System.Drawing.Point(18, 343);
            this.sideMenuItemCourse.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.sideMenuItemCourse.Name = "sideMenuItemCourse";
            this.sideMenuItemCourse.Size = new System.Drawing.Size(240, 36);
            this.sideMenuItemCourse.TabIndex = 10;
            this.sideMenuItemCourse.Click += new System.EventHandler(this.SideMenuItemClickHandle);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.dashboardTab);
            this.tabControl.Controls.Add(this.studentTab);
            this.tabControl.Controls.Add(this.teacherTab);
            this.tabControl.Controls.Add(this.classTab);
            this.tabControl.Controls.Add(this.courseTab);
            this.tabControl.Controls.Add(this.searchTab);
            this.tabControl.Location = new System.Drawing.Point(274, -9);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(914, 629);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // dashboardTab
            // 
            this.dashboardTab.BackColor = System.Drawing.Color.Transparent;
            this.dashboardTab.Location = new System.Drawing.Point(4, 22);
            this.dashboardTab.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Size = new System.Drawing.Size(906, 603);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            // 
            // studentTab
            // 
            this.studentTab.BackColor = System.Drawing.Color.Transparent;
            this.studentTab.Location = new System.Drawing.Point(4, 22);
            this.studentTab.Margin = new System.Windows.Forms.Padding(0);
            this.studentTab.Name = "studentTab";
            this.studentTab.Size = new System.Drawing.Size(906, 603);
            this.studentTab.TabIndex = 1;
            this.studentTab.Text = "Quản lý sinh viên";
            // 
            // teacherTab
            // 
            this.teacherTab.Location = new System.Drawing.Point(4, 22);
            this.teacherTab.Name = "teacherTab";
            this.teacherTab.Size = new System.Drawing.Size(906, 603);
            this.teacherTab.TabIndex = 3;
            this.teacherTab.Text = "Quản lý giáo viên";
            this.teacherTab.UseVisualStyleBackColor = true;
            // 
            // classTab
            // 
            this.classTab.Location = new System.Drawing.Point(4, 22);
            this.classTab.Margin = new System.Windows.Forms.Padding(0);
            this.classTab.Name = "classTab";
            this.classTab.Size = new System.Drawing.Size(906, 603);
            this.classTab.TabIndex = 5;
            this.classTab.Text = "Quản lý lớp học ";
            this.classTab.UseVisualStyleBackColor = true;
            // 
            // courseTab
            // 
            this.courseTab.Location = new System.Drawing.Point(4, 22);
            this.courseTab.Name = "courseTab";
            this.courseTab.Size = new System.Drawing.Size(906, 603);
            this.courseTab.TabIndex = 4;
            this.courseTab.Text = "Quản lý khóa học";
            this.courseTab.UseVisualStyleBackColor = true;
            // 
            // searchTab
            // 
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(906, 603);
            this.searchTab.TabIndex = 6;
            this.searchTab.Text = "Tìm kiếm";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Penguins_Student_Management.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.tabControl);
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
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideMenuPanel;
        private Guna.UI2.WinForms.Guna2PictureBox penguinsButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private CustomUserControls.SideMenuItem sideMenuItemDashboard;
        private CustomUserControls.SideMenuItem sideMenuItemStudent;
        private CustomUserControls.SideMenuItem sideMenuItemTeacher;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.TabPage studentTab;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private CustomUserControls.SideMenuItem sideMenuItemCourse;
        private CustomUserControls.SideMenuItem sideMenuItemClass;
        private System.Windows.Forms.TabPage teacherTab;
        private System.Windows.Forms.TabPage classTab;
        private System.Windows.Forms.TabPage courseTab;
        private System.Windows.Forms.TabPage searchTab;
    }
}