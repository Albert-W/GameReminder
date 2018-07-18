using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace GameForm
{
    public partial class GameReminder : Form
    {
        int interval = 5;
        //bool flag = true;
        //Thread GameThread;
        public GameReminder()
        {
            InitializeComponent();
        }

        private void beginBtn_Click(object sender, EventArgs e)
        {
            //flag = true;
            //if(GameThread == null)
            //{
            //    GameThread = new Thread(beep);
            //   GameThread.Start();
            //}
            label3.Visible = false;
            timer1.Enabled = true;
            timer1.Start();
            
 //           while (flag)
 //           {
                //SystemSounds.Beep.Play();
                //System.Threading.Thread.Sleep(interval * 1000);
 //               Thread GameReminder = new Thread(beep);
 //               GameReminder.Start();
                
 //           }
        }
        private void beep()
        {
            //while (flag)
            {
                SystemSounds.Beep.Play();
                Thread.Sleep(interval * 1000);
            }
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            //flag = false;
            //GameThread = null;
            label3.Visible = true;
            timer1.Enabled = false;
            timer1.Stop();
        }

        private void InterTxb_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(InterTxb.Text.Trim(),out interval))
            {
                //MessageBox.Show("the time interval will be " + interval + " seconds");
                label2.Text = "interval: " + interval + " seconds";
                timer1.Interval = interval * 1000;
            }
            else
            {
                //MessageBox.Show("sorry, your input is not an time interval.");
                timer1.Interval = 5000;
                label2.Text = "Interval: " + "Wrong number";
            }

        }

        private void GameReminder_FormClosed(object sender, FormClosedEventArgs e)
        {
            //flag = false;
            //GameThread = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }
    }
}
