using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Random Rnd = new Random();
        private Master MainMaster;


        private void Manual_B_Click(object sender, EventArgs e)
        {
            Timer_T_Tick(this, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainMaster = new Master(LogStudent_TB, Stat_TB);
            MainMaster.Chance = Convert.ToInt32(Input_NUD.Value);
            MainMaster.CountStudent = Convert.ToInt32(Count_NUD.Value);
            MainMaster.AddCabinet(new Cabinet(Current_TB));
            MainMaster.AddQueue(new StudentQueue(0, One_LB));
            MainMaster.AddQueue(new StudentQueue(1, Two_LB));
            MainMaster.AddQueue(new StudentQueue(2, Three_LB));
            MainMaster.AddQueue(new StudentQueue(3, For_LB));
            MainMaster.AddQueue(new StudentQueue(4, Five_LB));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer_T_Tick(object sender, EventArgs e)
        {
            MainMaster.OnTimer();
        }
        private void SetMode(object sender, EventArgs e)
        {
            Manual_B.Enabled = Manual_RB.Checked;
            Timer_T.Enabled = Auto_RB.Checked;
            Stat_B.Enabled = Manual_RB.Checked;
        }

        private void Manual_RB_CheckedChanged(object sender, EventArgs e)
        {
            SetMode(sender, e);
        }

        private void Auto_RB_CheckedChanged(object sender, EventArgs e)
        {
            SetMode(sender, e);
        }

        private void Stat_B_Click(object sender, EventArgs e)
        {
            MainMaster.SetStatCabinet();
        }

        private void Input_NUD_ValueChanged(object sender, EventArgs e)
        {
            MainMaster.Chance = Convert.ToInt32(Input_NUD.Value);
        }

        private void Count_NUD_ValueChanged(object sender, EventArgs e)
        {
            MainMaster.CountStudent = Convert.ToInt32(Count_NUD.Value);
        }

    }
}
