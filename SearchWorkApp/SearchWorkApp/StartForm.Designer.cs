
namespace SearchWorkApp
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.IconExitButton = new FontAwesome.Sharp.IconButton();
            this.IconMinimizeButton = new FontAwesome.Sharp.IconButton();
            this.AcceptIconButton = new FontAwesome.Sharp.IconButton();
            this.EmployerPanel = new System.Windows.Forms.Panel();
            this.EmployerLabel = new System.Windows.Forms.Label();
            this.EmployerPictureBox = new System.Windows.Forms.PictureBox();
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeePictureBox = new System.Windows.Forms.PictureBox();
            this.ShadowEffectEmployee = new CodeeloUI.Components.CodeeloShadowEffect(this.components);
            this.ShadowEffectEmployer = new CodeeloUI.Components.CodeeloShadowEffect(this.components);
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.EmployerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerPictureBox)).BeginInit();
            this.EmployeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.AcceptIconButton);
            this.MainPanel.Controls.Add(this.EmployerPanel);
            this.MainPanel.Controls.Add(this.EmployeePanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(987, 609);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Click += new System.EventHandler(this.MainPanel_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.IconExitButton);
            this.TopPanel.Controls.Add(this.IconMinimizeButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(987, 35);
            this.TopPanel.TabIndex = 6;
            this.TopPanel.Click += new System.EventHandler(this.TopPanel_Click);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // IconExitButton
            // 
            this.IconExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.IconExitButton.FlatAppearance.BorderSize = 0;
            this.IconExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconExitButton.ForeColor = System.Drawing.Color.White;
            this.IconExitButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.IconExitButton.IconColor = System.Drawing.Color.White;
            this.IconExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconExitButton.IconSize = 30;
            this.IconExitButton.Location = new System.Drawing.Point(941, 0);
            this.IconExitButton.Name = "IconExitButton";
            this.IconExitButton.Size = new System.Drawing.Size(46, 36);
            this.IconExitButton.TabIndex = 3;
            this.IconExitButton.UseVisualStyleBackColor = false;
            this.IconExitButton.Click += new System.EventHandler(this.IconExitButton_Click);
            // 
            // IconMinimizeButton
            // 
            this.IconMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.IconMinimizeButton.FlatAppearance.BorderSize = 0;
            this.IconMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconMinimizeButton.ForeColor = System.Drawing.Color.White;
            this.IconMinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.IconMinimizeButton.IconColor = System.Drawing.Color.White;
            this.IconMinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMinimizeButton.IconSize = 30;
            this.IconMinimizeButton.Location = new System.Drawing.Point(898, 0);
            this.IconMinimizeButton.Name = "IconMinimizeButton";
            this.IconMinimizeButton.Size = new System.Drawing.Size(43, 36);
            this.IconMinimizeButton.TabIndex = 5;
            this.IconMinimizeButton.UseVisualStyleBackColor = false;
            this.IconMinimizeButton.Click += new System.EventHandler(this.IconMinimizeButton_Click);
            // 
            // AcceptIconButton
            // 
            this.AcceptIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.AcceptIconButton.Enabled = false;
            this.AcceptIconButton.FlatAppearance.BorderSize = 0;
            this.AcceptIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptIconButton.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptIconButton.ForeColor = System.Drawing.Color.White;
            this.AcceptIconButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.AcceptIconButton.IconColor = System.Drawing.Color.White;
            this.AcceptIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AcceptIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AcceptIconButton.Location = new System.Drawing.Point(445, 560);
            this.AcceptIconButton.Name = "AcceptIconButton";
            this.AcceptIconButton.Size = new System.Drawing.Size(165, 50);
            this.AcceptIconButton.TabIndex = 2;
            this.AcceptIconButton.Text = "      Accept";
            this.AcceptIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AcceptIconButton.UseVisualStyleBackColor = false;
            this.AcceptIconButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // EmployerPanel
            // 
            this.EmployerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            this.EmployerPanel.Controls.Add(this.EmployerLabel);
            this.EmployerPanel.Controls.Add(this.EmployerPictureBox);
            this.EmployerPanel.Location = new System.Drawing.Point(550, 100);
            this.EmployerPanel.Name = "EmployerPanel";
            this.EmployerPanel.Size = new System.Drawing.Size(300, 400);
            this.EmployerPanel.TabIndex = 1;
            this.EmployerPanel.Click += new System.EventHandler(this.EmployerPanel_Click);
            this.EmployerPanel.MouseEnter += new System.EventHandler(this.EmployerPanel_MouseEnter);
            this.EmployerPanel.MouseLeave += new System.EventHandler(this.EmployerPanel_MouseLeave);
            // 
            // EmployerLabel
            // 
            this.EmployerLabel.AutoSize = true;
            this.EmployerLabel.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployerLabel.ForeColor = System.Drawing.Color.White;
            this.EmployerLabel.Location = new System.Drawing.Point(50, 330);
            this.EmployerLabel.Name = "EmployerLabel";
            this.EmployerLabel.Size = new System.Drawing.Size(215, 45);
            this.EmployerLabel.TabIndex = 1;
            this.EmployerLabel.Text = "Employer";
            this.EmployerLabel.Click += new System.EventHandler(this.EmployerLabel_Click);
            // 
            // EmployerPictureBox
            // 
            this.EmployerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EmployerPictureBox.Image")));
            this.EmployerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.EmployerPictureBox.Name = "EmployerPictureBox";
            this.EmployerPictureBox.Size = new System.Drawing.Size(300, 320);
            this.EmployerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployerPictureBox.TabIndex = 0;
            this.EmployerPictureBox.TabStop = false;
            this.EmployerPictureBox.Click += new System.EventHandler(this.EmployerPictureBox_Click);
            this.EmployerPictureBox.MouseEnter += new System.EventHandler(this.EmployerPictureBox_MouseEnter);
            this.EmployerPictureBox.MouseLeave += new System.EventHandler(this.EmployerPictureBox_MouseLeave);
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            this.EmployeePanel.Controls.Add(this.EmployeeLabel);
            this.EmployeePanel.Controls.Add(this.EmployeePictureBox);
            this.EmployeePanel.Location = new System.Drawing.Point(200, 100);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(300, 400);
            this.EmployeePanel.TabIndex = 0;
            this.EmployeePanel.Click += new System.EventHandler(this.EmployeePanel_Click);
            this.EmployeePanel.MouseEnter += new System.EventHandler(this.EmployeePanel_MouseEnter);
            this.EmployeePanel.MouseLeave += new System.EventHandler(this.EmployeePanel_MouseLeave);
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeLabel.ForeColor = System.Drawing.Color.White;
            this.EmployeeLabel.Location = new System.Drawing.Point(50, 330);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(222, 45);
            this.EmployeeLabel.TabIndex = 1;
            this.EmployeeLabel.Text = "Employee";
            this.EmployeeLabel.Click += new System.EventHandler(this.EmployeeLabel_Click);
            // 
            // EmployeePictureBox
            // 
            this.EmployeePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EmployeePictureBox.Image")));
            this.EmployeePictureBox.Location = new System.Drawing.Point(0, 0);
            this.EmployeePictureBox.Name = "EmployeePictureBox";
            this.EmployeePictureBox.Size = new System.Drawing.Size(300, 320);
            this.EmployeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeePictureBox.TabIndex = 0;
            this.EmployeePictureBox.TabStop = false;
            this.EmployeePictureBox.Click += new System.EventHandler(this.EmployeePictureBox_Click);
            this.EmployeePictureBox.MouseEnter += new System.EventHandler(this.EmployeePictureBox_MouseEnter);
            this.EmployeePictureBox.MouseLeave += new System.EventHandler(this.EmployeePictureBox_MouseLeave);
            // 
            // ShadowEffectEmployee
            // 
            this.ShadowEffectEmployee.BorderRadius = 6;
            this.ShadowEffectEmployee.Color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ShadowEffectEmployee.Depth = 30;
            this.ShadowEffectEmployee.ShadowPadding = new System.Windows.Forms.Padding(20, 20, 105, 130);
            this.ShadowEffectEmployee.SourceControl = this.EmployeePanel;
            this.ShadowEffectEmployee.UseShadowEffect = true;
            // 
            // ShadowEffectEmployer
            // 
            this.ShadowEffectEmployer.BorderRadius = 6;
            this.ShadowEffectEmployer.Color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ShadowEffectEmployer.Depth = 30;
            this.ShadowEffectEmployer.ShadowPadding = new System.Windows.Forms.Padding(20, 20, 105, 130);
            this.ShadowEffectEmployer.SourceControl = this.EmployerPanel;
            this.ShadowEffectEmployer.UseShadowEffect = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 609);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.StartForm_Resize);
            this.MainPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.EmployerPanel.ResumeLayout(false);
            this.EmployerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerPictureBox)).EndInit();
            this.EmployeePanel.ResumeLayout(false);
            this.EmployeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private FontAwesome.Sharp.IconButton AcceptIconButton;
        private System.Windows.Forms.Panel EmployerPanel;
        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.PictureBox EmployerPictureBox;
        private System.Windows.Forms.PictureBox EmployeePictureBox;
        private System.Windows.Forms.Label EmployerLabel;
        private System.Windows.Forms.Label EmployeeLabel;
        private FontAwesome.Sharp.IconButton IconExitButton;
        private FontAwesome.Sharp.IconButton IconMinimizeButton;
        private System.Windows.Forms.Panel TopPanel;
        private CodeeloUI.Components.CodeeloShadowEffect ShadowEffectEmployee;
        private CodeeloUI.Components.CodeeloShadowEffect ShadowEffectEmployer;
    }
}