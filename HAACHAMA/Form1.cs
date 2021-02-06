using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace HAACHAMA
{
    public partial class Form1 : Form
    {
        private System.Random rand = new System.Random();
        private Timer tmr;
        private Timer superColourChanger;
        private bool allowExit = false;
        private int clickTimes = 0;

        public Form1()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
            InitTimer();
            InitSuperColourChanger();
            System.IO.Stream stream = Properties.Resources.haachama;
            SoundPlayer sp = new SoundPlayer(stream);
            sp.PlayLooping();
        }

        private void myWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowExit)
            {
                e.Cancel = true;
            }
        }

        public void InitTimer()
        {
            tmr = new Timer();
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Interval = 1;
            tmr.Start();
        }

        public void InitSuperColourChanger()
        {
            superColourChanger = new Timer();
            superColourChanger.Tick += new EventHandler(superColourChanger_Tick);
            superColourChanger.Interval = 10;
            superColourChanger.Start();
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            AudioManager.SetMasterVolumeMute(false);
            AudioManager.SetMasterVolume(100);
            this.Show();
            this.BringToFront();
            this.Activate();
            this.Focus();
        }

        void superColourChanger_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.FromArgb(0, rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            clickTimes++;
            if (clickTimes >= 100)
            {
                allowExit = true;
                Application.Exit();
            }
        }
    }
}
