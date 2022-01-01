﻿
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
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
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
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.AutoScroll = true;
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Location = new System.Drawing.Point(28, 76);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(878, 527);
            this.Panel.TabIndex = 17;
            // 
            // addButton
            // 
            this.addButton.Animated = true;
            this.addButton.BorderRadius = 3;
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.addButton.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Image = global::Penguins_Student_Management.Properties.Resources.icons8_plus___24;
            this.addButton.ImageOffset = new System.Drawing.Point(-5, 0);
            this.addButton.ImageSize = new System.Drawing.Size(12, 12);
            this.addButton.Location = new System.Drawing.Point(772, 24);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(110, 29);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Thêm";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ClassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penguins_Student_Management.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 603);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Panel);
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
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private Guna.UI2.WinForms.Guna2Button addButton;
    }
}