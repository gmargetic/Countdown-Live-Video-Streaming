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
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Countdown
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        private static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lpRect, MonitorEnumProc callback, int dwData);
        private delegate bool MonitorEnumProc(IntPtr hDesktop, IntPtr hdc, ref Rect pRect, int dwData);

        Form1 form;

        private DateTime StopTime = default(DateTime);

        private bool ctTimer = false;

        private int pbCounter = 0;

        private bool maximised = true;

        private int displays = 0;

        private int warning = Properties.Settings.Default.pbColorWarning;
        private int danger = Properties.Settings.Default.pbColorDanger;
        
        private bool blinkReps = false;

        private string lastTime = "00:00:00";

        remote remote = new remote();

        private bool keepRemoteMessage = false;

        private int jog1minUp = 0;
        private int jog1minDown = 0;
        private int jog5minUp = 0;
        private int jog5minDown = 0;

        private int remainingMinutes = 0;

        public Form1()
        {
            InitializeComponent();
            displays = Screen.AllScreens.Length;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            preloadPresetButtons();
            timerCurrentTime.Start();
            showRemoteForm();
            //showOnScreen(1);
            /*Rect r = new Rect();
            MonitorEnumProc callback = (IntPtr hDesktop, IntPtr hdc, ref Rect prect, int d) => ++displays > 0;
            if (EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, callback, 0))
            {
                MessageBox.Show("You have " + displays.ToString() + " monitors.");
            }
            else
            {
                MessageBox.Show("An error occured while enumerating monitors");
            }*/
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            ctTimer = false;
            btnStart.Text = "Start";
            labelTimeRemaining.Text = lastTime;
            labelTimeRemaining.ForeColor = Color.Lime;

            remote.lblCount.Text = lastTime;
            remote.lblCount.ForeColor = Color.Lime;
            resetPbCounter();
        }

        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            remote.lblClock.Text = labelCurrentTime.Text;

            if (ctTimer)
            {
                blinkReps = false;

                TimeSpan remaining = StopTime.Subtract(DateTime.Now);

                remaining = new TimeSpan(remaining.Hours, remaining.Minutes,
                    remaining.Seconds);

                if (pbCounter == 0)
                {
                    pbCounter = Convert.ToInt32(remaining.TotalSeconds);
                    setProgressBar(pbCounter);
                }

                if (remaining.TotalSeconds < 0 ){
                    remaining = TimeSpan.Zero;
                }

                if (remaining.TotalMinutes < 0)
                {
                    remaining = TimeSpan.Zero;
                } else if (remaining.TotalMinutes < 0)
                {
                    remaining = TimeSpan.Zero;
                }
                remainingMinutes = Convert.ToInt32(remaining.TotalMinutes);

                    if (remainingMinutes > 1 && (jog1minUp > 0 || jog1minDown > 0))
                {
                    if (jog1minUp != 0)
                    {
                        StopTime = DateTime.Now.AddMinutes(jog1minUp);
                        jog1minUp = 0;
                    }

                    if (jog1minDown != 0 && remainingMinutes > jog1minDown)
                    {
                        StopTime = StopTime.Add(new TimeSpan(0, 0, -Convert.ToInt32(jog1minDown), 0));
                        jog1minDown = 0;
                    }
                }
                else
                {
                    jog1minUp = 0;
                    jog1minDown = 0;
                }

                if (remainingMinutes > 5 && (jog5minUp > 0 || jog5minDown > 0))
                {
                    if (jog5minUp != 0)
                    {
                        StopTime = DateTime.Now.AddMinutes(jog5minUp);
                        jog5minUp = 0;
                    }

                    if (jog5minDown != 0 && remainingMinutes > jog5minDown)
                    {
                        StopTime = StopTime.Add(new TimeSpan(0, 0, -Convert.ToInt32(jog5minDown), 0));
                        jog5minDown = 0;
                    }
                }
                else
                {
                    jog5minUp = 0;
                    jog5minDown = 0;
                }


                labelTimeRemaining.Text = remaining.ToString();
                remote.lblCount.Text = remaining.ToString();

                int remMins = Convert.ToInt32(remaining.Minutes);
                int remHours = Convert.ToInt32(remaining.Hours);

                warning = Properties.Settings.Default.pbColorWarning;
                danger = Properties.Settings.Default.pbColorDanger;

                if (remHours == 0 && remMins <= warning && remMins > danger)
                {
                    pbCount.SetState(3);
                    remote.pbRemote.SetState(3);
                    labelTimeRemaining.ForeColor = Color.Yellow;
                    remote.lblCount.ForeColor = Color.Yellow;
                }
                else if (remHours == 0 && remMins <= danger)
                {
                    pbCount.SetState(2);
                    remote.pbRemote.SetState(2);
                    labelTimeRemaining.ForeColor = Color.Red;
                    remote.lblCount.ForeColor = Color.Red;
                }
                else
                {
                    pbCount.SetState(1);
                    remote.pbRemote.SetState(1);
                    labelTimeRemaining.ForeColor = Color.Lime;
                    remote.lblCount.ForeColor = Color.Lime;
                }

                pbCount.PerformStep();
                remote.pbRemote.PerformStep();

                if (remaining.TotalSeconds <= 0)
                {
                    blinkReps = true;
                    Blink(labelTimeRemaining);
                    pbCount.Value = pbCount.Maximum;
                    ctTimer = false;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(ctTimer)
            {
                ctTimer = false;
                if (labelTimeRemaining.Text != "00:00:00")
                {
                    btnStart.Text = "Resume";
                }
                else
                {
                    btnStart.Text = "Start";
                }
            } 
            else
            {
                string leftTime;

                if(labelTimeRemaining.Text != "00:00:00")
                {
                    leftTime = labelTimeRemaining.Text;
                }
                else
                {
                    leftTime = labelCountHours.Text + ":" + labelCountMinutes.Text + ":" + labelCountSeconds.Text;
                }

                if(leftTime == "00:00:00")
                {
                    MessageBox.Show("Please set time!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                TimeSpan duration = TimeSpan.Parse(leftTime);
                StopTime = DateTime.Now.Add(duration);
                lastTime = leftTime;
                ctTimer = true;
                btnStart.Text = "Pause";
            }
         }

        private void btnSeccondsPlus_Click(object sendeSr, EventArgs e)
        {
            int seconds = Convert.ToInt32(labelCountSeconds.Text);
            seconds = seconds + 1;
            labelCountSeconds.Text = generateSeconds(seconds);
            if (!ctTimer)
            {
                setNewTime(false);
            }
            else
            {
                setNewTime(true);
            }
        }

        private void btnSeccondsMinus_Click(object sender, EventArgs e)
        {
            int seconds = Convert.ToInt32(labelCountSeconds.Text);
            seconds = seconds - 1;
            labelCountSeconds.Text = generateSeconds(seconds);
            if (!ctTimer)
            {
                setNewTime(false);
            }
            else
            {
                setNewTime(true);
            }
        }

        private void btnMinutesPlus_Click(object sender, EventArgs e)
        {
            int minutes = Convert.ToInt32(labelCountMinutes.Text);
            minutes = minutes + 1;
            labelCountMinutes.Text = generateMinutes(minutes);
            if (!ctTimer)
            {
                setNewTime(false);
            }
            else
            {
                setNewTime(true);
            }
        }

        private void btnMinutesMinus_Click(object sender, EventArgs e)
        {
            int minutes = Convert.ToInt32(labelCountMinutes.Text);
            minutes = minutes - 1;
            labelCountMinutes.Text = generateMinutes(minutes);
            if (!ctTimer)
            {
                setNewTime(false);
            }
            else
            {
                setNewTime(true);
            }
        }

        private void btnHoursPlus_Click(object sender, EventArgs e)
        {
            int hours = Convert.ToInt32(labelCountHours.Text);
            hours = hours + 1;
            labelCountHours.Text = generateHours(hours);
            if (!ctTimer)
            {
                setNewTime(false);
            }
            else
            {
                setNewTime(true);
            }
        }

        private void btnHoursMinus_Click(object sender, EventArgs e)
        {
            int hours = Convert.ToInt32(labelCountHours.Text);
            hours = hours - 1;
            labelCountHours.Text = generateHours(hours);
            if (!ctTimer)
            {
                setNewTime(false);
            }
            else
            {
                setNewTime(true);
            }
        }

        private string generateHours(int hours)
        {
            string outHours;
            if (hours < 0)
            {
                outHours = "24";
            }
            else if (hours >= 24)
            {
                outHours = "00";
            }
            else if (hours < 10)
            {
                outHours = "0" + hours.ToString();
            }
            else
            {
                outHours = hours.ToString();
            }
            return outHours;
        }

        private string generateMinutes(int minutes)
        {
            string outMinutes;
            if (minutes < 0)
            {
                outMinutes = "59";
            }
            else if (minutes >= 59)
            {
                outMinutes = "00";
            }
            else if (minutes < 10)
            {
                outMinutes = "0" + minutes.ToString();
            }
            else
            {
                outMinutes = minutes.ToString();
            }
            return outMinutes;
        }

        private string generateSeconds(int seconds)
        {
            string outSeconds;
            if (seconds < 0)
            {
                outSeconds = "59";
            }
            else if (seconds >= 59)
            {
                outSeconds = "00";
            }
            else if (seconds < 10)
            {
                outSeconds = "0" + seconds.ToString();
            }
            else
            {
                outSeconds = seconds.ToString();
            }
             return outSeconds;
        }


        private void setNewTime(bool setLastTime = false)
        {
            int remMins = Convert.ToInt32(labelCountMinutes.Text);
            int remHours = Convert.ToInt32(labelCountHours.Text);
            if (setLastTime)
            {
                lastTime = labelCountHours.Text + ":" + labelCountMinutes.Text + ":" + labelCountSeconds.Text;
            }
            else
            {
                if (remHours == 0 && remMins <= warning && remMins > danger)
                {
                    pbCount.SetState(3);
                    remote.pbRemote.SetState(1);
                    labelTimeRemaining.ForeColor = Color.Yellow;
                }
                else if (remHours == 0 && remMins <= danger)
                {
                    pbCount.SetState(2);
                    remote.pbRemote.SetState(1);
                    labelTimeRemaining.ForeColor = Color.Red;
                }
                else
                {
                    pbCount.SetState(1);
                    remote.pbRemote.SetState(1);
                    labelTimeRemaining.ForeColor = Color.Lime;
                }
                labelTimeRemaining.Text = labelCountHours.Text + ":" + labelCountMinutes.Text + ":" + labelCountSeconds.Text;
                lastTime = labelTimeRemaining.Text;
                remote.lblCount.Text = lastTime;
                resetPbCounter();
            }
        }

        private void setProgressBar(int steps)
        {
            int maxSteps = steps * 1000;
            pbCount.Maximum = maxSteps;
            pbCount.Step = 1000;
            pbCount.SetState(1);

            remote.pbRemote.Maximum = maxSteps;
            remote.pbRemote.Step = 1000;
            remote.pbRemote.SetState(1);
        }

        private void resetPbCounter()
        {
            Color newColor;

            blinkReps = false;
            pbCount.Value = 0;
            pbCounter = 0;
            pbCount.SetState(1);

            string[] resetTime = labelTimeRemaining.Text.Split(':');

            int remMins = Convert.ToInt32(resetTime[1]);
            int remHours = Convert.ToInt32(resetTime[0]);

            if (remHours == 0 && remMins <= warning && remMins > danger)
            {
                //pbCount.SetState(3);
                newColor = Color.Yellow;
            }
            else if (remHours == 0 && remMins <= danger)
            {
                //pbCount.SetState(2);
                newColor = Color.Red;
            }
            else
            {
                //pbCount.SetState(1);
                newColor = Color.Lime;
            }
            labelTimeRemaining.ForeColor = newColor;
            resetRemotePbCounter(newColor);
        }

        private void resetRemotePbCounter(Color newColor)
        {
            remote.pbRemote.Value = 0;
            remote.pbRemote.SetState(1);
            remote.lblCount.ForeColor = newColor;
        }

        private void showOnScreen(int screenNumber)
        {
            Screen[] screens = Screen.AllScreens;

            if (screenNumber >= 0 && screenNumber < screens.Length)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                    maximised = true;
                }
                Location = screens[screenNumber].WorkingArea.Location;
                if (maximised)
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
        }


        private void showRemoteForm()
        {
            Screen[] screens = Screen.AllScreens;
            var remoteLocation = screens[0].WorkingArea.Location;
            if (displays >= 0 && displays < screens.Length)
            {
                //if (remote.WindowState == FormWindowState.Maximized)
                //{
                //    remote.WindowState = FormWindowState.Normal;
                //    maximised = true;
                //}
                //remoteLocation = screens[displays].WorkingArea.Location;
                //if (maximised)
                //{
                    //remote.WindowState = FormWindowState.Maximized;
                //}
            }
            remote.Location = screens[1].WorkingArea.Location;
            remote.WindowState = FormWindowState.Maximized;
            remote.Show();
            remote.lblMsg.Text = "";
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }


        /*
         * Presset buttons - Start
         */
        private void btnPreset1_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset2_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset3_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset4_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset5_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset6_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset7_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset8_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset9_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset10_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset11_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void btnPreset12_Click(object sender, EventArgs e)
        {
            savePresetBtn(sender, e);
        }

        private void savePresetBtn(object sender, EventArgs e)
        {
            
            if (Form.ModifierKeys == Keys.Control)
            {
                string newPresetTime = labelCountHours.Text + ":" + labelCountMinutes.Text + ":" + labelCountSeconds.Text;
                string btnName = (sender as Button).Name;
                Properties.Settings.Default[btnName] = newPresetTime;
                Properties.Settings.Default.Save();
                (sender as Button).Text = newPresetTime;
            }
            else
            {
                string btnText = (sender as Button).Text;
                if (!ctTimer)
                {
                    
                    labelTimeRemaining.Text = btnText;
                    labelTimeRemaining.ForeColor = Color.Lime;

                    remote.lblCount.Text = btnText;
                    remote.lblCount.ForeColor = Color.Lime;

                    //lastTime = btnText;
                    resetPbCounter();
                }
                lastTime = btnText;
                string[] resetTime = btnText.Split(':');

                labelCountHours.Text = resetTime[0];
                labelCountMinutes.Text = resetTime[1];
                labelCountSeconds.Text = resetTime[2];
            }
        }
        private void preloadPresetButtons()
        {
            btnPreset1.Text = Properties.Settings.Default.btnPreset1;
            btnPreset2.Text = Properties.Settings.Default.btnPreset2;
            btnPreset3.Text = Properties.Settings.Default.btnPreset3;
            btnPreset4.Text = Properties.Settings.Default.btnPreset4;
            btnPreset5.Text = Properties.Settings.Default.btnPreset5;
            btnPreset6.Text = Properties.Settings.Default.btnPreset6;
            btnPreset7.Text = Properties.Settings.Default.btnPreset7;
            btnPreset8.Text = Properties.Settings.Default.btnPreset8;
            btnPreset9.Text = Properties.Settings.Default.btnPreset9;
            btnPreset10.Text = Properties.Settings.Default.btnPreset10;
            btnPreset11.Text = Properties.Settings.Default.btnPreset11;
            btnPreset12.Text = Properties.Settings.Default.btnPreset12;
        }
        /*
        * Presset buttons - End
        */


        private async void Blink(Label label)
        {
            //while (blinkReps)
            //{
            //    await Task.Delay(500);
            //    label.ForeColor = label.ForeColor == Color.Red ? Color.Green : Color.Red;
            //    blinkReps++;
            //}
        }

        private async void sendMsg(string msg)
        {
            remote.lblMsg.Text = msg;
            int i = 10;
            while (keepRemoteMessage)
            {
                await Task.Delay(500);
                if(i == 0)
                {
                    keepRemoteMessage = false;
                }
                if(remote.lblMsg.ForeColor == Color.White)
                {
                    remote.lblMsg.ForeColor = Color.DarkGray;
                }
                else
                {
                    remote.lblMsg.ForeColor = Color.White;
                }
                i--;
                if(i < 1)
                {
                    remote.lblMsg.ForeColor = Color.White;
                }
            }
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            if(remote.lblMsg.Text.Length < 1)
            {
                keepRemoteMessage = true;
                string message = Regex.Replace(rtbMsg.Text, "(.{" + 35 + "})", "$1" + Environment.NewLine);
                sendMsg(message);
                btnMsg.Text = "Clear";
                btnMsg.ForeColor = Color.Red;
            }
            else
            {
                keepRemoteMessage = false;
                sendMsg("");
                btnMsg.Text = "Send";
                btnMsg.ForeColor = Color.LightGray;
            }
        }

        private void rtbMsg_TextChanged(object sender, EventArgs e)
        {
            //if(rtbMsg.Text.Length == 33 || rtbMsg.Text.Length == 70 || rtbMsg.Text.Length == 105)
            //{
            //    rtbMsg.AppendText("\r\n");
            //}
        }

        public static string SpliceText(string text, int lineLength)
        {
            return Regex.Replace(text, "(.{" + lineLength + "})", "$1" + Environment.NewLine);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog(form);
        }

        private void linkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.goranmargetic.com");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHideOutput.Checked)
            {
                remote.WindowState = FormWindowState.Minimized;
                cbHideOutput.ForeColor = Color.Red;
            } 
            else
            {
                remote.WindowState = FormWindowState.Maximized;
                cbHideOutput.ForeColor = Color.LightGray;
            }
        }

        private void cbHideClock_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHideClock.Checked)
            {
                remote.lblClock.Hide();
                cbHideClock.ForeColor = Color.Red;
            }
            else
            {
                remote.lblClock.Show();
                cbHideClock.ForeColor = Color.LightGray;
            }
        }

        private void cbHideProgress_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHideProgress.Checked)
            {
                remote.pbRemote.Hide();
                cbHideProgress.ForeColor = Color.Red;
            }
            else
            {
                remote.pbRemote.Show();
                cbHideProgress.ForeColor = Color.LightGray;
            }
        }

        private void cbShowTest_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowTest.Checked)
            {
                remote.pictureSmpte.Visible = true;
                remote.pictureSmpte.BringToFront();
                cbShowTest.ForeColor = Color.Red;
            }
            else
            {
                remote.pictureSmpte.Visible = false;
                remote.pictureSmpte.SendToBack();
                cbShowTest.ForeColor = Color.LightGray;
            }
        }
    }
}

public static class ModifyProgressBarColor
{
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
    static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
    public static void SetState(this ProgressBar pBar, int state)
    {
        SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
    }
}