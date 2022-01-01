
namespace Penguins_Student_Management.Views
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
            this.CourseNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.CategoryLabel = new Guna.UI.WinForms.GunaLabel();
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.editGradientButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deleteGradientButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UserPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Font = new System.Drawing.Font("Google Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNameLabel.Location = new System.Drawing.Point(24, 36);
            this.CourseNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(126, 24);
            this.CourseNameLabel.TabIndex = 2;
            this.CourseNameLabel.Text = "Placeholder";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(25, 62);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 14);
            this.CategoryLabel.TabIndex = 31;
            this.CategoryLabel.Text = "Placeholder";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Location = new System.Drawing.Point(0, 127);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(27, 3, 24, 0);
            this.MainPanel.Size = new System.Drawing.Size(613, 427);
            this.MainPanel.TabIndex = 32;
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
            // editGradientButton
            // 
            this.editGradientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editGradientButton.BorderRadius = 3;
            this.editGradientButton.CheckedState.Parent = this.editGradientButton;
            this.editGradientButton.CustomImages.Parent = this.editGradientButton;
            this.editGradientButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.editGradientButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.editGradientButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editGradientButton.ForeColor = System.Drawing.Color.White;
            this.editGradientButton.HoverState.Parent = this.editGradientButton;
            this.editGradientButton.Image = global::Penguins_Student_Management.Properties.Resources.icons8_edit_48;
            this.editGradientButton.Location = new System.Drawing.Point(923, 39);
            this.editGradientButton.Name = "editGradientButton";
            this.editGradientButton.ShadowDecoration.Parent = this.editGradientButton;
            this.editGradientButton.Size = new System.Drawing.Size(36, 32);
            this.editGradientButton.TabIndex = 34;
            this.editGradientButton.Click += new System.EventHandler(this.editGradientButton_Click);
            // 
            // deleteGradientButton
            // 
            this.deleteGradientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteGradientButton.BorderRadius = 3;
            this.deleteGradientButton.CheckedState.Parent = this.deleteGradientButton;
            this.deleteGradientButton.CustomImages.Parent = this.deleteGradientButton;
            this.deleteGradientButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteGradientButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteGradientButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteGradientButton.ForeColor = System.Drawing.Color.White;
            this.deleteGradientButton.HoverState.Parent = this.deleteGradientButton;
            this.deleteGradientButton.Image = global::Penguins_Student_Management.Properties.Resources.icons8_trash_48;
            this.deleteGradientButton.Location = new System.Drawing.Point(971, 39);
            this.deleteGradientButton.Name = "deleteGradientButton";
            this.deleteGradientButton.ShadowDecoration.Parent = this.deleteGradientButton;
            this.deleteGradientButton.Size = new System.Drawing.Size(36, 32);
            this.deleteGradientButton.TabIndex = 26;
            this.deleteGradientButton.Click += new System.EventHandler(this.deleteGradientButton_Click);
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
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.deleteGradientButton);
            this.Controls.Add(this.CourseNameLabel);
            this.Controls.Add(this.editGradientButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CourseDetailView";
            this.Padding = new System.Windows.Forms.Padding(24, 36, 24, 24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khóa học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CourseDetailView_FormClosing);
            this.Load += new System.EventHandler(this.CourseDetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel CourseNameLabel;
        private Guna.UI2.WinForms.Guna2GradientButton deleteGradientButton;
        private Guna.UI.WinForms.GunaLabel CategoryLabel;
        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton editGradientButton;
        private System.Windows.Forms.FlowLayoutPanel UserPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}