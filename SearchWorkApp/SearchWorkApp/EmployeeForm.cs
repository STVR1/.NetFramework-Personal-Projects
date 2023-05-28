using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SearchWorkApp
{
    public partial class EmployeeForm : Form
    {

        private int borderSize = 3;

        public EmployeeForm()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
        }

        // Resize form

        private void EmployeeForm_Resize(object sender, EventArgs e)
        {
            AdjustFormScrollbars();
        }

        private void AdjustFormScrollbars()
        {
            switch(WindowState)
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

        // Remove general border

        protected override void WndProc(ref Message m)
        {
            const int scaleForm = 0x083;
            if (m.Msg == scaleForm && m.WParam.ToInt32() == 1) return;
            base.WndProc(ref m);
        }

        // Drag form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(IntPtr intPtr, int param1, int param2, int param3);

        private void TopPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TopPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Top right iconbuttons

        private void MinimizeIconButton_Click(object sender, EventArgs e)
        {
            if(this.WindowState== FormWindowState.Minimized) return;
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizaIconButton_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
                this.WindowState= FormWindowState.Normal;
            else 
                this.WindowState=FormWindowState.Maximized;
        }

        private Thread thread;

        private void ReturnStartForm()
        {
            Application.Run(new StartForm());
        }

        private void CloseIconButton_Click(object sender, EventArgs e)
        {

            this.Close();

            thread = new Thread(ReturnStartForm);
            thread.SetApartmentState(ApartmentState.STA);
           
            thread.Start();

        }

        // Left side iconbuttons

        private void LeaveIconButton_Click(object sender, EventArgs e)
        {
            this.Close();

            thread = new Thread(ReturnStartForm);

            thread.SetApartmentState (ApartmentState.STA);

            thread.Start();

        }

        
    }
}