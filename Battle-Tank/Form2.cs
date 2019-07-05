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
            count = 0;
            flag = 0;
            timer3.Start();
        }
        //Function for moving panels
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

        //Loading scene and changing from form2 to the MainScene
        //
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
   
        //Тајмер кој ни овозможува после 5 секунди замена од форма2 на Мејн син.
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
