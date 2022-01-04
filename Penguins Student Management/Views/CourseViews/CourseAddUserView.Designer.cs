
namespace Penguins_Student_Management.Views.CourseViews
{
    partial class CourseAddUserView
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
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Label = new Guna.UI.WinForms.GunaLabel();
            this.ButtonDone = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.Location = new System.Drawing.Point(24, 94);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Panel.Size = new System.Drawing.Size(400, 436);
            this.Panel.TabIndex = 34;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Google Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(20, 36);
            this.Label.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(181, 24);
            this.Label.TabIndex = 35;
            this.Label.Text = "Thêm người dùng";
            // 
            // ButtonDone
            // 
            this.ButtonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDone.BorderRadius = 3;
            this.ButtonDone.CheckedState.Parent = this.ButtonDone;
            this.ButtonDone.CustomImages.Parent = this.ButtonDone;
            this.ButtonDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.ButtonDone.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(72)))), ((int)(((byte)(255)))));
            this.ButtonDone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDone.ForeColor = System.Drawing.Color.White;
            this.ButtonDone.HoverState.Parent = this.ButtonDone;
            this.ButtonDone.Image = global::Penguins_Student_Management.Properties.Resources.icons8_check_20;
            this.ButtonDone.ImageOffset = new System.Drawing.Point(-3, 0);
            this.ButtonDone.ImageSize = new System.Drawing.Size(18, 18);
            this.ButtonDone.Location = new System.Drawing.Point(327, 30);
            this.ButtonDone.Name = "ButtonDone";
            this.ButtonDone.ShadowDecoration.Parent = this.ButtonDone;
            this.ButtonDone.Size = new System.Drawing.Size(94, 32);
            this.ButtonDone.TabIndex = 36;
            this.ButtonDone.Text = "Xong";
            this.ButtonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // CourseAddUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 529);
            this.Controls.Add(this.ButtonDone);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Panel);
            this.Name = "CourseAddUserView";
            this.Padding = new System.Windows.Forms.Padding(24, 36, 24, 24);
            this.Text = "Thêm Người dùng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CourseAddUser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private Guna.UI.WinForms.GunaLabel Label;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonDone;
    }
}