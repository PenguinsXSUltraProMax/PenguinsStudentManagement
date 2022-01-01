
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.description = new Guna.UI.WinForms.GunaLabel();
            this.rightText = new Guna.UI.WinForms.GunaLabel();
            this.prefixIcon = new Guna.UI.WinForms.GunaPictureBox();
            this.guna2GradientPanel8.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prefixIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel8
            // 
            this.guna2GradientPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel8.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2GradientPanel8.BorderRadius = 3;
            this.guna2GradientPanel8.BorderThickness = 1;
            this.guna2GradientPanel8.Controls.Add(this.flowLayoutPanel1);
            this.guna2GradientPanel8.Controls.Add(this.rightText);
            this.guna2GradientPanel8.Controls.Add(this.prefixIcon);
            this.guna2GradientPanel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientPanel8.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel8.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel8.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.guna2GradientPanel8.Name = "guna2GradientPanel8";
            this.guna2GradientPanel8.ShadowDecoration.Parent = this.guna2GradientPanel8;
            this.guna2GradientPanel8.Size = new System.Drawing.Size(375, 60);
            this.guna2GradientPanel8.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.title);
            this.flowLayoutPanel1.Controls.Add(this.description);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(65, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 60);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 22);
            this.title.Margin = new System.Windows.Forms.Padding(3, 22, 8, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(33, 17);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.description.Location = new System.Drawing.Point(47, 22);
            this.description.Margin = new System.Windows.Forms.Padding(3, 22, 3, 21);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(0, 17);
            this.description.TabIndex = 2;
            // 
            // rightText
            // 
            this.rightText.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightText.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightText.Location = new System.Drawing.Point(250, 0);
            this.rightText.Margin = new System.Windows.Forms.Padding(0);
            this.rightText.Name = "rightText";
            this.rightText.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.rightText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rightText.Size = new System.Drawing.Size(125, 60);
            this.rightText.TabIndex = 3;
            this.rightText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prefixIcon
            // 
            this.prefixIcon.BackColor = System.Drawing.Color.Transparent;
            this.prefixIcon.BaseColor = System.Drawing.Color.White;
            this.prefixIcon.Location = new System.Drawing.Point(15, 14);
            this.prefixIcon.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.prefixIcon.Name = "prefixIcon";
            this.prefixIcon.Size = new System.Drawing.Size(32, 32);
            this.prefixIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prefixIcon.TabIndex = 2;
            this.prefixIcon.TabStop = false;
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
            this.Size = new System.Drawing.Size(375, 72);
            this.guna2GradientPanel8.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prefixIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel8;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaPictureBox prefixIcon;
        private Guna.UI.WinForms.GunaLabel rightText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel description;
    }
}
