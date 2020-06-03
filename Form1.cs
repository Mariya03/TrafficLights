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


        public Form1()
        {
            InitializeComponent();
            InitalizeTrafficLights();
            InitializeTimerSwitch();
        }
        private void InitializeTimerSwitch()
        {
           timerSwitch = new Timer();
           timerSwitch.Interval = 3000;
           timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);
           timerSwitch.Start();

        }

        private void TimerSwitch_Tick(object sender, EventArgs e)
        {
            if(RedLight.BackColor == Color.Gray)
            {
                RedLight.BackColor = Color.Red;
            
            }
            else
            {
                RedLight.BackColor = Color.Gray;
                
            }
            if(YellowLight.BackColor == Color.Gray)
            {
                YellowLight.BackColor = Color.Yellow;
            }
            else
            {
                YellowLight.BackColor = Color.Gray;
            }
            if (GreenLight.BackColor == Color.Gray)
            {
                GreenLight.BackColor = Color.Green;
            }
            else
            {
                GreenLight.BackColor = Color.Green;
            }
        }


        private void InitalizeTrafficLights()
        {
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
        }
    }
}
