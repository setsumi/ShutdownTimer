namespace ShutdownTimer
{
    partial class Menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlebarPictureBox = new System.Windows.Forms.PictureBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.timeOfDayModeRadioButton = new System.Windows.Forms.RadioButton();
            this.countdownModeRadioButton = new System.Windows.Forms.RadioButton();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.preventSleepCheckBox = new System.Windows.Forms.CheckBox();
            this.gracefulCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundCheckBox = new System.Windows.Forms.CheckBox();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.settingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarPictureBox)).BeginInit();
            this.timeGroupBox.SuspendLayout();
            this.actionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoursNumericUpDown
            // 
            this.hoursNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursNumericUpDown.Location = new System.Drawing.Point(9, 80);
            this.hoursNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.hoursNumericUpDown.Name = "hoursNumericUpDown";
            this.hoursNumericUpDown.Size = new System.Drawing.Size(58, 22);
            this.hoursNumericUpDown.TabIndex = 2;
            // 
            // minutesNumericUpDown
            // 
            this.minutesNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesNumericUpDown.Location = new System.Drawing.Point(73, 80);
            this.minutesNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.minutesNumericUpDown.Name = "minutesNumericUpDown";
            this.minutesNumericUpDown.Size = new System.Drawing.Size(58, 22);
            this.minutesNumericUpDown.TabIndex = 3;
            // 
            // secondsNumericUpDown
            // 
            this.secondsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsNumericUpDown.Location = new System.Drawing.Point(137, 80);
            this.secondsNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.secondsNumericUpDown.Name = "secondsNumericUpDown";
            this.secondsNumericUpDown.Size = new System.Drawing.Size(58, 22);
            this.secondsNumericUpDown.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(14, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(145, 22);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Shutdown Timer";
            // 
            // titlebarPictureBox
            // 
            this.titlebarPictureBox.BackColor = System.Drawing.Color.Black;
            this.titlebarPictureBox.Location = new System.Drawing.Point(18, 43);
            this.titlebarPictureBox.Name = "titlebarPictureBox";
            this.titlebarPictureBox.Size = new System.Drawing.Size(252, 3);
            this.titlebarPictureBox.TabIndex = 4;
            this.titlebarPictureBox.TabStop = false;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(6, 64);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(43, 16);
            this.hoursLabel.TabIndex = 5;
            this.hoursLabel.Text = "Hours";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(70, 64);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(53, 16);
            this.minutesLabel.TabIndex = 6;
            this.minutesLabel.Text = "Minutes";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(134, 64);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(61, 16);
            this.secondsLabel.TabIndex = 7;
            this.secondsLabel.Text = "Seconds";
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.Controls.Add(this.timeOfDayModeRadioButton);
            this.timeGroupBox.Controls.Add(this.countdownModeRadioButton);
            this.timeGroupBox.Controls.Add(this.hoursNumericUpDown);
            this.timeGroupBox.Controls.Add(this.secondsLabel);
            this.timeGroupBox.Controls.Add(this.hoursLabel);
            this.timeGroupBox.Controls.Add(this.minutesLabel);
            this.timeGroupBox.Controls.Add(this.minutesNumericUpDown);
            this.timeGroupBox.Controls.Add(this.secondsNumericUpDown);
            this.timeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeGroupBox.Location = new System.Drawing.Point(18, 186);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Size = new System.Drawing.Size(252, 113);
            this.timeGroupBox.TabIndex = 4;
            this.timeGroupBox.TabStop = false;
            this.timeGroupBox.Text = "Time";
            // 
            // timeOfDayModeRadioButton
            // 
            this.timeOfDayModeRadioButton.AutoSize = true;
            this.timeOfDayModeRadioButton.Location = new System.Drawing.Point(6, 42);
            this.timeOfDayModeRadioButton.Name = "timeOfDayModeRadioButton";
            this.timeOfDayModeRadioButton.Size = new System.Drawing.Size(165, 20);
            this.timeOfDayModeRadioButton.TabIndex = 1;
            this.timeOfDayModeRadioButton.Text = "At a specific time of day";
            this.timeOfDayModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // countdownModeRadioButton
            // 
            this.countdownModeRadioButton.AutoSize = true;
            this.countdownModeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.countdownModeRadioButton.Name = "countdownModeRadioButton";
            this.countdownModeRadioButton.Size = new System.Drawing.Size(170, 20);
            this.countdownModeRadioButton.TabIndex = 0;
            this.countdownModeRadioButton.Text = "After a specific timespan";
            this.countdownModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Controls.Add(this.preventSleepCheckBox);
            this.actionGroupBox.Controls.Add(this.gracefulCheckBox);
            this.actionGroupBox.Controls.Add(this.backgroundCheckBox);
            this.actionGroupBox.Controls.Add(this.actionComboBox);
            this.actionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionGroupBox.Location = new System.Drawing.Point(18, 52);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Size = new System.Drawing.Size(252, 128);
            this.actionGroupBox.TabIndex = 3;
            this.actionGroupBox.TabStop = false;
            this.actionGroupBox.Text = "Action";
            // 
            // preventSleepCheckBox
            // 
            this.preventSleepCheckBox.AutoSize = true;
            this.preventSleepCheckBox.Checked = true;
            this.preventSleepCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preventSleepCheckBox.Location = new System.Drawing.Point(6, 76);
            this.preventSleepCheckBox.Name = "preventSleepCheckBox";
            this.preventSleepCheckBox.Size = new System.Drawing.Size(235, 20);
            this.preventSleepCheckBox.TabIndex = 2;
            this.preventSleepCheckBox.Text = "Prevent system from going to sleep";
            this.preventSleepCheckBox.UseVisualStyleBackColor = true;
            // 
            // gracefulCheckBox
            // 
            this.gracefulCheckBox.AutoSize = true;
            this.gracefulCheckBox.Location = new System.Drawing.Point(6, 53);
            this.gracefulCheckBox.Name = "gracefulCheckBox";
            this.gracefulCheckBox.Size = new System.Drawing.Size(227, 20);
            this.gracefulCheckBox.TabIndex = 1;
            this.gracefulCheckBox.Text = "Graceful (do not force close apps)";
            this.gracefulCheckBox.UseVisualStyleBackColor = true;
            // 
            // backgroundCheckBox
            // 
            this.backgroundCheckBox.AutoSize = true;
            this.backgroundCheckBox.Location = new System.Drawing.Point(6, 99);
            this.backgroundCheckBox.Name = "backgroundCheckBox";
            this.backgroundCheckBox.Size = new System.Drawing.Size(198, 20);
            this.backgroundCheckBox.TabIndex = 3;
            this.backgroundCheckBox.Text = "Run minimized to system tray";
            this.backgroundCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionComboBox
            // 
            this.actionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.actionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.actionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Hibernate",
            "Sleep",
            "Logout",
            "Lock",
            "Command"});
            this.actionComboBox.Location = new System.Drawing.Point(9, 19);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(147, 24);
            this.actionComboBox.TabIndex = 0;
            this.actionComboBox.SelectedIndexChanged += new System.EventHandler(this.ActionComboBox_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(18, 305);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(252, 31);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(165, 13);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(41, 16);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "v0.0.0";
            // 
            // infoToolTip
            // 
            this.infoToolTip.AutoPopDelay = 30000;
            this.infoToolTip.InitialDelay = 500;
            this.infoToolTip.ReshowDelay = 100;
            this.infoToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.infoToolTip.ToolTipTitle = "Help";
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::ShutdownTimer.Properties.Resources.fa_cog_black;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Location = new System.Drawing.Point(233, 6);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(31, 31);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Menu
            // 
            this.AcceptButton = this.startButton;
            this.AccessibleDescription = "The main window where you can choose the time and power action.";
            this.AccessibleName = "Shutdown Timer";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 348);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.actionGroupBox);
            this.Controls.Add(this.timeGroupBox);
            this.Controls.Add(this.titlebarPictureBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarPictureBox)).EndInit();
            this.timeGroupBox.ResumeLayout(false);
            this.timeGroupBox.PerformLayout();
            this.actionGroupBox.ResumeLayout(false);
            this.actionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown hoursNumericUpDown;
        private System.Windows.Forms.NumericUpDown minutesNumericUpDown;
        private System.Windows.Forms.NumericUpDown secondsNumericUpDown;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox titlebarPictureBox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.GroupBox timeGroupBox;
        private System.Windows.Forms.GroupBox actionGroupBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.CheckBox backgroundCheckBox;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.CheckBox gracefulCheckBox;
        private System.Windows.Forms.CheckBox preventSleepCheckBox;
        private System.Windows.Forms.ToolTip infoToolTip;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.RadioButton countdownModeRadioButton;
        private System.Windows.Forms.RadioButton timeOfDayModeRadioButton;
    }
}

