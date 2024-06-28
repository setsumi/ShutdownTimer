namespace ShutdownTimer
{
    partial class Countdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Countdown));
            this.titleLabel = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timerPauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appRestartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerStopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRestartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.timerUIHideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerUIShowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.timeMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.updateTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titlebarPictureBox = new System.Windows.Forms.PictureBox();
            this.lockStatePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commandLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockStatePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 31);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "Shutdown Timer";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "Shutdown Timer";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Shutdown Timer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerPauseMenuItem,
            this.appRestartMenuItem,
            this.timerStopMenuItem,
            this.timerRestartMenuItem,
            this.toolStripSeparator1,
            this.timerUIHideMenuItem,
            this.timerUIShowMenuItem,
            this.toolStripSeparator2,
            this.timeMenuItem,
            this.updateTimeMenuItem});
            this.contextMenuStrip.Name = "contextMenu";
            this.contextMenuStrip.Size = new System.Drawing.Size(213, 195);
            // 
            // timerPauseMenuItem
            // 
            this.timerPauseMenuItem.Name = "timerPauseMenuItem";
            this.timerPauseMenuItem.Size = new System.Drawing.Size(212, 22);
            this.timerPauseMenuItem.Text = "Pause";
            this.timerPauseMenuItem.Click += new System.EventHandler(this.TimerPauseMenuItem_Click);
            // 
            // appRestartMenuItem
            // 
            this.appRestartMenuItem.Name = "appRestartMenuItem";
            this.appRestartMenuItem.Size = new System.Drawing.Size(212, 22);
            this.appRestartMenuItem.Text = "Stop";
            this.appRestartMenuItem.Click += new System.EventHandler(this.AppRestartMenuItem_Click);
            // 
            // timerStopMenuItem
            // 
            this.timerStopMenuItem.Name = "timerStopMenuItem";
            this.timerStopMenuItem.Size = new System.Drawing.Size(212, 22);
            this.timerStopMenuItem.Text = "Stop and exit";
            this.timerStopMenuItem.Click += new System.EventHandler(this.TimerStopMenuItem_Click);
            // 
            // timerRestartMenuItem
            // 
            this.timerRestartMenuItem.Name = "timerRestartMenuItem";
            this.timerRestartMenuItem.Size = new System.Drawing.Size(212, 22);
            this.timerRestartMenuItem.Text = "Restart";
            this.timerRestartMenuItem.Click += new System.EventHandler(this.TimerRestartMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // timerUIHideMenuItem
            // 
            this.timerUIHideMenuItem.Name = "timerUIHideMenuItem";
            this.timerUIHideMenuItem.Size = new System.Drawing.Size(212, 22);
            this.timerUIHideMenuItem.Text = "Hide to tray";
            this.timerUIHideMenuItem.Click += new System.EventHandler(this.TimerUIHideMenuItem_Click);
            // 
            // timerUIShowMenuItem
            // 
            this.timerUIShowMenuItem.Enabled = false;
            this.timerUIShowMenuItem.Name = "timerUIShowMenuItem";
            this.timerUIShowMenuItem.Size = new System.Drawing.Size(212, 22);
            this.timerUIShowMenuItem.Text = "Show countdown window";
            this.timerUIShowMenuItem.Click += new System.EventHandler(this.TimerUIShowMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // timeMenuItem
            // 
            this.timeMenuItem.Enabled = false;
            this.timeMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeMenuItem.Name = "timeMenuItem";
            this.timeMenuItem.ReadOnly = true;
            this.timeMenuItem.Size = new System.Drawing.Size(100, 23);
            // 
            // updateTimeMenuItem
            // 
            this.updateTimeMenuItem.Name = "updateTimeMenuItem";
            this.updateTimeMenuItem.Size = new System.Drawing.Size(212, 22);
            this.updateTimeMenuItem.Text = "Set new timeout";
            this.updateTimeMenuItem.Click += new System.EventHandler(this.UpdateTimeMenuItem_Click);
            // 
            // titlebarPictureBox
            // 
            this.titlebarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlebarPictureBox.BackColor = System.Drawing.Color.White;
            this.titlebarPictureBox.Location = new System.Drawing.Point(12, 43);
            this.titlebarPictureBox.Name = "titlebarPictureBox";
            this.titlebarPictureBox.Size = new System.Drawing.Size(358, 5);
            this.titlebarPictureBox.TabIndex = 16;
            this.titlebarPictureBox.TabStop = false;
            // 
            // lockStatePictureBox
            // 
            this.lockStatePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lockStatePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.lockStatePictureBox.Enabled = false;
            this.lockStatePictureBox.Location = new System.Drawing.Point(338, 7);
            this.lockStatePictureBox.Name = "lockStatePictureBox";
            this.lockStatePictureBox.Size = new System.Drawing.Size(32, 32);
            this.lockStatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockStatePictureBox.TabIndex = 17;
            this.lockStatePictureBox.TabStop = false;
            this.lockStatePictureBox.Visible = false;
            this.lockStatePictureBox.Click += new System.EventHandler(this.LockStatePictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.commandLabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 88);
            this.panel1.TabIndex = 18;
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.BackColor = System.Drawing.Color.Transparent;
            this.commandLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.commandLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandLabel.ForeColor = System.Drawing.Color.White;
            this.commandLabel.Location = new System.Drawing.Point(0, 0);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(76, 19);
            this.commandLabel.TabIndex = 16;
            this.commandLabel.Text = "command";
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(0, 19);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(358, 69);
            this.timeLabel.TabIndex = 15;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Countdown
            // 
            this.AccessibleDescription = "Shows the time left until power action gets executed.";
            this.AccessibleName = "Shutdown Timer Countdown";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(382, 138);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lockStatePictureBox);
            this.Controls.Add(this.titlebarPictureBox);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Countdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Countdown";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Countdown_FormClosing);
            this.Load += new System.EventHandler(this.Countdown_Load);
            this.SizeChanged += new System.EventHandler(this.Countdown_SizeChanged);
            this.contextMenuStrip.ResumeLayout(false);
            this.contextMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockStatePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox titlebarPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem timerStopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerRestartMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox timeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appRestartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerUIHideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerUIShowMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox lockStatePictureBox;
        private System.Windows.Forms.ToolStripMenuItem timerPauseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTimeMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label commandLabel;
        internal System.Windows.Forms.Label timeLabel;
    }
}