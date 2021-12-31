
namespace Penguins_Student_Management.CustomUserControls
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GradientPanel8 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.prefixIcon = new Guna.UI.WinForms.GunaPictureBox();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.guna2GradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prefixIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel8
            // 
            this.guna2GradientPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel8.AutoSize = true;
            this.guna2GradientPanel8.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2GradientPanel8.BorderRadius = 3;
            this.guna2GradientPanel8.BorderThickness = 1;
            this.guna2GradientPanel8.Controls.Add(this.prefixIcon);
            this.guna2GradientPanel8.Controls.Add(this.title);
            this.guna2GradientPanel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientPanel8.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel8.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel8.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.guna2GradientPanel8.Name = "guna2GradientPanel8";
            this.guna2GradientPanel8.ShadowDecoration.Parent = this.guna2GradientPanel8;
            this.guna2GradientPanel8.Size = new System.Drawing.Size(580, 60);
            this.guna2GradientPanel8.TabIndex = 9;
            // 
            // prefixIcon
            // 
            this.prefixIcon.BackColor = System.Drawing.Color.Transparent;
            this.prefixIcon.BaseColor = System.Drawing.Color.White;
            this.prefixIcon.Location = new System.Drawing.Point(10, 10);
            this.prefixIcon.Margin = new System.Windows.Forms.Padding(10, 10, 18, 10);
            this.prefixIcon.Name = "prefixIcon";
            this.prefixIcon.Radius = 20;
            this.prefixIcon.Size = new System.Drawing.Size(40, 40);
            this.prefixIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prefixIcon.TabIndex = 2;
            this.prefixIcon.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(71, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(33, 17);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GradientPanel8);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(580, 72);
            this.guna2GradientPanel8.ResumeLayout(false);
            this.guna2GradientPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prefixIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel8;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaPictureBox prefixIcon;
    }
}
