using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Simple_Stopwatch
{
    public partial class Main : Form
    {
        Stopwatch StopWatch = new Stopwatch;

        public Main()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = this.StopWatch.Elapsed;
            Label1.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (StartButton.Text == "Start")
            {
                Timer1.Start();
                this.StopWatch.Start();
                StartButton.Text = "Stop";
            }
            else
            {
                Timer1.Stop();
                this.StopWatch.Stop();
                StartButton.Text = "Start";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.StopWatch.Reset();
            Label1.Text = "00:00:00:000";
            StartButton.Text = "Start";
            ListBox1.Items.Clear();
        }

        private void LapButton_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(Label1.Text);
        }
    }
}
