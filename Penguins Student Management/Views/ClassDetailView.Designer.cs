
namespace Penguins_Student_Management.Views
{
    partial class ClassDetailView
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
            this.ClassNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.FacultyLabel = new Guna.UI.WinForms.GunaLabel();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deleteGradientButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.editGradientButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Font = new System.Drawing.Font("Google Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassNameLabel.Location = new System.Drawing.Point(24, 36);
            this.ClassNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(126, 24);
            this.ClassNameLabel.TabIndex = 2;
            this.ClassNameLabel.Text = "Placeholder";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyLabel.Location = new System.Drawing.Point(25, 62);
            this.FacultyLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(65, 14);
            this.FacultyLabel.TabIndex = 31;
            this.FacultyLabel.Text = "Placeholder";
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.Location = new System.Drawing.Point(0, 127);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Padding = new System.Windows.Forms.Padding(27, 3, 24, 0);
            this.Panel.Size = new System.Drawing.Size(516, 427);
            this.Panel.TabIndex = 32;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(25, 108);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(120, 14);
            this.gunaLabel1.TabIndex = 33;
            this.gunaLabel1.Text = "Danh sách người dùng";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 3;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::Penguins_Student_Management.Properties.Resources.icons8_edit_48;
            this.guna2GradientButton1.Location = new System.Drawing.Point(358, 39);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(36, 32);
            this.guna2GradientButton1.TabIndex = 34;
            this.guna2GradientButton1.Click += new System.EventHandler(this.editGradientButton_Click);
            // 
            // deleteGradientButton
            // 
            this.deleteGradientButton.BorderRadius = 3;
            this.deleteGradientButton.CheckedState.Parent = this.deleteGradientButton;
            this.deleteGradientButton.CustomImages.Parent = this.deleteGradientButton;
            this.deleteGradientButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteGradientButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteGradientButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteGradientButton.ForeColor = System.Drawing.Color.White;
            this.deleteGradientButton.HoverState.Parent = this.deleteGradientButton;
            this.deleteGradientButton.Image = global::Penguins_Student_Management.Properties.Resources.icons8_trash_48;
            this.deleteGradientButton.Location = new System.Drawing.Point(454, 39);
            this.deleteGradientButton.Name = "deleteGradientButton";
            this.deleteGradientButton.ShadowDecoration.Parent = this.deleteGradientButton;
            this.deleteGradientButton.Size = new System.Drawing.Size(36, 32);
            this.deleteGradientButton.TabIndex = 26;
            this.deleteGradientButton.Click += new System.EventHandler(this.deleteGradientButton_Click);
            // 
            // editGradientButton
            // 
            this.editGradientButton.BorderRadius = 3;
            this.editGradientButton.CheckedState.Parent = this.editGradientButton;
            this.editGradientButton.CustomImages.Parent = this.editGradientButton;
            this.editGradientButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.editGradientButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.editGradientButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editGradientButton.ForeColor = System.Drawing.Color.White;
            this.editGradientButton.HoverState.Parent = this.editGradientButton;
            this.editGradientButton.Image = global::Penguins_Student_Management.Properties.Resources.icons8_print_24__1_;
            this.editGradientButton.ImageSize = new System.Drawing.Size(18, 18);
            this.editGradientButton.Location = new System.Drawing.Point(406, 39);
            this.editGradientButton.Name = "editGradientButton";
            this.editGradientButton.ShadowDecoration.Parent = this.editGradientButton;
            this.editGradientButton.Size = new System.Drawing.Size(36, 32);
            this.editGradientButton.TabIndex = 25;
            // 
            // ClassDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 553);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.deleteGradientButton);
            this.Controls.Add(this.editGradientButton);
            this.Controls.Add(this.ClassNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClassDetailView";
            this.Padding = new System.Windows.Forms.Padding(24, 36, 24, 24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin lớp học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDetailView_FormClosing);
            this.Load += new System.EventHandler(this.UserDetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel ClassNameLabel;
        private Guna.UI2.WinForms.Guna2GradientButton editGradientButton;
        private Guna.UI2.WinForms.Guna2GradientButton deleteGradientButton;
        private Guna.UI.WinForms.GunaLabel FacultyLabel;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}