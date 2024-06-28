using ShutdownTimer.Helpers;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace ShutdownTimer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            appLabel.Text = Application.ProductName + "@v" + Application.ProductVersion.Remove(Application.ProductVersion.LastIndexOf("."));
            infoToolTip.SetToolTip(forceIfHungFlagRadioButton, "Forces processes to terminate if they do not respond " +
                "\nto the WM_QUERYENDSESSION or WM_ENDSESSION \nmessage within the timeout interval.");
            infoToolTip.SetToolTip(forceFlagRadioButton, "This flag has no effect if terminal services is " +
                "\nenabled. Otherwise, the system does not send \nthe WM_QUERYENDSESSION message. This can " +
                "\ncause applications to lose data. Therefore, you \nshould only use this flag in an emergency.");

            LoadSettings();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void RememberStateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberStateCheckBox.Checked)
            {
                SettingsProvider.Settings.RememberLastState = true;
                customDefaultsGroupBox.Enabled = false;
            }
            else
            {
                SettingsProvider.Settings.RememberLastState = false;
                customDefaultsGroupBox.Enabled = true;
            }
        }

        private void ClearSettingsButton_Click(object sender, EventArgs e)
        {
            SettingsProvider.ClearSettings();
            LoadSettings();
        }

        private void LoadSettings()
        {
            // general controls
            rememberStateCheckBox.Checked = SettingsProvider.Settings.RememberLastState;
            trayiconThemeComboBox.Text = SettingsProvider.Settings.TrayIconTheme;
            rememberLastScreenPositionUI.Checked = SettingsProvider.Settings.RememberLastScreenPositionUI;
            rememberLastScreenPositionCountdown.Checked = SettingsProvider.Settings.RememberLastScreenPositionCountdown;

            // default timer
            actionComboBox.Text = SettingsProvider.Settings.DefaultTimer.Action;
            gracefulCheckBox.Checked = SettingsProvider.Settings.DefaultTimer.Graceful;
            preventSleepCheckBox.Checked = SettingsProvider.Settings.DefaultTimer.PreventSleep;
            backgroundCheckBox.Checked = SettingsProvider.Settings.DefaultTimer.Background;
            countdownModeRadioButton.Checked = SettingsProvider.Settings.DefaultTimer.CountdownMode;
            timeOfDayModeRadioButton.Checked = !SettingsProvider.Settings.DefaultTimer.CountdownMode;
            hoursNumericUpDown.Value = SettingsProvider.Settings.DefaultTimer.Hours;
            minutesNumericUpDown.Value = SettingsProvider.Settings.DefaultTimer.Minutes;
            secondsNumericUpDown.Value = SettingsProvider.Settings.DefaultTimer.Seconds;

            // advanced settings
            forceIfHungFlagRadioButton.Checked = SettingsProvider.Settings.ForceIfHungFlag;
            forceFlagRadioButton.Checked = !SettingsProvider.Settings.ForceIfHungFlag;
            disableAlwaysOnTopCheckBox.Checked = SettingsProvider.Settings.DisableAlwaysOnTop;
            disableAnimationsCheckBox.Checked = SettingsProvider.Settings.DisableAnimations;
            disableNotificationsCheckBox.Checked = SettingsProvider.Settings.DisableNotifications;
            passwordCheckBox.Checked = SettingsProvider.Settings.PasswordProtection;
            enableAdaptiveCountdownTextSizeCheckBox.Checked = SettingsProvider.Settings.AdaptiveCountdownTextSize;
            if (SettingsProvider.Settings.BackgroundColor == Color.Transparent) { transparentWindowCheckBox.Checked = true; }

            // UI processing
            setBackgroundColorLinkLabel.Enabled = disableAnimationsCheckBox.Checked;
        }

        private void SaveSettings()
        {
            // general controls
            SettingsProvider.Settings.RememberLastState = rememberStateCheckBox.Checked;
            SettingsProvider.Settings.TrayIconTheme = trayiconThemeComboBox.Text;

            // default timer
            if (!SettingsProvider.Settings.RememberLastState)
            {
                SettingsProvider.Settings.DefaultTimer.Action = actionComboBox.Text;
                SettingsProvider.Settings.DefaultTimer.Graceful = gracefulCheckBox.Checked;
                SettingsProvider.Settings.DefaultTimer.PreventSleep = preventSleepCheckBox.Checked;
                SettingsProvider.Settings.DefaultTimer.Background = backgroundCheckBox.Checked;
                SettingsProvider.Settings.DefaultTimer.CountdownMode = countdownModeRadioButton.Checked;
                SettingsProvider.Settings.DefaultTimer.Hours = Convert.ToInt32(hoursNumericUpDown.Value);
                SettingsProvider.Settings.DefaultTimer.Minutes = Convert.ToInt32(minutesNumericUpDown.Value);
                SettingsProvider.Settings.DefaultTimer.Seconds = Convert.ToInt32(secondsNumericUpDown.Value);
            }

            // advanced settings
            SettingsProvider.Settings.ForceIfHungFlag = forceIfHungFlagRadioButton.Checked;
            SettingsProvider.Settings.DisableAlwaysOnTop = disableAlwaysOnTopCheckBox.Checked;
            SettingsProvider.Settings.DisableAnimations = disableAnimationsCheckBox.Checked;
            SettingsProvider.Settings.DisableNotifications = disableNotificationsCheckBox.Checked;
            SettingsProvider.Settings.AdaptiveCountdownTextSize = enableAdaptiveCountdownTextSizeCheckBox.Checked;
            SettingsProvider.Settings.PasswordProtection = passwordCheckBox.Checked;


            SettingsProvider.Settings.RememberLastScreenPositionUI = rememberLastScreenPositionUI.Checked;
            SettingsProvider.Settings.RememberLastScreenPositionCountdown = rememberLastScreenPositionCountdown.Checked;

            SettingsProvider.Save();
        }

        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/setsumi/ShutdownTimer");
        }

        private void ForceFlagDocsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-exitwindowsex#parameters");
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            ExceptionHandler.CreateLog();
        }

        private void SetBackgroundColorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                Color = SettingsProvider.Settings.BackgroundColor,
                FullOpen = true
            };
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SettingsProvider.Settings.BackgroundColor = colorDialog.Color;
            }
        }

        private void TransparentWindowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (transparentWindowCheckBox.Checked)
            {
                SettingsProvider.Settings.BackgroundColor = Color.Transparent;
            } else
            {
                SettingsProvider.Settings.BackgroundColor = Color.Blue;
            }
        }

        private void DisableAnimationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setBackgroundColorLinkLabel.Enabled = disableAnimationsCheckBox.Checked;
            transparentWindowCheckBox.Enabled = disableAnimationsCheckBox.Checked;
        }
    }
}
