
namespace Penguins_Student_Management.Views.CourseViews
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
            this.LabelSectionName = new Guna.UI.WinForms.GunaLabel();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelContent = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelSectionName
            // 
            this.LabelSectionName.AutoSize = true;
            this.LabelSectionName.Font = new System.Drawing.Font("Google Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSectionName.Location = new System.Drawing.Point(24, 36);
            this.LabelSectionName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.LabelSectionName.Name = "LabelSectionName";
            this.LabelSectionName.Size = new System.Drawing.Size(126, 24);
            this.LabelSectionName.TabIndex = 2;
            this.LabelSectionName.Text = "Placeholder";
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
            this.ButtonEdit.Location = new System.Drawing.Point(454, 30);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.ShadowDecoration.Parent = this.ButtonEdit;
            this.ButtonEdit.Size = new System.Drawing.Size(36, 36);
            this.ButtonEdit.TabIndex = 25;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.LabelContent);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 26, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(488, 442);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // LabelContent
            // 
            this.LabelContent.AutoSize = true;
            this.LabelContent.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContent.Location = new System.Drawing.Point(0, 0);
            this.LabelContent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.LabelContent.Name = "LabelContent";
            this.LabelContent.Size = new System.Drawing.Size(460, 153);
            this.LabelContent.TabIndex = 3;
            this.LabelContent.Text = resources.GetString("LabelContent.Text");
            // 
            // SectionDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 553);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.LabelSectionName);
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

        private Guna.UI.WinForms.GunaLabel LabelSectionName;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel LabelContent;
    }
}