using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class Form1 : Form
    {

        private Timer timerSwitch;
        private int timeCounter = 0;



        public Form1()
        {
            InitializeComponent();
            InitalizeTrafficLights();
            InitializeTimerSwitch();
        }
        private void InitializeTimerSwitch()
        {
           timerSwitch = new Timer();
           timerSwitch.Interval = 1000;
           timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);
           timerSwitch.Start();

        }

        private void TimerSwitch_Tick(object sender, EventArgs e)
        {
            if(timeCounter == 0)
            {
                RedLight.BackColor = Color.Red;
            }
            else if(timeCounter == 3)
            {
                RedLight.BackColor = Color.Gray;
                YellowLight.BackColor = Color.Yellow; 
                
            }
            else if(timeCounter == 6)
            {
                YellowLight.BackColor = Color.Gray;
                GreenLight.BackColor = Color.Green;
               
            }
            else if (timeCounter == 9)
            {
                GreenLight.BackColor = Color.Gray;
                YellowLight.BackColor = Color.Yellow;
            }
            else if(timeCounter == 12)
            {
                YellowLight.BackColor = Color.Gray;
                RedLight.BackColor = Color.Red;
                timeCounter = -1;
            }
            timeCounter++;
        }


        private void InitalizeTrafficLights()
        {
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
        }
    }
}
