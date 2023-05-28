namespace SearchWorkApp
{
    partial class EmployerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopPanel2 = new System.Windows.Forms.Panel();
            this.MinimizeIconButton = new FontAwesome.Sharp.IconButton();
            this.CloseIconButton = new FontAwesome.Sharp.IconButton();
            this.MaximizaIconButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MessagesIconButton = new FontAwesome.Sharp.IconButton();
            this.UserProfile = new FontAwesome.Sharp.IconButton();
            this.SettingsIconButton = new FontAwesome.Sharp.IconButton();
            this.LeaveIconButton = new FontAwesome.Sharp.IconButton();
            this.HomeIconButton = new FontAwesome.Sharp.IconButton();
            this.TopPanel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.TopPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.TopPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 603);
            this.panel1.TabIndex = 0;
            // 
            // TopPanel2
            // 
            this.TopPanel2.Controls.Add(this.MinimizeIconButton);
            this.TopPanel2.Controls.Add(this.CloseIconButton);
            this.TopPanel2.Controls.Add(this.MaximizaIconButton);
            this.TopPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel2.Location = new System.Drawing.Point(144, 0);
            this.TopPanel2.Name = "TopPanel2";
            this.TopPanel2.Size = new System.Drawing.Size(841, 40);
            this.TopPanel2.TabIndex = 1;
            this.TopPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel2_MouseDown);
            // 
            // MinimizeIconButton
            // 
            this.MinimizeIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeIconButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MinimizeIconButton.FlatAppearance.BorderSize = 0;
            this.MinimizeIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeIconButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.MinimizeIconButton.IconColor = System.Drawing.Color.White;
            this.MinimizeIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeIconButton.IconSize = 35;
            this.MinimizeIconButton.Location = new System.Drawing.Point(706, 0);
            this.MinimizeIconButton.Name = "MinimizeIconButton";
            this.MinimizeIconButton.Size = new System.Drawing.Size(45, 35);
            this.MinimizeIconButton.TabIndex = 9;
            this.MinimizeIconButton.UseVisualStyleBackColor = false;
            this.MinimizeIconButton.Click += new System.EventHandler(this.MinimizeIconButton_Click);
            // 
            // CloseIconButton
            // 
            this.CloseIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseIconButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseIconButton.FlatAppearance.BorderSize = 0;
            this.CloseIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseIconButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.CloseIconButton.IconColor = System.Drawing.Color.White;
            this.CloseIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseIconButton.IconSize = 35;
            this.CloseIconButton.Location = new System.Drawing.Point(796, 0);
            this.CloseIconButton.Name = "CloseIconButton";
            this.CloseIconButton.Size = new System.Drawing.Size(45, 35);
            this.CloseIconButton.TabIndex = 7;
            this.CloseIconButton.UseVisualStyleBackColor = false;
            this.CloseIconButton.Click += new System.EventHandler(this.CloseIconButton_Click);
            // 
            // MaximizaIconButton
            // 
            this.MaximizaIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizaIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximizaIconButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MaximizaIconButton.FlatAppearance.BorderSize = 0;
            this.MaximizaIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizaIconButton.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.MaximizaIconButton.IconColor = System.Drawing.Color.White;
            this.MaximizaIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizaIconButton.IconSize = 35;
            this.MaximizaIconButton.Location = new System.Drawing.Point(751, 0);
            this.MaximizaIconButton.Name = "MaximizaIconButton";
            this.MaximizaIconButton.Size = new System.Drawing.Size(45, 35);
            this.MaximizaIconButton.TabIndex = 8;
            this.MaximizaIconButton.UseVisualStyleBackColor = false;
            this.MaximizaIconButton.Click += new System.EventHandler(this.MaximizaIconButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.MessagesIconButton);
            this.panel2.Controls.Add(this.UserProfile);
            this.panel2.Controls.Add(this.SettingsIconButton);
            this.panel2.Controls.Add(this.LeaveIconButton);
            this.panel2.Controls.Add(this.HomeIconButton);
            this.panel2.Controls.Add(this.TopPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 603);
            this.panel2.TabIndex = 0;
            // 
            // MessagesIconButton
            // 
            this.MessagesIconButton.FlatAppearance.BorderSize = 0;
            this.MessagesIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessagesIconButton.IconChar = FontAwesome.Sharp.IconChar.FacebookMessenger;
            this.MessagesIconButton.IconColor = System.Drawing.Color.White;
            this.MessagesIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MessagesIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MessagesIconButton.Location = new System.Drawing.Point(38, 290);
            this.MessagesIconButton.Name = "MessagesIconButton";
            this.MessagesIconButton.Size = new System.Drawing.Size(60, 40);
            this.MessagesIconButton.TabIndex = 9;
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
            this.UserProfile.Location = new System.Drawing.Point(38, 176);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Size = new System.Drawing.Size(60, 40);
            this.UserProfile.TabIndex = 8;
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
            this.SettingsIconButton.Location = new System.Drawing.Point(38, 401);
            this.SettingsIconButton.Name = "SettingsIconButton";
            this.SettingsIconButton.Size = new System.Drawing.Size(60, 40);
            this.SettingsIconButton.TabIndex = 7;
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
            this.LeaveIconButton.Location = new System.Drawing.Point(38, 518);
            this.LeaveIconButton.Name = "LeaveIconButton";
            this.LeaveIconButton.Size = new System.Drawing.Size(60, 40);
            this.LeaveIconButton.TabIndex = 6;
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
            this.HomeIconButton.Location = new System.Drawing.Point(38, 68);
            this.HomeIconButton.Name = "HomeIconButton";
            this.HomeIconButton.Size = new System.Drawing.Size(60, 40);
            this.HomeIconButton.TabIndex = 5;
            this.HomeIconButton.Tag = "Home";
            this.HomeIconButton.UseVisualStyleBackColor = true;
            // 
            // TopPanel1
            // 
            this.TopPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(28)))));
            this.TopPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel1.Location = new System.Drawing.Point(0, 0);
            this.TopPanel1.Name = "TopPanel1";
            this.TopPanel1.Size = new System.Drawing.Size(144, 40);
            this.TopPanel1.TabIndex = 1;
            this.TopPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel1_MouseDown);
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 603);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployerForm";
            this.Text = "EmployerGUI";
            this.Resize += new System.EventHandler(this.EmployerForm_Resize);
            this.panel1.ResumeLayout(false);
            this.TopPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TopPanel1;
        private System.Windows.Forms.Panel TopPanel2;
        private FontAwesome.Sharp.IconButton MinimizeIconButton;
        private FontAwesome.Sharp.IconButton CloseIconButton;
        private FontAwesome.Sharp.IconButton MaximizaIconButton;
        private FontAwesome.Sharp.IconButton MessagesIconButton;
        private FontAwesome.Sharp.IconButton UserProfile;
        private FontAwesome.Sharp.IconButton SettingsIconButton;
        private FontAwesome.Sharp.IconButton LeaveIconButton;
        private FontAwesome.Sharp.IconButton HomeIconButton;
    }
}