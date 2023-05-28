using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SearchWorkApp
{
    public partial class StartForm : Form
    {

        private int borderSize = 3;

        public StartForm()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
            this.AcceptIconButton.IconColor = Color.FromArgb(85, 64, 0);
        }

        // Resize form

        private void StartForm_Resize(object sender, EventArgs e)
        {
            AdjustFormScrollbars();
        }

        private void AdjustFormScrollbars()
        {

            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }

        }

        // Drag form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr intPtr, int wParam1, int wParam2, int wParam3);

        protected override void WndProc(ref Message m)
        {
            const int scaleForm = 0x083;
            if (m.Msg == scaleForm && m.WParam.ToInt32() == 1) return;
            base.WndProc(ref m);
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Button on top

        private void IconExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Mouse cursor on the employee's baner

        private void EmployeePanel_MouseEnter(object sender, EventArgs e)
        {
            var coordinatesPanel = this.EmployeePanel.Location;
            var coordinatesLabel = this.EmployeeLabel.Location;
            if (this.EmployeePanel.Size.Width == 320) return;
            this.EmployeePanel.Location = new Point(coordinatesPanel.X - 10, coordinatesPanel.Y - 10);
            this.EmployeePanel.Size = new Size(320, 420);
            this.EmployeePictureBox.Size = new Size(320, 340);
            this.EmployeeLabel.Location = new Point(coordinatesLabel.X + 10, coordinatesLabel.Y + 20);
        }

        private void EmployeePanel_MouseLeave(object sender, EventArgs e)
        {
            if (employeeClicked == true) return;
            var coordinates = this.EmployeePanel.PointToClient(Cursor.Position);
            var coordinatesPanel = this.EmployeePanel.Location;
            var coordinatesLabel = this.EmployeeLabel.Location;
            if (coordinates.X > 0 && coordinates.X < 320 && coordinates.Y > 0 && coordinates.Y < 420) return;
            this.EmployeePanel.Location = new Point(coordinatesPanel.X + 10, coordinatesPanel.Y + 10);
            this.EmployeePanel.Size = new Size(300, 400);
            this.EmployeePictureBox.Size = new Size(300, 320);
            this.EmployeeLabel.Location = new Point(coordinatesLabel.X - 10, coordinatesLabel.Y - 20);
        }

        private void EmployeePictureBox_MouseEnter(object sender, EventArgs e)
        {
            EmployeePanel_MouseEnter(sender, e);
        }

        private void EmployeePictureBox_MouseLeave(object sender, EventArgs e)
        {
            EmployeePanel_MouseLeave(sender, e);
        }

        // Mouser cursor on the employer's banner

        private void EmployerPanel_MouseEnter(object sender, EventArgs e)
        {
            var coordinatesPanel = this.EmployerPanel.Location;
            var coordinatesLabel=this.EmployerLabel.Location;
            if (this.EmployerPanel.Size.Width == 320) return;
            this.EmployerPanel.Location = new Point(coordinatesPanel.X-10, coordinatesPanel.Y-10);
            this.EmployerPanel.Size = new Size(320, 420);
            this.EmployerPictureBox.Size = new Size(320, 340);
            this.EmployerLabel.Location = new Point(coordinatesLabel.X+10, coordinatesLabel.Y+20);
        }

        private void EmployerPanel_MouseLeave(object sender, EventArgs e)
        {
            if (employerClicked == true) return;
            var coordinates = this.EmployerPanel.PointToClient(Cursor.Position);
            if (coordinates.X > 0 && coordinates.X < 320 && coordinates.Y > 0 && coordinates.Y < 420) return;
            var coordinatesPanel = this.EmployerPanel.Location;
            var coordinatesLabel = this.EmployerLabel.Location;
            this.EmployerPanel.Location = new Point(coordinatesPanel.X+10, coordinatesPanel.Y+10);
            this.EmployerPanel.Size = new Size(300, 400);
            this.EmployerPictureBox.Size = new Size(300, 320);
            this.EmployerLabel.Location = new Point(coordinatesLabel.X-10, coordinatesLabel.Y-20);
        }

        private void EmployerPictureBox_MouseEnter(object sender, EventArgs e)
        {
            EmployerPanel_MouseEnter(sender, e);
        }

        private void EmployerPictureBox_MouseLeave(object sender, EventArgs e)
        {
            EmployerPanel_MouseLeave(sender, e);
        }

        // Employee's banner is clicked

        private bool employeeClicked = false;

        private void EmployeePanel_Click(object sender, EventArgs e)
        {
            if (employerClicked)
            {
                employerClicked = false;
                EmployerPanel_MouseLeave(sender, e);
            }
            employeeClicked = true;
            this.ShadowEffectEmployer.UseShadowEffect = true;
            this.AcceptIconButton.IconColor = Color.White;
            
        }

        private void EmployeePictureBox_Click(object sender, EventArgs e)
        {
            if (employerClicked)
            {
                employerClicked = false;
                EmployerPanel_MouseLeave(sender, e);
            }
            employeeClicked = true;
            this.AcceptIconButton.IconColor = Color.White;
            this.AcceptIconButton.Enabled = true;
        }

        private void EmployeeLabel_Click(object sender, EventArgs e)
        {
            if (employerClicked)
            {
                employerClicked = false;
                EmployerPanel_MouseLeave(sender, e);
            }
            employeeClicked = true;
            this.AcceptIconButton.IconColor = Color.White;
            this.AcceptIconButton.Enabled = true;
        }

        // Employer's banner is clicked

        private bool employerClicked = false;

        private void EmployerPanel_Click(object sender, EventArgs e)
        {
            if (employeeClicked)
            {
                employeeClicked = false;
                EmployeePanel_MouseLeave(sender, e);
            }
            employerClicked = true;

            this.AcceptIconButton.IconColor = Color.White;
            this.AcceptIconButton.Enabled = true;
        }

        private void EmployerPictureBox_Click(object sender, EventArgs e)
        {
            if (employeeClicked)
            {
                employeeClicked = false;
                EmployeePanel_MouseLeave(sender, e);
            }
            employerClicked = true;
            this.AcceptIconButton.IconColor= Color.White;
            this.AcceptIconButton.Enabled = true;
        }

        private void EmployerLabel_Click(object sender, EventArgs e)
        {
            if (employeeClicked)
            {
                employeeClicked = false;
                EmployeePanel_MouseLeave(sender, e);
            }
            employerClicked = true;
            this.AcceptIconButton.IconColor=Color.White;
            this.AcceptIconButton.Enabled = true;
        }

        // Return the start state

        private void MainPanel_Click(object sender, EventArgs e)
        {
            if (employeeClicked)
            {
                employeeClicked = false;
                this.AcceptIconButton.IconColor = Color.FromArgb(85, 64, 0);
                EmployeePanel_MouseLeave(sender, e);
            }

            if (employerClicked)
            {
                employerClicked = false;
                this.AcceptIconButton.IconColor = Color.FromArgb(85, 64, 0);
                EmployerPanel_MouseLeave(sender, e);
            }

            this.AcceptIconButton.Enabled = false;

        }

        private void TopPanel_Click(object sender, EventArgs e)
        {
            MainPanel_Click(sender, e);
        }

        // Accept button to move into another form

        Thread thread;

        private void OpenEmployeeForm()
        {
            Application.Run(new EmployeeForm());
        }

        private void OpenEmployerForm()
        {
            Application.Run(new EmployerForm());
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (employeeClicked)
            {
                this.Close();

                thread = new Thread(OpenEmployeeForm);

                thread.SetApartmentState(ApartmentState.STA);

                thread.Start();

            }
            if (employerClicked)
            {
                this.Close();

                thread = new Thread(OpenEmployerForm);

                thread.SetApartmentState(ApartmentState.STA);

                thread.Start();

            }
        }

    }
}