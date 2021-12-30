
namespace Penguins_Student_Management.Views.MainTab
{
    partial class ClassPage
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
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Google Sans", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.gunaLabel7.Location = new System.Drawing.Point(24, 24);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(150, 24);
            this.gunaLabel7.TabIndex = 16;
            this.gunaLabel7.Text = "Quản lý lớp học";
            // 
            // ClassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penguins_Student_Management.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 603);
            this.Controls.Add(this.gunaLabel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassPage";
            this.Padding = new System.Windows.Forms.Padding(24, 24, 24, 0);
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel7;
    }
}