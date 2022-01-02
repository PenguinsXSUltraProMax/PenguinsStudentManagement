
namespace Penguins_Student_Management.Views
{
    partial class SectionDetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionDetailView));
            this.SectionNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.editGradientButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ContentLabel = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionNameLabel
            // 
            this.SectionNameLabel.AutoSize = true;
            this.SectionNameLabel.Font = new System.Drawing.Font("Google Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionNameLabel.Location = new System.Drawing.Point(24, 36);
            this.SectionNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.SectionNameLabel.Name = "SectionNameLabel";
            this.SectionNameLabel.Size = new System.Drawing.Size(126, 24);
            this.SectionNameLabel.TabIndex = 2;
            this.SectionNameLabel.Text = "Placeholder";
            // 
            // editGradientButton
            // 
            this.editGradientButton.BorderRadius = 3;
            this.editGradientButton.CheckedState.Parent = this.editGradientButton;
            this.editGradientButton.CustomImages.Parent = this.editGradientButton;
            this.editGradientButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.editGradientButton.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.editGradientButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editGradientButton.ForeColor = System.Drawing.Color.White;
            this.editGradientButton.HoverState.Parent = this.editGradientButton;
            this.editGradientButton.Image = global::Penguins_Student_Management.Properties.Resources.icons8_edit_48;
            this.editGradientButton.Location = new System.Drawing.Point(454, 30);
            this.editGradientButton.Name = "editGradientButton";
            this.editGradientButton.ShadowDecoration.Parent = this.editGradientButton;
            this.editGradientButton.Size = new System.Drawing.Size(36, 36);
            this.editGradientButton.TabIndex = 25;
            this.editGradientButton.Click += new System.EventHandler(this.editGradientButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ContentLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 26, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(488, 442);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentLabel.Location = new System.Drawing.Point(0, 0);
            this.ContentLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(460, 153);
            this.ContentLabel.TabIndex = 3;
            this.ContentLabel.Text = resources.GetString("ContentLabel.Text");
            // 
            // SectionDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 553);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.editGradientButton);
            this.Controls.Add(this.SectionNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SectionDetailView";
            this.Padding = new System.Windows.Forms.Padding(24, 36, 24, 24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài giảng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SectionDetailView_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel SectionNameLabel;
        private Guna.UI2.WinForms.Guna2GradientButton editGradientButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel ContentLabel;
    }
}