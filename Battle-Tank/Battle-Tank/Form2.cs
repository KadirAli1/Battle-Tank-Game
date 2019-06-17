using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Tank
{
    public partial class Form2 : Form
    {
        Timer timer1 = new Timer();
        public Form2()
        {
            InitializeComponent();
        }
        int plus = 1;
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

            timer1.Tick += new EventHandler(move);
            timer1.Interval = 10;
            timer1.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
