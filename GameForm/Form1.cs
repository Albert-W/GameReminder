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
        bool flag = true;
        Thread GameThread;
        public GameReminder()
        {
            InitializeComponent();
        }

        private void beginBtn_Click(object sender, EventArgs e)
        {
            flag = true;
            if(GameThread == null)
            {
                GameThread = new Thread(beep);
                GameThread.Start();
            }
            label3.Visible = false;

            
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
            while (flag)
            {
                SystemSounds.Beep.Play();
                Thread.Sleep(interval * 1000);
            }
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            flag = false;
            //GameThread.Interrupt();
            GameThread = null;
            label3.Visible = true;
        }

        private void InterTxb_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(InterTxb.Text.Trim(),out interval))
            {
                //MessageBox.Show("the time interval will be " + interval + " seconds");
                label2.Text = "interval:  " + interval + " seconds";
            }
            else
            {
                //MessageBox.Show("sorry, your input is not an time interval.");
                interval = 5;
                label2.Text = "Interval: " + "Wrong number";
            }

        }

        private void GameReminder_FormClosed(object sender, FormClosedEventArgs e)
        {
            flag = false;
            GameThread = null;
        }

    }
}
