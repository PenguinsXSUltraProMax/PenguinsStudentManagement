
namespace Penguins_Student_Management.CustomUserControls
{
    partial class CourseListItem
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
            this.label = new Guna.UI.WinForms.GunaLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel8
            // 
            this.guna2GradientPanel8.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2GradientPanel8.BorderRadius = 3;
            this.guna2GradientPanel8.BorderThickness = 1;
            this.guna2GradientPanel8.Controls.Add(this.label);
            this.guna2GradientPanel8.Controls.Add(this.guna2PictureBox1);
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
            this.guna2GradientPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel8_Paint);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(71, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Label";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Penguins_Student_Management.Properties.Resources.icons8_read_96;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 10);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(10, 10, 18, 10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // CourseListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GradientPanel8);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CourseListItem";
            this.Size = new System.Drawing.Size(580, 72);
            this.guna2GradientPanel8.ResumeLayout(false);
            this.guna2GradientPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel8;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI.WinForms.GunaLabel label;
    }
}
