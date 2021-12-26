
namespace Penguins_Student_Management.CustomUserControls
{
    partial class SideMenuItem
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
            this.Background = new Guna.UI2.WinForms.Guna2Panel();
            this.text = new Guna.UI.WinForms.GunaLabel();
            this.activeBar = new Guna.UI2.WinForms.Guna2Panel();
            this.Icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.BorderRadius = 3;
            this.Background.Controls.Add(this.text);
            this.Background.Controls.Add(this.activeBar);
            this.Background.Controls.Add(this.Icon);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.FillColor = System.Drawing.Color.Transparent;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Margin = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.Background.Name = "Background";
            this.Background.ShadowDecoration.Parent = this.Background;
            this.Background.Size = new System.Drawing.Size(240, 36);
            this.Background.TabIndex = 3;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Google Sans", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.Black;
            this.text.Location = new System.Drawing.Point(56, 9);
            this.text.Margin = new System.Windows.Forms.Padding(0, 9, 0, 10);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(63, 14);
            this.text.TabIndex = 3;
            this.text.Text = "Dashboard";
            // 
            // activeBar
            // 
            this.activeBar.BackColor = System.Drawing.Color.Transparent;
            this.activeBar.BorderRadius = 1;
            this.activeBar.FillColor = System.Drawing.Color.Transparent;
            this.activeBar.Location = new System.Drawing.Point(0, 7);
            this.activeBar.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.activeBar.Name = "activeBar";
            this.activeBar.ShadowDecoration.Parent = this.activeBar;
            this.activeBar.Size = new System.Drawing.Size(4, 22);
            this.activeBar.TabIndex = 2;
            // 
            // Icon
            // 
            this.Icon.FillColor = System.Drawing.Color.Transparent;
            this.Icon.Image = global::Penguins_Student_Management.Properties.Resources.icons8_dashboard_layout_48;
            this.Icon.Location = new System.Drawing.Point(6, 4);
            this.Icon.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.Icon.Name = "Icon";
            this.Icon.ShadowDecoration.Parent = this.Icon;
            this.Icon.Size = new System.Drawing.Size(42, 28);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon.TabIndex = 2;
            this.Icon.TabStop = false;
            // 
            // SideMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Background);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SideMenuItem";
            this.Size = new System.Drawing.Size(240, 36);
            this.MouseLeave += new System.EventHandler(this.SideMenuItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.SideMenuItem_MouseHover);
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Background;
        private Guna.UI.WinForms.GunaLabel text;
        private Guna.UI2.WinForms.Guna2Panel activeBar;
        private Guna.UI2.WinForms.Guna2PictureBox Icon;
    }
}
