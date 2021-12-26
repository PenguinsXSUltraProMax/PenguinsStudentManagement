
namespace Penguins_Student_Management.CustomUserControls
{
    partial class UserListItem
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
            this.image = new Guna.UI.WinForms.GunaPictureBox();
            this.nameLabel = new Guna.UI.WinForms.GunaLabel();
            this.classLabel = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.idLabel = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2GradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel8
            // 
            this.guna2GradientPanel8.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2GradientPanel8.BorderRadius = 3;
            this.guna2GradientPanel8.BorderThickness = 1;
            this.guna2GradientPanel8.Controls.Add(this.flowLayoutPanel1);
            this.guna2GradientPanel8.Controls.Add(this.classLabel);
            this.guna2GradientPanel8.Controls.Add(this.image);
            this.guna2GradientPanel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientPanel8.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel8.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel8.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.guna2GradientPanel8.Name = "guna2GradientPanel8";
            this.guna2GradientPanel8.Padding = new System.Windows.Forms.Padding(6);
            this.guna2GradientPanel8.ShadowDecoration.Parent = this.guna2GradientPanel8;
            this.guna2GradientPanel8.Size = new System.Drawing.Size(856, 80);
            this.guna2GradientPanel8.TabIndex = 11;
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Transparent;
            this.image.BaseColor = System.Drawing.Color.White;
            this.image.Image = global::Penguins_Student_Management.Properties.Resources._510e8fab3226f978a037;
            this.image.Location = new System.Drawing.Point(9, 9);
            this.image.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.image.Name = "image";
            this.image.Radius = 4;
            this.image.Size = new System.Drawing.Size(62, 62);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(0, 2);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0, 2, 12, 2);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.BackColor = System.Drawing.Color.Transparent;
            this.classLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.classLabel.Location = new System.Drawing.Point(86, 48);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(34, 15);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Class";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.nameLabel);
            this.flowLayoutPanel1.Controls.Add(this.idLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(86, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(632, 21);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // idLabel
            // 
            this.idLabel.BorderRadius = 8;
            this.idLabel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.idLabel.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.idLabel.Location = new System.Drawing.Point(54, 1);
            this.idLabel.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.idLabel.Name = "idLabel";
            this.idLabel.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idLabel.ShadowDecoration.Parent = this.idLabel;
            this.idLabel.Size = new System.Drawing.Size(100, 19);
            this.idLabel.TabIndex = 12;
            this.idLabel.Text = "ID";
            this.idLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // UserListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GradientPanel8);
            this.Name = "UserListItem";
            this.Size = new System.Drawing.Size(856, 92);
            this.guna2GradientPanel8.ResumeLayout(false);
            this.guna2GradientPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel8;
        private Guna.UI.WinForms.GunaPictureBox image;
        private Guna.UI.WinForms.GunaLabel nameLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Chip idLabel;
        private Guna.UI.WinForms.GunaLabel classLabel;
    }
}
