
namespace Penguins_Student_Management.Views.MainPages
{
    partial class DashboardPage
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.SideMenuItemMyUniversity = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.SideMenuItemSSchedule = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.SideMenuItemTSchedule = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.SideMenuItemLogInfo = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.SideMenuItemChangePassword = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.SideMenuItemSignOut = new Penguins_Student_Management.CustomUserControls.SideMenuItem();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.PictureBoxUserAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelUserID = new Guna.UI.WinForms.GunaLabel();
            this.LabelUsername = new Guna.UI.WinForms.GunaLabel();
            this.LabelTime = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserAvatar)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.gunaLabel5);
            this.flowLayoutPanel3.Controls.Add(this.SideMenuItemMyUniversity);
            this.flowLayoutPanel3.Controls.Add(this.SideMenuItemSSchedule);
            this.flowLayoutPanel3.Controls.Add(this.SideMenuItemTSchedule);
            this.flowLayoutPanel3.Controls.Add(this.SideMenuItemLogInfo);
            this.flowLayoutPanel3.Controls.Add(this.SideMenuItemChangePassword);
            this.flowLayoutPanel3.Controls.Add(this.SideMenuItemSignOut);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(642, 101);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(240, 501);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.gunaLabel5.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(240, 17);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "Ứng dụng";
            // 
            // SideMenuItemMyUniversity
            // 
            this.SideMenuItemMyUniversity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemMyUniversity.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_school_building_48;
            this.SideMenuItemMyUniversity.Index = 0;
            this.SideMenuItemMyUniversity.IsActive = false;
            this.SideMenuItemMyUniversity.Label = "Trường tôi";
            this.SideMenuItemMyUniversity.Location = new System.Drawing.Point(0, 29);
            this.SideMenuItemMyUniversity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.SideMenuItemMyUniversity.Name = "SideMenuItemMyUniversity";
            this.SideMenuItemMyUniversity.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemMyUniversity.TabIndex = 12;
            // 
            // SideMenuItemSSchedule
            // 
            this.SideMenuItemSSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemSSchedule.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_curriculum_48;
            this.SideMenuItemSSchedule.Index = 0;
            this.SideMenuItemSSchedule.IsActive = false;
            this.SideMenuItemSSchedule.Label = "Lịch học sinh viên";
            this.SideMenuItemSSchedule.Location = new System.Drawing.Point(0, 73);
            this.SideMenuItemSSchedule.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.SideMenuItemSSchedule.Name = "SideMenuItemSSchedule";
            this.SideMenuItemSSchedule.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemSSchedule.TabIndex = 13;
            // 
            // SideMenuItemTSchedule
            // 
            this.SideMenuItemTSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemTSchedule.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_training_48;
            this.SideMenuItemTSchedule.Index = 0;
            this.SideMenuItemTSchedule.IsActive = false;
            this.SideMenuItemTSchedule.Label = "Lịch dạy giáo viên";
            this.SideMenuItemTSchedule.Location = new System.Drawing.Point(0, 117);
            this.SideMenuItemTSchedule.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.SideMenuItemTSchedule.Name = "SideMenuItemTSchedule";
            this.SideMenuItemTSchedule.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemTSchedule.TabIndex = 14;
            // 
            // SideMenuItemLogInfo
            // 
            this.SideMenuItemLogInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemLogInfo.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_contact_details_48;
            this.SideMenuItemLogInfo.Index = 0;
            this.SideMenuItemLogInfo.IsActive = false;
            this.SideMenuItemLogInfo.Label = "Thông tin đăng nhập";
            this.SideMenuItemLogInfo.Location = new System.Drawing.Point(0, 161);
            this.SideMenuItemLogInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.SideMenuItemLogInfo.Name = "SideMenuItemLogInfo";
            this.SideMenuItemLogInfo.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemLogInfo.TabIndex = 16;
            this.SideMenuItemLogInfo.Click += new System.EventHandler(this.SideMenuItemLogInfo_Click);
            // 
            // SideMenuItemChangePassword
            // 
            this.SideMenuItemChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemChangePassword.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_asterisk_48;
            this.SideMenuItemChangePassword.Index = 0;
            this.SideMenuItemChangePassword.IsActive = false;
            this.SideMenuItemChangePassword.Label = "Đổi mật khẩu";
            this.SideMenuItemChangePassword.Location = new System.Drawing.Point(0, 205);
            this.SideMenuItemChangePassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.SideMenuItemChangePassword.Name = "SideMenuItemChangePassword";
            this.SideMenuItemChangePassword.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemChangePassword.TabIndex = 17;
            this.SideMenuItemChangePassword.Click += new System.EventHandler(this.SideMenuItemChangePassword_Click);
            // 
            // SideMenuItemSignOut
            // 
            this.SideMenuItemSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideMenuItemSignOut.IconImage = global::Penguins_Student_Management.Properties.Resources.icons8_exit_sign_48;
            this.SideMenuItemSignOut.Index = 0;
            this.SideMenuItemSignOut.IsActive = false;
            this.SideMenuItemSignOut.Label = "Đăng xuất";
            this.SideMenuItemSignOut.Location = new System.Drawing.Point(0, 249);
            this.SideMenuItemSignOut.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.SideMenuItemSignOut.Name = "SideMenuItemSignOut";
            this.SideMenuItemSignOut.Size = new System.Drawing.Size(240, 36);
            this.SideMenuItemSignOut.TabIndex = 18;
            this.SideMenuItemSignOut.Click += new System.EventHandler(this.SideMenuItemSignOut_Cick);
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.AutoScroll = true;
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Location = new System.Drawing.Point(27, 135);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(604, 467);
            this.Panel.TabIndex = 16;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.gunaLabel4.Location = new System.Drawing.Point(24, 101);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(111, 17);
            this.gunaLabel4.TabIndex = 15;
            this.gunaLabel4.Text = "Khóa học của tôi";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.gunaLabel3);
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel6);
            this.guna2Panel1.Controls.Add(this.LabelTime);
            this.guna2Panel1.Location = new System.Drawing.Point(27, 25);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(24, 28, 24, 36);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(855, 40);
            this.guna2Panel1.TabIndex = 14;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Google Sans", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.gunaLabel3.Location = new System.Drawing.Point(-5, 0);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(110, 24);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Dashboard";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel6.Controls.Add(this.PictureBoxUserAvatar);
            this.flowLayoutPanel6.Controls.Add(this.guna2Panel2);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(615, 2);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(240, 36);
            this.flowLayoutPanel6.TabIndex = 6;
            // 
            // PictureBoxUserAvatar
            // 
            this.PictureBoxUserAvatar.Image = global::Penguins_Student_Management.Properties.Resources._510e8fab3226f978a037;
            this.PictureBoxUserAvatar.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxUserAvatar.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.PictureBoxUserAvatar.Name = "PictureBoxUserAvatar";
            this.PictureBoxUserAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxUserAvatar.ShadowDecoration.Parent = this.PictureBoxUserAvatar;
            this.PictureBoxUserAvatar.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxUserAvatar.TabIndex = 1;
            this.PictureBoxUserAvatar.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.Controls.Add(this.LabelUserID);
            this.guna2Panel2.Controls.Add(this.LabelUsername);
            this.guna2Panel2.Location = new System.Drawing.Point(44, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(194, 36);
            this.guna2Panel2.TabIndex = 2;
            // 
            // LabelUserID
            // 
            this.LabelUserID.AutoSize = true;
            this.LabelUserID.BackColor = System.Drawing.Color.Transparent;
            this.LabelUserID.Font = new System.Drawing.Font("Google Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.LabelUserID.Location = new System.Drawing.Point(3, 20);
            this.LabelUserID.Margin = new System.Windows.Forms.Padding(0, 9, 0, 10);
            this.LabelUserID.Name = "LabelUserID";
            this.LabelUserID.Size = new System.Drawing.Size(12, 12);
            this.LabelUserID.TabIndex = 5;
            this.LabelUserID.Text = "id";
            this.LabelUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.BackColor = System.Drawing.Color.Transparent;
            this.LabelUsername.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.LabelUsername.Location = new System.Drawing.Point(2, 3);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(0, 9, 0, 10);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(66, 17);
            this.LabelUsername.TabIndex = 4;
            this.LabelUsername.Text = "Username";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelTime.Font = new System.Drawing.Font("Google Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.LabelTime.Location = new System.Drawing.Point(-2, 26);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 56);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(77, 12);
            this.LabelTime.TabIndex = 6;
            this.LabelTime.Text = "THỨ 3, 04/12/2021";
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penguins_Student_Management.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 603);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardPage";
            this.Padding = new System.Windows.Forms.Padding(24, 24, 24, 0);
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserAvatar)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private CustomUserControls.SideMenuItem SideMenuItemMyUniversity;
        private CustomUserControls.SideMenuItem SideMenuItemSSchedule;
        private CustomUserControls.SideMenuItem SideMenuItemTSchedule;
        private CustomUserControls.SideMenuItem SideMenuItemLogInfo;
        private CustomUserControls.SideMenuItem SideMenuItemChangePassword;
        private CustomUserControls.SideMenuItem SideMenuItemSignOut;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxUserAvatar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI.WinForms.GunaLabel LabelUserID;
        private Guna.UI.WinForms.GunaLabel LabelUsername;
        private Guna.UI.WinForms.GunaLabel LabelTime;
    }
}