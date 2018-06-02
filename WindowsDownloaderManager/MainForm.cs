using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace WindowsDownloaderManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Variables
        //public
        //private
        int xForm, yForm, xMouse, yMouse;
        double pbUnit;
        int pbWIDTH, pbHEIGHT, pbComplete;
        Bitmap bitmap;
        Graphics graphics;
        System.Net.WebClient webClient = new System.Net.WebClient();

        //Method Code

        private void Mouse_Down()
        {
            //Get position Form and Mouse
            xForm = this.Location.X;
            yForm = this.Location.Y;
            xMouse = MousePosition.X;
            yMouse = MousePosition.Y;
        }

        private void Mouse_Move(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xMouse2 = MousePosition.X;
                int yMouse2 = MousePosition.Y;

                this.Location = new Point(xForm + (xMouse2 - xMouse), yForm + (yMouse2 - yMouse));
            }
        }

        private void ExitMethod(bool ExitQ)
        {
            if (ExitQ)
            {
                DialogResult exitRes = MessageBox.Show("Are you can close this programm?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (exitRes)
                {
                    case DialogResult.Yes:
                        {
                            try
                            {
                                Environment.Exit(0);
                            }
                            catch (Exception ex)
                            {
                                Application.Exit();
                            }
                        }break;

                    case DialogResult.No:
                        {

                        }break;
                }
            }
            else
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
        }

        private void HandleLbl_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            //ExitMethod(true);
            MessageForm messageForm = new MessageForm();
            messageForm.Text = "Exit";
            messageForm.HandleLabel.Text = "Exit";
            messageForm.TextLabel.Text = "Are you can close this programm?";
            messageForm.CloseBool = true;
            messageForm.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //ExitMethod(true);
        }

        private void ExitLbl_MouseEnter(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.FromArgb(37, 41, 42);
        }

        private void MiniLbl_MouseEnter(object sender, EventArgs e)
        {
            MiniBtn.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void MiniBtn_MouseEnter(object sender, EventArgs e)
        {
            MiniBtn.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void MiniBtn_MouseLeave(object sender, EventArgs e)
        {
            MiniBtn.BackColor = Color.FromArgb(37, 41, 42);
        }

        private void MiniLbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DownLoadButtom_MouseEnter(object sender, EventArgs e)
        {
            DownLoadButtom.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void DownLoadButtom_MouseLeave(object sender, EventArgs e)
        {
            DownLoadButtom.BackColor = Color.FromArgb(37, 41, 42);
        }

        private void FolderButton_MouseEnter(object sender, EventArgs e)
        {
            FolderButton.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void FolderButton_MouseLeave(object sender, EventArgs e)
        {
            FolderButton.BackColor = Color.FromArgb(61, 63, 65);
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            if (filenameTextBox.Text != "" || fileextensionTextBox.Text != "")
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    folderTextBox.Text = folderBrowserDialog.SelectedPath + @"\" + filenameTextBox.Text + "." + fileextensionTextBox.Text;
                }
            }
            else
            {
                MessageBox.Show("Please, enter File Name or File Extension and try again!", "Select Folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void startdwButton_Click(object sender, EventArgs e)
        {
            if (folderTextBox.Text != "" && urlTextBox.Text != "")
            {
                startdwButton.Enabled = false;

                string url = @"" + urlTextBox.Text;
                string filepath = @"" + folderTextBox.Text;
                Uri uri = new Uri(url);

                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownLoadCompleted);
                webClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(ProgressChanged);

                pbWIDTH = CastomProgressBar.Width;
                pbHEIGHT = CastomProgressBar.Height;
                pbUnit = pbWIDTH / 100.0;
                pbComplete = 0;
                bitmap = new Bitmap(pbWIDTH, pbHEIGHT);
                graphics = Graphics.FromImage(bitmap);
                graphics.Clear(Color.FromArgb(101, 144, 188));

                if (ProxyTextBox.Text != "")
                {
                    WebProxy webProxy = new WebProxy();
                    Uri proxyUri = new Uri(ProxyTextBox.Text);
                    webProxy.Address = proxyUri;
                    if (UserNameTextBox.Text != "" && UserNameTextBox.Text != "")
                    {
                        webProxy.Credentials = new NetworkCredential(UserNameTextBox.Text, PasswordTextBox.Text);
                    }
                    webClient.Proxy = webProxy;
                    await webClient.DownloadFileTaskAsync(url, filepath);
                }
                else
                {
                    await webClient.DownloadFileTaskAsync(url, filepath);
                }
            }
            else
            {
                MessageForm messageForm = new MessageForm();
                messageForm.HandleLabel.Text = "Download";
                messageForm.Text = "Download";
                messageForm.TextLabel.Text = "Please, enter url or select folder!";
                messageForm.ShowDialog();
                //MessageBox.Show("Please, enter url or select folder!", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.FromArgb(37, 41, 42);
        }

        private void DownLoadButtom_Click(object sender, EventArgs e)
        {
            ContentDownLoad.Size = new Size(452, 305);
            ContentDownLoad.Location = new Point(193, 7);
            ContentDownLoad.Visible = true;
            ContentSettings.Visible = false;
            AboutContent.Visible = false;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ContentSettings.Size = new Size(452, 305);
            ContentSettings.Location = new Point(193, 7);
            ContentSettings.Visible = true;
            ContentDownLoad.Visible = false;
            AboutContent.Visible = false;
        }

        private void ExitLbl_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.FromArgb(37, 41, 42);
        }

        private void MiniLbl_MouseLeave(object sender, EventArgs e)
        {
            MiniBtn.BackColor = Color.FromArgb(37, 41, 42);
        }

        private void xCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageForm messageForm = new MessageForm();
            messageForm.Text = "Exit";
            messageForm.HandleLabel.Text = "Exit";
            messageForm.TextLabel.Text = "Are you can close this programm?";
            messageForm.CloseBool = true;
            messageForm.ShowDialog();
        }

        private void minimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //CompletedLabel.BackColor = Color.FromArgb(61, 63, 65, 255);
        }

        private void AboutButtom_MouseEnter(object sender, EventArgs e)
        {
            AboutButtom.BackColor = Color.FromArgb(51, 55, 56);
        }

        private void AboutButtom_MouseLeave(object sender, EventArgs e)
        {
            AboutButtom.BackColor = Color.FromArgb(37, 41, 42);
        }

        private void AboutButtom_Click(object sender, EventArgs e)
        {
            ContentSettings.Size = new Size(452, 305);
            ContentSettings.Location = new Point(193, 7);
            ContentSettings.Visible = false;
            ContentDownLoad.Visible = false;
            AboutContent.Visible = true;
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            graphics.FillRectangle(Brushes.CornflowerBlue, new Rectangle(0,0, (int)(pbComplete*pbUnit), pbHEIGHT));
            //graphics.DrawString(pbComplete + "%", new Font("Segoe UI", pbHEIGHT / 3), Brushes.White, new PointF(pbWIDTH / 2 - pbHEIGHT, pbHEIGHT/10));
            CastomProgressBar.Image = bitmap;
            pbComplete = e.ProgressPercentage;
            CompletedLabel.Text = Convert.ToString(pbComplete) + "%";
        }

        private void DownLoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                
            }
            else
            {
                MessageBox.Show("Done!", "DownLoad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                startdwButton.Enabled = true;
            }
        }

        private void HandleLbl_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down();
        }

        private void HandlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void HandlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down();
        }
    }
}
