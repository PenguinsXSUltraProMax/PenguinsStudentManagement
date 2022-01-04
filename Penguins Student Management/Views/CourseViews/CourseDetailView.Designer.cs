
namespace Penguins_Student_Management.Views.CourseViews
{
    partial class CourseDetailView
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
            this.LabelCourseName = new Guna.UI.WinForms.GunaLabel();
            this.LabelCategory = new Guna.UI.WinForms.GunaLabel();
            this.SectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ButtonDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UserPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // LabelCourseName
            // 
            this.LabelCourseName.AutoSize = true;
            this.LabelCourseName.Font = new System.Drawing.Font("Google Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCourseName.Location = new System.Drawing.Point(24, 36);
            this.LabelCourseName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.LabelCourseName.Name = "LabelCourseName";
            this.LabelCourseName.Size = new System.Drawing.Size(126, 24);
            this.LabelCourseName.TabIndex = 2;
            this.LabelCourseName.Text = "Placeholder";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategory.Location = new System.Drawing.Point(25, 62);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(65, 14);
            this.LabelCategory.TabIndex = 31;
            this.LabelCategory.Text = "Placeholder";
            // 
            // SectionPanel
            // 
            this.SectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionPanel.AutoScroll = true;
            this.SectionPanel.Location = new System.Drawing.Point(0, 127);
            this.SectionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SectionPanel.Name = "SectionPanel";
            this.SectionPanel.Padding = new System.Windows.Forms.Padding(27, 3, 24, 0);
            this.SectionPanel.Size = new System.Drawing.Size(613, 427);
            this.SectionPanel.TabIndex = 32;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(25, 108);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(108, 14);
            this.gunaLabel1.TabIndex = 33;
            this.gunaLabel1.Text = "Danh sách bài giảng";
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEdit.BorderRadius = 3;
            this.ButtonEdit.CheckedState.Parent = this.ButtonEdit;
            this.ButtonEdit.CustomImages.Parent = this.ButtonEdit;
            this.ButtonEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonEdit.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.ButtonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit.HoverState.Parent = this.ButtonEdit;
            this.ButtonEdit.Image = global::Penguins_Student_Management.Properties.Resources.icons8_edit_48;
            this.ButtonEdit.Location = new System.Drawing.Point(925, 39);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.ShadowDecoration.Parent = this.ButtonEdit;
            this.ButtonEdit.Size = new System.Drawing.Size(36, 32);
            this.ButtonEdit.TabIndex = 34;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.BorderRadius = 3;
            this.ButtonDelete.CheckedState.Parent = this.ButtonDelete;
            this.ButtonDelete.CustomImages.Parent = this.ButtonDelete;
            this.ButtonDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.HoverState.Parent = this.ButtonDelete;
            this.ButtonDelete.Image = global::Penguins_Student_Management.Properties.Resources.icons8_trash_48;
            this.ButtonDelete.Location = new System.Drawing.Point(971, 39);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.ShadowDecoration.Parent = this.ButtonDelete;
            this.ButtonDelete.Size = new System.Drawing.Size(36, 32);
            this.ButtonDelete.TabIndex = 26;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPanel.AutoScroll = true;
            this.UserPanel.Location = new System.Drawing.Point(633, 127);
            this.UserPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.UserPanel.Size = new System.Drawing.Size(400, 427);
            this.UserPanel.TabIndex = 33;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(630, 108);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(120, 14);
            this.gunaLabel2.TabIndex = 35;
            this.gunaLabel2.Text = "Danh sách người dùng";
            // 
            // CourseDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 553);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.SectionPanel);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.LabelCourseName);
            this.Controls.Add(this.ButtonEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CourseDetailView";
            this.Padding = new System.Windows.Forms.Padding(24, 36, 24, 24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khóa học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CourseDetailView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel LabelCourseName;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonDelete;
        private Guna.UI.WinForms.GunaLabel LabelCategory;
        private System.Windows.Forms.FlowLayoutPanel SectionPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonEdit;
        private System.Windows.Forms.FlowLayoutPanel UserPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}