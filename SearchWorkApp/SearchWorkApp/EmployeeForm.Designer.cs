namespace SearchWorkApp
{
    partial class EmployeeForm
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopPanel2 = new System.Windows.Forms.Panel();
            this.MinimizeIconButton = new FontAwesome.Sharp.IconButton();
            this.CloseIconButton = new FontAwesome.Sharp.IconButton();
            this.MaximizaIconButton = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TopPanel1 = new System.Windows.Forms.Panel();
            this.MessagesIconButton = new FontAwesome.Sharp.IconButton();
            this.UserProfile = new FontAwesome.Sharp.IconButton();
            this.SettingsIconButton = new FontAwesome.Sharp.IconButton();
            this.LeaveIconButton = new FontAwesome.Sharp.IconButton();
            this.HomeIconButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.TopPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.TopPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(126, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 587);
            this.panel1.TabIndex = 0;
            // 
            // TopPanel2
            // 
            this.TopPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.TopPanel2.Controls.Add(this.MinimizeIconButton);
            this.TopPanel2.Controls.Add(this.CloseIconButton);
            this.TopPanel2.Controls.Add(this.MaximizaIconButton);
            this.TopPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel2.Location = new System.Drawing.Point(0, 0);
            this.TopPanel2.Name = "TopPanel2";
            this.TopPanel2.Size = new System.Drawing.Size(860, 39);
            this.TopPanel2.TabIndex = 7;
            this.TopPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel2_MouseDown);
            // 
            // MinimizeIconButton
            // 
            this.MinimizeIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MinimizeIconButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MinimizeIconButton.FlatAppearance.BorderSize = 0;
            this.MinimizeIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeIconButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.MinimizeIconButton.IconColor = System.Drawing.Color.White;
            this.MinimizeIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeIconButton.IconSize = 35;
            this.MinimizeIconButton.Location = new System.Drawing.Point(725, 0);
            this.MinimizeIconButton.Name = "MinimizeIconButton";
            this.MinimizeIconButton.Size = new System.Drawing.Size(45, 35);
            this.MinimizeIconButton.TabIndex = 6;
            this.MinimizeIconButton.UseVisualStyleBackColor = false;
            this.MinimizeIconButton.Click += new System.EventHandler(this.MinimizeIconButton_Click);
            // 
            // CloseIconButton
            // 
            this.CloseIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CloseIconButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseIconButton.FlatAppearance.BorderSize = 0;
            this.CloseIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseIconButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.CloseIconButton.IconColor = System.Drawing.Color.White;
            this.CloseIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseIconButton.IconSize = 35;
            this.CloseIconButton.Location = new System.Drawing.Point(815, 0);
            this.CloseIconButton.Name = "CloseIconButton";
            this.CloseIconButton.Size = new System.Drawing.Size(45, 35);
            this.CloseIconButton.TabIndex = 4;
            this.CloseIconButton.UseVisualStyleBackColor = false;
            this.CloseIconButton.Click += new System.EventHandler(this.CloseIconButton_Click);
            // 
            // MaximizaIconButton
            // 
            this.MaximizaIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizaIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MaximizaIconButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MaximizaIconButton.FlatAppearance.BorderSize = 0;
            this.MaximizaIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizaIconButton.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.MaximizaIconButton.IconColor = System.Drawing.Color.White;
            this.MaximizaIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizaIconButton.IconSize = 35;
            this.MaximizaIconButton.Location = new System.Drawing.Point(770, 0);
            this.MaximizaIconButton.Name = "MaximizaIconButton";
            this.MaximizaIconButton.Size = new System.Drawing.Size(45, 35);
            this.MaximizaIconButton.TabIndex = 5;
            this.MaximizaIconButton.UseVisualStyleBackColor = false;
            this.MaximizaIconButton.Click += new System.EventHandler(this.MaximizaIconButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(187)))), ((int)(((byte)(215)))));
            this.panel3.Controls.Add(this.TopPanel1);
            this.panel3.Controls.Add(this.MessagesIconButton);
            this.panel3.Controls.Add(this.UserProfile);
            this.panel3.Controls.Add(this.SettingsIconButton);
            this.panel3.Controls.Add(this.LeaveIconButton);
            this.panel3.Controls.Add(this.HomeIconButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 587);
            this.panel3.TabIndex = 1;
            // 
            // TopPanel1
            // 
            this.TopPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.TopPanel1.Location = new System.Drawing.Point(-7, 0);
            this.TopPanel1.Name = "TopPanel1";
            this.TopPanel1.Size = new System.Drawing.Size(133, 39);
            this.TopPanel1.TabIndex = 5;
            this.TopPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel1_MouseDown);
            // 
            // MessagesIconButton
            // 
            this.MessagesIconButton.FlatAppearance.BorderSize = 0;
            this.MessagesIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessagesIconButton.IconChar = FontAwesome.Sharp.IconChar.FacebookMessenger;
            this.MessagesIconButton.IconColor = System.Drawing.Color.White;
            this.MessagesIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MessagesIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MessagesIconButton.Location = new System.Drawing.Point(20, 297);
            this.MessagesIconButton.Name = "MessagesIconButton";
            this.MessagesIconButton.Size = new System.Drawing.Size(60, 40);
            this.MessagesIconButton.TabIndex = 4;
            this.MessagesIconButton.UseVisualStyleBackColor = true;
            // 
            // UserProfile
            // 
            this.UserProfile.FlatAppearance.BorderSize = 0;
            this.UserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserProfile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.UserProfile.IconColor = System.Drawing.Color.White;
            this.UserProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserProfile.Location = new System.Drawing.Point(20, 183);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Size = new System.Drawing.Size(60, 40);
            this.UserProfile.TabIndex = 3;
            this.UserProfile.UseVisualStyleBackColor = true;
            // 
            // SettingsIconButton
            // 
            this.SettingsIconButton.FlatAppearance.BorderSize = 0;
            this.SettingsIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsIconButton.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.SettingsIconButton.IconColor = System.Drawing.Color.White;
            this.SettingsIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsIconButton.Location = new System.Drawing.Point(20, 408);
            this.SettingsIconButton.Name = "SettingsIconButton";
            this.SettingsIconButton.Size = new System.Drawing.Size(60, 40);
            this.SettingsIconButton.TabIndex = 2;
            this.SettingsIconButton.UseVisualStyleBackColor = true;
            // 
            // LeaveIconButton
            // 
            this.LeaveIconButton.FlatAppearance.BorderSize = 0;
            this.LeaveIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveIconButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.LeaveIconButton.IconColor = System.Drawing.Color.White;
            this.LeaveIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LeaveIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeaveIconButton.Location = new System.Drawing.Point(20, 525);
            this.LeaveIconButton.Name = "LeaveIconButton";
            this.LeaveIconButton.Size = new System.Drawing.Size(60, 40);
            this.LeaveIconButton.TabIndex = 1;
            this.LeaveIconButton.UseVisualStyleBackColor = true;
            this.LeaveIconButton.Click += new System.EventHandler(this.LeaveIconButton_Click);
            // 
            // HomeIconButton
            // 
            this.HomeIconButton.FlatAppearance.BorderSize = 0;
            this.HomeIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeIconButton.IconChar = FontAwesome.Sharp.IconChar.House;
            this.HomeIconButton.IconColor = System.Drawing.Color.White;
            this.HomeIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeIconButton.Location = new System.Drawing.Point(20, 75);
            this.HomeIconButton.Name = "HomeIconButton";
            this.HomeIconButton.Size = new System.Drawing.Size(60, 40);
            this.HomeIconButton.TabIndex = 0;
            this.HomeIconButton.Tag = "Home";
            this.HomeIconButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Resize += new System.EventHandler(this.EmployeeForm_Resize);
            this.panel1.ResumeLayout(false);
            this.TopPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton HomeIconButton;
        private FontAwesome.Sharp.IconButton LeaveIconButton;
        private FontAwesome.Sharp.IconButton SettingsIconButton;
        private FontAwesome.Sharp.IconButton UserProfile;
        private FontAwesome.Sharp.IconButton MessagesIconButton;
        private FontAwesome.Sharp.IconButton MinimizeIconButton;
        private FontAwesome.Sharp.IconButton MaximizaIconButton;
        private FontAwesome.Sharp.IconButton CloseIconButton;
        private System.Windows.Forms.Panel TopPanel2;
        private System.Windows.Forms.Panel TopPanel1;
    }
}