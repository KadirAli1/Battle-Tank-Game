using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Tank_Game
{
    public partial class Form2 : Form
    {
        Timer timer1 = new Timer();
        public MainScene mainscene;
        int count;
        int flag;
        int plus = 1;
        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            timer1.Start();
            //timer2.Interval = 1000;
            //timer2.Tick += new EventHandler(Timer2_Tick);

            //timer2.Enabled = true;

            button1.Click += new EventHandler(Button1_Click);
            count = 0;
            flag = 0;
            timer3.Start();
        }
        
        void move(object sender, EventArgs e)
        {
            panel2.Left += plus;

            if (panel2.Left > 322)
            {
                plus = -1;
            }
            if (panel2.Left < 0)
            {
                plus = 1;
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            MainScene mainScene = new MainScene();
            timer1.Tick += new EventHandler(move);
            timer1.Interval = 10;
            timer1.Start();
            //Duhet Diskutim
            if(timer1.Interval >= 100)
            {
                MainScene mn = new MainScene();
                if (mn.ShowDialog() == DialogResult.OK)
                {
                    mn.AddOwnedForm(mainscene);
                    timer1.Stop();
                }
                this.Close();
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            

        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.Orange;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = Form2.DefaultBackColor;
        }
      

        private void Timer2_Tick(object sender, EventArgs e)
        {
           
        }
        
        private void Timer3_Tick(object sender, EventArgs e)
        {
            count++;
            if(count == 5)
            {
                MainScene mn = new MainScene();
                this.Hide();
                mn.ShowDialog();
                timer3.Stop();
                this.Close();
            }
            
        }
        
      
    }
}
