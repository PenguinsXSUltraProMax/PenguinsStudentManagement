
namespace Penguins_Student_Management.Views.ClassViews
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
            this.LabelClassName = new Guna.UI.WinForms.GunaLabel();
            this.LabelFaculty = new Guna.UI.WinForms.GunaLabel();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ButtonDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ButtonPrint = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // LabelClassName
            // 
            this.LabelClassName.AutoSize = true;
            this.LabelClassName.Font = new System.Drawing.Font("Google Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClassName.Location = new System.Drawing.Point(24, 36);
            this.LabelClassName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.LabelClassName.Name = "LabelClassName";
            this.LabelClassName.Size = new System.Drawing.Size(126, 24);
            this.LabelClassName.TabIndex = 2;
            this.LabelClassName.Text = "Placeholder";
            // 
            // LabelFaculty
            // 
            this.LabelFaculty.AutoSize = true;
            this.LabelFaculty.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFaculty.Location = new System.Drawing.Point(25, 62);
            this.LabelFaculty.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.LabelFaculty.Name = "LabelFaculty";
            this.LabelFaculty.Size = new System.Drawing.Size(65, 14);
            this.LabelFaculty.TabIndex = 31;
            this.LabelFaculty.Text = "Placeholder";
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
            // ButtonEdit
            // 
            this.ButtonEdit.BorderRadius = 3;
            this.ButtonEdit.CheckedState.Parent = this.ButtonEdit;
            this.ButtonEdit.CustomImages.Parent = this.ButtonEdit;
            this.ButtonEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonEdit.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.ButtonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit.HoverState.Parent = this.ButtonEdit;
            this.ButtonEdit.Image = global::Penguins_Student_Management.Properties.Resources.icons8_edit_48;
            this.ButtonEdit.Location = new System.Drawing.Point(358, 39);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.ShadowDecoration.Parent = this.ButtonEdit;
            this.ButtonEdit.Size = new System.Drawing.Size(36, 32);
            this.ButtonEdit.TabIndex = 34;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BorderRadius = 3;
            this.ButtonDelete.CheckedState.Parent = this.ButtonDelete;
            this.ButtonDelete.CustomImages.Parent = this.ButtonDelete;
            this.ButtonDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.HoverState.Parent = this.ButtonDelete;
            this.ButtonDelete.Image = global::Penguins_Student_Management.Properties.Resources.icons8_trash_48;
            this.ButtonDelete.Location = new System.Drawing.Point(454, 39);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.ShadowDecoration.Parent = this.ButtonDelete;
            this.ButtonDelete.Size = new System.Drawing.Size(36, 32);
            this.ButtonDelete.TabIndex = 26;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.BorderRadius = 3;
            this.ButtonPrint.CheckedState.Parent = this.ButtonPrint;
            this.ButtonPrint.CustomImages.Parent = this.ButtonPrint;
            this.ButtonPrint.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonPrint.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonPrint.ForeColor = System.Drawing.Color.White;
            this.ButtonPrint.HoverState.Parent = this.ButtonPrint;
            this.ButtonPrint.Image = global::Penguins_Student_Management.Properties.Resources.icons8_print_24__1_;
            this.ButtonPrint.ImageSize = new System.Drawing.Size(18, 18);
            this.ButtonPrint.Location = new System.Drawing.Point(406, 39);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.ShadowDecoration.Parent = this.ButtonPrint;
            this.ButtonPrint.Size = new System.Drawing.Size(36, 32);
            this.ButtonPrint.TabIndex = 25;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // ClassDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 553);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.LabelFaculty);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.LabelClassName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClassDetailView";
            this.Padding = new System.Windows.Forms.Padding(24, 36, 24, 24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin lớp học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDetailView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel LabelClassName;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonPrint;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonDelete;
        private Guna.UI.WinForms.GunaLabel LabelFaculty;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonEdit;
    }
}