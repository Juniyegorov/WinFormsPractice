
namespace WinFormsPractice
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.treyButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendLabel = new System.Windows.Forms.Label();
            this.outMessageBox = new System.Windows.Forms.TextBox();
            this.refreshOutMessage = new System.Windows.Forms.Timer(this.components);
            this.clearButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Chat";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // treyButton
            // 
            this.treyButton.AutoSize = true;
            this.treyButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.treyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treyButton.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treyButton.ForeColor = System.Drawing.Color.Maroon;
            this.treyButton.Location = new System.Drawing.Point(631, -8);
            this.treyButton.Name = "treyButton";
            this.treyButton.Size = new System.Drawing.Size(30, 45);
            this.treyButton.TabIndex = 2;
            this.treyButton.Text = "__";
            this.treyButton.Click += new System.EventHandler(this.treyButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Maroon;
            this.closeButton.Location = new System.Drawing.Point(669, -8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 45);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // messageBox
            // 
            this.messageBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageBox.Location = new System.Drawing.Point(0, 458);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(701, 26);
            this.messageBox.TabIndex = 4;
            this.messageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyDown);
            // 
            // sendLabel
            // 
            this.sendLabel.AutoSize = true;
            this.sendLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendLabel.Location = new System.Drawing.Point(654, 460);
            this.sendLabel.Name = "sendLabel";
            this.sendLabel.Size = new System.Drawing.Size(47, 20);
            this.sendLabel.TabIndex = 5;
            this.sendLabel.Text = "Send";
            this.sendLabel.Click += new System.EventHandler(this.sendLabel_Click);
            this.sendLabel.MouseEnter += new System.EventHandler(this.sendLabel_MouseEnter);
            this.sendLabel.MouseLeave += new System.EventHandler(this.sendLabel_MouseLeave);
            // 
            // outMessageBox
            // 
            this.outMessageBox.Location = new System.Drawing.Point(315, 116);
            this.outMessageBox.Multiline = true;
            this.outMessageBox.Name = "outMessageBox";
            this.outMessageBox.ReadOnly = true;
            this.outMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outMessageBox.Size = new System.Drawing.Size(386, 336);
            this.outMessageBox.TabIndex = 6;
            // 
            // refreshOutMessage
            // 
            this.refreshOutMessage.Enabled = true;
            this.refreshOutMessage.Interval = 1000;
            this.refreshOutMessage.Tick += new System.EventHandler(this.refresh_Click);
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Image = global::WinFormsPractice.Properties.Resources.Refresh;
            this.clearButton.Location = new System.Drawing.Point(658, 415);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(43, 28);
            this.clearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clearButton.TabIndex = 7;
            this.clearButton.TabStop = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsPractice.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 484);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outMessageBox);
            this.Controls.Add(this.sendLabel);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.treyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label treyButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.TextBox outMessageBox;
        private System.Windows.Forms.Timer refreshOutMessage;
        private System.Windows.Forms.PictureBox clearButton;
    }
}