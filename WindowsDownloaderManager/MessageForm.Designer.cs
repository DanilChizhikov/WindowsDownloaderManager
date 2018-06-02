namespace WindowsDownloaderManager
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.HandlePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.HandleLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.ButtonYes = new System.Windows.Forms.Label();
            this.ButtonNo = new System.Windows.Forms.Label();
            this.HandlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HandlePanel
            // 
            this.HandlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.HandlePanel.Controls.Add(this.HandleLabel);
            this.HandlePanel.Controls.Add(this.CloseButton);
            this.HandlePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HandlePanel.Location = new System.Drawing.Point(0, 108);
            this.HandlePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HandlePanel.Name = "HandlePanel";
            this.HandlePanel.Size = new System.Drawing.Size(370, 35);
            this.HandlePanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CloseButton.Location = new System.Drawing.Point(335, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // HandleLabel
            // 
            this.HandleLabel.Location = new System.Drawing.Point(3, 0);
            this.HandleLabel.Name = "HandleLabel";
            this.HandleLabel.Size = new System.Drawing.Size(326, 35);
            this.HandleLabel.TabIndex = 1;
            this.HandleLabel.Text = "Handle";
            this.HandleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HandleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleLabel_MouseDown);
            this.HandleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandleLabel_MouseMove);
            // 
            // TextLabel
            // 
            this.TextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.TextLabel.Location = new System.Drawing.Point(0, 0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(370, 76);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Text";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonYes
            // 
            this.ButtonYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonYes.Location = new System.Drawing.Point(0, 76);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(185, 32);
            this.ButtonYes.TabIndex = 2;
            this.ButtonYes.Text = "Yes";
            this.ButtonYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            this.ButtonYes.MouseEnter += new System.EventHandler(this.ButtonYes_MouseEnter);
            this.ButtonYes.MouseLeave += new System.EventHandler(this.ButtonYes_MouseLeave);
            // 
            // ButtonNo
            // 
            this.ButtonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNo.Location = new System.Drawing.Point(185, 76);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(185, 32);
            this.ButtonNo.TabIndex = 2;
            this.ButtonNo.Text = "No";
            this.ButtonNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            this.ButtonNo.MouseEnter += new System.EventHandler(this.ButtonNo_MouseEnter);
            this.ButtonNo.MouseLeave += new System.EventHandler(this.ButtonNo_MouseLeave);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(370, 143);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.HandlePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handle";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.HandlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HandlePanel;
        private System.Windows.Forms.Label CloseButton;
        public System.Windows.Forms.Label HandleLabel;
        public System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label ButtonYes;
        private System.Windows.Forms.Label ButtonNo;
    }
}