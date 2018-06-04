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

namespace WindowsDownloaderManager
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        //DLL
        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string pszSound, UIntPtr hmod, uint fdwSound);

        //Variables
        //public
        public bool CloseBool = false;
        //private
        int xForm, yForm, xMouse, yMouse;

        private void HandleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xMouse2 = MousePosition.X;
                int yMouse2 = MousePosition.Y;

                this.Location = new Point(xForm + (xMouse2 - xMouse), yForm + (yMouse2 - yMouse));
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            if (CloseBool)
            {
                ButtonYes.Visible = true;
                ButtonNo.Visible = true;
            }
            else
            {
                ButtonYes.Visible = false;
                ButtonNo.Visible = false;
                TextLabel.Dock = DockStyle.Fill;
            }
            bool result = PlaySound(@"%SystemRoot%\media\town.wav", UIntPtr.Zero, 1);
        }

        private void ButtonYes_MouseEnter(object sender, EventArgs e)
        {
            ButtonYes.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void ButtonNo_MouseEnter(object sender, EventArgs e)
        {
            ButtonNo.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void ButtonNo_MouseLeave(object sender, EventArgs e)
        {
            ButtonNo.BackColor = Color.FromArgb(112, 130, 132);
        }

        private void ButtonYes_MouseLeave(object sender, EventArgs e)
        {
            ButtonYes.BackColor = Color.FromArgb(112, 130, 132);
        }

        private void ButtonYes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ButtonYes.BackColor = Color.FromArgb(52, 62, 64);
        }

        private void ButtonNo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ButtonNo.BackColor = Color.FromArgb(52, 62, 64);
        }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CloseButton.BackColor = Color.FromArgb(52, 62, 64);
        }

        private void HandleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            //Get position Form and Mouse
            xForm = this.Location.X;
            yForm = this.Location.Y;
            xMouse = MousePosition.X;
            yMouse = MousePosition.Y;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(37, 41, 42);
        }
    }
}
