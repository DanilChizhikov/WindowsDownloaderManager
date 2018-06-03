namespace WindowsDownloaderManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HandlePanel = new System.Windows.Forms.Panel();
            this.IconImg = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.minimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiniBtn = new System.Windows.Forms.Panel();
            this.MiniLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Panel();
            this.ExitLbl = new System.Windows.Forms.Label();
            this.HandleLbl = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.AboutButtom = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Label();
            this.DownLoadButtom = new System.Windows.Forms.Label();
            this.ContentDownLoad = new System.Windows.Forms.Panel();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.CastomProgressBar = new System.Windows.Forms.PictureBox();
            this.startdwButton = new System.Windows.Forms.Button();
            this.FolderButton = new System.Windows.Forms.Label();
            this.fileextensionTextBox = new System.Windows.Forms.TextBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.URL_Label = new System.Windows.Forms.Label();
            this.ContentSettings = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ProxyTextBox = new System.Windows.Forms.TextBox();
            this.ProxyLabel = new System.Windows.Forms.Label();
            this.LoadLabel = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.LoadImg = new System.Windows.Forms.PictureBox();
            this.AboutContent = new System.Windows.Forms.Panel();
            this.InfLabel = new System.Windows.Forms.Label();
            this.LogoImg = new System.Windows.Forms.PictureBox();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.HandlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconImg)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.MiniBtn.SuspendLayout();
            this.ExitBtn.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.ContentDownLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CastomProgressBar)).BeginInit();
            this.ContentSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadImg)).BeginInit();
            this.AboutContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // HandlePanel
            // 
            this.HandlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.HandlePanel.Controls.Add(this.IconImg);
            this.HandlePanel.Controls.Add(this.MiniBtn);
            this.HandlePanel.Controls.Add(this.ExitBtn);
            this.HandlePanel.Controls.Add(this.HandleLbl);
            this.HandlePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HandlePanel.Location = new System.Drawing.Point(0, 317);
            this.HandlePanel.Name = "HandlePanel";
            this.HandlePanel.Size = new System.Drawing.Size(656, 36);
            this.HandlePanel.TabIndex = 0;
            this.HandlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandlePanel_MouseDown);
            this.HandlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandlePanel_MouseMove);
            // 
            // IconImg
            // 
            this.IconImg.ContextMenuStrip = this.contextMenu;
            this.IconImg.Image = global::WindowsDownloaderManager.Properties.Resources.iconDownload;
            this.IconImg.Location = new System.Drawing.Point(0, 0);
            this.IconImg.Name = "IconImg";
            this.IconImg.Size = new System.Drawing.Size(36, 36);
            this.IconImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconImg.TabIndex = 3;
            this.IconImg.TabStop = false;
            // 
            // contextMenu
            // 
            this.contextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizedToolStripMenuItem,
            this.xCloseToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenu.Size = new System.Drawing.Size(131, 48);
            // 
            // minimizedToolStripMenuItem
            // 
            this.minimizedToolStripMenuItem.Name = "minimizedToolStripMenuItem";
            this.minimizedToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.minimizedToolStripMenuItem.Text = "Minimized";
            this.minimizedToolStripMenuItem.Click += new System.EventHandler(this.minimizedToolStripMenuItem_Click);
            // 
            // xCloseToolStripMenuItem
            // 
            this.xCloseToolStripMenuItem.Name = "xCloseToolStripMenuItem";
            this.xCloseToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.xCloseToolStripMenuItem.Text = "Close";
            this.xCloseToolStripMenuItem.Click += new System.EventHandler(this.xCloseToolStripMenuItem_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.Controls.Add(this.MiniLbl);
            this.MiniBtn.Location = new System.Drawing.Point(583, 0);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.Size = new System.Drawing.Size(36, 36);
            this.MiniBtn.TabIndex = 2;
            this.Tip.SetToolTip(this.MiniBtn, "Close");
            this.MiniBtn.MouseEnter += new System.EventHandler(this.MiniBtn_MouseEnter);
            this.MiniBtn.MouseLeave += new System.EventHandler(this.MiniBtn_MouseLeave);
            // 
            // MiniLbl
            // 
            this.MiniLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiniLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MiniLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.MiniLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MiniLbl.Location = new System.Drawing.Point(0, 0);
            this.MiniLbl.Name = "MiniLbl";
            this.MiniLbl.Size = new System.Drawing.Size(36, 36);
            this.MiniLbl.TabIndex = 0;
            this.MiniLbl.Text = "_";
            this.MiniLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tip.SetToolTip(this.MiniLbl, "Minimized");
            this.MiniLbl.Click += new System.EventHandler(this.MiniLbl_Click);
            this.MiniLbl.MouseEnter += new System.EventHandler(this.MiniLbl_MouseEnter);
            this.MiniLbl.MouseLeave += new System.EventHandler(this.MiniLbl_MouseLeave);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.ExitBtn.Controls.Add(this.ExitLbl);
            this.ExitBtn.Location = new System.Drawing.Point(620, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(36, 36);
            this.ExitBtn.TabIndex = 1;
            this.Tip.SetToolTip(this.ExitBtn, "Close");
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // ExitLbl
            // 
            this.ExitLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ExitLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ExitLbl.Location = new System.Drawing.Point(0, 0);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(36, 36);
            this.ExitLbl.TabIndex = 0;
            this.ExitLbl.Text = "X";
            this.ExitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tip.SetToolTip(this.ExitLbl, "Close");
            this.ExitLbl.Click += new System.EventHandler(this.ExitLbl_Click);
            this.ExitLbl.MouseEnter += new System.EventHandler(this.ExitLbl_MouseEnter);
            this.ExitLbl.MouseLeave += new System.EventHandler(this.ExitLbl_MouseLeave);
            // 
            // HandleLbl
            // 
            this.HandleLbl.AutoSize = true;
            this.HandleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.HandleLbl.Location = new System.Drawing.Point(220, 8);
            this.HandleLbl.Name = "HandleLbl";
            this.HandleLbl.Size = new System.Drawing.Size(202, 19);
            this.HandleLbl.TabIndex = 0;
            this.HandleLbl.Text = "Windows Downloader Manager";
            this.HandleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleLbl_MouseDown);
            this.HandleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandleLbl_MouseMove);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.MenuPanel.Controls.Add(this.AboutButtom);
            this.MenuPanel.Controls.Add(this.settingsButton);
            this.MenuPanel.Controls.Add(this.DownLoadButtom);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(186, 317);
            this.MenuPanel.TabIndex = 1;
            // 
            // AboutButtom
            // 
            this.AboutButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButtom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.AboutButtom.Location = new System.Drawing.Point(0, 105);
            this.AboutButtom.Name = "AboutButtom";
            this.AboutButtom.Size = new System.Drawing.Size(186, 31);
            this.AboutButtom.TabIndex = 0;
            this.AboutButtom.Text = "About";
            this.AboutButtom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutButtom.Click += new System.EventHandler(this.AboutButtom_Click);
            this.AboutButtom.MouseEnter += new System.EventHandler(this.AboutButtom_MouseEnter);
            this.AboutButtom.MouseLeave += new System.EventHandler(this.AboutButtom_MouseLeave);
            // 
            // settingsButton
            // 
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.settingsButton.Location = new System.Drawing.Point(0, 56);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(186, 31);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tip.SetToolTip(this.settingsButton, "Settings page");
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.settingsButton_MouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.settingsButton_MouseLeave);
            // 
            // DownLoadButtom
            // 
            this.DownLoadButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownLoadButtom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.DownLoadButtom.Location = new System.Drawing.Point(0, 9);
            this.DownLoadButtom.Name = "DownLoadButtom";
            this.DownLoadButtom.Size = new System.Drawing.Size(186, 31);
            this.DownLoadButtom.TabIndex = 0;
            this.DownLoadButtom.Text = "DownLoad";
            this.DownLoadButtom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tip.SetToolTip(this.DownLoadButtom, "Download page");
            this.DownLoadButtom.Click += new System.EventHandler(this.DownLoadButtom_Click);
            this.DownLoadButtom.MouseEnter += new System.EventHandler(this.DownLoadButtom_MouseEnter);
            this.DownLoadButtom.MouseLeave += new System.EventHandler(this.DownLoadButtom_MouseLeave);
            // 
            // ContentDownLoad
            // 
            this.ContentDownLoad.Controls.Add(this.CompletedLabel);
            this.ContentDownLoad.Controls.Add(this.CastomProgressBar);
            this.ContentDownLoad.Controls.Add(this.startdwButton);
            this.ContentDownLoad.Controls.Add(this.FolderButton);
            this.ContentDownLoad.Controls.Add(this.fileextensionTextBox);
            this.ContentDownLoad.Controls.Add(this.filenameTextBox);
            this.ContentDownLoad.Controls.Add(this.folderTextBox);
            this.ContentDownLoad.Controls.Add(this.urlTextBox);
            this.ContentDownLoad.Controls.Add(this.label3);
            this.ContentDownLoad.Controls.Add(this.label2);
            this.ContentDownLoad.Controls.Add(this.label1);
            this.ContentDownLoad.Controls.Add(this.URL_Label);
            this.ContentDownLoad.Location = new System.Drawing.Point(195, 0);
            this.ContentDownLoad.Name = "ContentDownLoad";
            this.ContentDownLoad.Size = new System.Drawing.Size(452, 305);
            this.ContentDownLoad.TabIndex = 2;
            this.ContentDownLoad.Visible = false;
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompletedLabel.Location = new System.Drawing.Point(49, 265);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(231, 32);
            this.CompletedLabel.TabIndex = 5;
            this.CompletedLabel.Text = "0%";
            this.CompletedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CastomProgressBar
            // 
            this.CastomProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(144)))), ((int)(((byte)(188)))));
            this.CastomProgressBar.Location = new System.Drawing.Point(49, 230);
            this.CastomProgressBar.Name = "CastomProgressBar";
            this.CastomProgressBar.Size = new System.Drawing.Size(231, 32);
            this.CastomProgressBar.TabIndex = 4;
            this.CastomProgressBar.TabStop = false;
            // 
            // startdwButton
            // 
            this.startdwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startdwButton.Location = new System.Drawing.Point(286, 230);
            this.startdwButton.Name = "startdwButton";
            this.startdwButton.Size = new System.Drawing.Size(147, 32);
            this.startdwButton.TabIndex = 3;
            this.startdwButton.Text = "Start DownLoad";
            this.startdwButton.UseVisualStyleBackColor = true;
            this.startdwButton.Click += new System.EventHandler(this.startdwButton_Click);
            // 
            // FolderButton
            // 
            this.FolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.FolderButton.Location = new System.Drawing.Point(407, 181);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(26, 25);
            this.FolderButton.TabIndex = 2;
            this.FolderButton.Text = "...";
            this.FolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            this.FolderButton.MouseEnter += new System.EventHandler(this.FolderButton_MouseEnter);
            this.FolderButton.MouseLeave += new System.EventHandler(this.FolderButton_MouseLeave);
            // 
            // fileextensionTextBox
            // 
            this.fileextensionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.fileextensionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileextensionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.fileextensionTextBox.Location = new System.Drawing.Point(145, 139);
            this.fileextensionTextBox.Name = "fileextensionTextBox";
            this.fileextensionTextBox.Size = new System.Drawing.Size(288, 25);
            this.fileextensionTextBox.TabIndex = 1;
            this.fileextensionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.filenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filenameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.filenameTextBox.Location = new System.Drawing.Point(145, 96);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(288, 25);
            this.filenameTextBox.TabIndex = 1;
            this.filenameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // folderTextBox
            // 
            this.folderTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.folderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.folderTextBox.Location = new System.Drawing.Point(145, 181);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(256, 25);
            this.folderTextBox.TabIndex = 1;
            this.folderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // urlTextBox
            // 
            this.urlTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.urlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.urlTextBox.Location = new System.Drawing.Point(145, 53);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(288, 25);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(45, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "File Extension:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "File Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(45, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder:";
            // 
            // URL_Label
            // 
            this.URL_Label.AutoSize = true;
            this.URL_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.URL_Label.Location = new System.Drawing.Point(45, 56);
            this.URL_Label.Name = "URL_Label";
            this.URL_Label.Size = new System.Drawing.Size(37, 19);
            this.URL_Label.TabIndex = 0;
            this.URL_Label.Text = "URL:";
            // 
            // ContentSettings
            // 
            this.ContentSettings.Controls.Add(this.PasswordTextBox);
            this.ContentSettings.Controls.Add(this.PasswordLabel);
            this.ContentSettings.Controls.Add(this.UserNameTextBox);
            this.ContentSettings.Controls.Add(this.UserNameLabel);
            this.ContentSettings.Controls.Add(this.ProxyTextBox);
            this.ContentSettings.Controls.Add(this.ProxyLabel);
            this.ContentSettings.Location = new System.Drawing.Point(237, 243);
            this.ContentSettings.Name = "ContentSettings";
            this.ContentSettings.Size = new System.Drawing.Size(452, 305);
            this.ContentSettings.TabIndex = 2;
            this.ContentSettings.Visible = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(139, 190);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(288, 25);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.PasswordLabel.Location = new System.Drawing.Point(39, 193);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(70, 19);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.UserNameTextBox.Location = new System.Drawing.Point(139, 145);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(288, 25);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.UserNameLabel.Location = new System.Drawing.Point(39, 148);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(80, 19);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User Name:";
            // 
            // ProxyTextBox
            // 
            this.ProxyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ProxyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProxyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ProxyTextBox.Location = new System.Drawing.Point(139, 101);
            this.ProxyTextBox.Name = "ProxyTextBox";
            this.ProxyTextBox.Size = new System.Drawing.Size(288, 25);
            this.ProxyTextBox.TabIndex = 1;
            this.ProxyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProxyLabel
            // 
            this.ProxyLabel.AutoSize = true;
            this.ProxyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ProxyLabel.Location = new System.Drawing.Point(39, 104);
            this.ProxyLabel.Name = "ProxyLabel";
            this.ProxyLabel.Size = new System.Drawing.Size(46, 19);
            this.ProxyLabel.TabIndex = 0;
            this.ProxyLabel.Text = "Proxy:";
            // 
            // LoadLabel
            // 
            this.LoadLabel.AutoSize = true;
            this.LoadLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.LoadLabel.Location = new System.Drawing.Point(317, 224);
            this.LoadLabel.Name = "LoadLabel";
            this.LoadLabel.Size = new System.Drawing.Size(209, 28);
            this.LoadLabel.TabIndex = 4;
            this.LoadLabel.Text = "Please, just select page";
            this.LoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadImg
            // 
            this.LoadImg.Image = global::WindowsDownloaderManager.Properties.Resources.Smile;
            this.LoadImg.Location = new System.Drawing.Point(345, 62);
            this.LoadImg.Name = "LoadImg";
            this.LoadImg.Size = new System.Drawing.Size(150, 150);
            this.LoadImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadImg.TabIndex = 3;
            this.LoadImg.TabStop = false;
            // 
            // AboutContent
            // 
            this.AboutContent.Controls.Add(this.InfLabel);
            this.AboutContent.Controls.Add(this.LogoImg);
            this.AboutContent.Controls.Add(this.AppNameLabel);
            this.AboutContent.Location = new System.Drawing.Point(192, 12);
            this.AboutContent.Name = "AboutContent";
            this.AboutContent.Size = new System.Drawing.Size(452, 305);
            this.AboutContent.TabIndex = 2;
            this.AboutContent.Visible = false;
            // 
            // InfLabel
            // 
            this.InfLabel.Location = new System.Drawing.Point(126, 167);
            this.InfLabel.Name = "InfLabel";
            this.InfLabel.Size = new System.Drawing.Size(224, 73);
            this.InfLabel.TabIndex = 2;
            this.InfLabel.Text = "Coder: Chizhikov Danil\r\nE-mail: chizhikov.danil@inbox.ru\r\nGitHub: github.com/Dani" +
    "lChizhikov";
            this.InfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoImg
            // 
            this.LogoImg.Image = global::WindowsDownloaderManager.Properties.Resources.iconDownload;
            this.LogoImg.Location = new System.Drawing.Point(184, 21);
            this.LogoImg.Name = "LogoImg";
            this.LogoImg.Size = new System.Drawing.Size(100, 100);
            this.LogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImg.TabIndex = 1;
            this.LogoImg.TabStop = false;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.AppNameLabel.Location = new System.Drawing.Point(82, 124);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(329, 32);
            this.AppNameLabel.TabIndex = 0;
            this.AppNameLabel.Text = "Windows Download Manager";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(656, 353);
            this.Controls.Add(this.ContentDownLoad);
            this.Controls.Add(this.AboutContent);
            this.Controls.Add(this.ContentSettings);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.HandlePanel);
            this.Controls.Add(this.LoadImg);
            this.Controls.Add(this.LoadLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Downloader Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HandlePanel.ResumeLayout(false);
            this.HandlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconImg)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.MiniBtn.ResumeLayout(false);
            this.ExitBtn.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.ContentDownLoad.ResumeLayout(false);
            this.ContentDownLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CastomProgressBar)).EndInit();
            this.ContentSettings.ResumeLayout(false);
            this.ContentSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadImg)).EndInit();
            this.AboutContent.ResumeLayout(false);
            this.AboutContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HandlePanel;
        private System.Windows.Forms.Label HandleLbl;
        private System.Windows.Forms.Panel ExitBtn;
        private System.Windows.Forms.Label ExitLbl;
        private System.Windows.Forms.Panel MiniBtn;
        private System.Windows.Forms.Label MiniLbl;
        private System.Windows.Forms.PictureBox IconImg;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label DownLoadButtom;
        private System.Windows.Forms.Panel ContentDownLoad;
        private System.Windows.Forms.Label URL_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Label FolderButton;
        private System.Windows.Forms.Button startdwButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileextensionTextBox;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.PictureBox CastomProgressBar;
        private System.Windows.Forms.Label CompletedLabel;
        private System.Windows.Forms.Label settingsButton;
        private System.Windows.Forms.Panel ContentSettings;
        private System.Windows.Forms.TextBox ProxyTextBox;
        private System.Windows.Forms.Label ProxyLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.PictureBox LoadImg;
        private System.Windows.Forms.Label LoadLabel;
        private System.Windows.Forms.ToolTip Tip;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem minimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xCloseToolStripMenuItem;
        private System.Windows.Forms.Label AboutButtom;
        private System.Windows.Forms.Panel AboutContent;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.PictureBox LogoImg;
        private System.Windows.Forms.Label InfLabel;
    }
}

