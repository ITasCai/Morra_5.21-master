using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morra_5._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //用户点击石头
        private void button4_Click(object sender, EventArgs e)
        {

            //怎么获取当前用户点击的是哪个按钮
            Button btn = (Button)sender;
            string userfist = btn.Text;
            StartGame(userfist);
        }

   
        private void StartGame(string userfist)
        {
            //实例化一个用户
            Player p1 = new Player();
            int playerfist = p1.ShowFist(userfist);
            this.user.Text = p1.Fist1;

            //实例化一个计算机
            PC pc = new PC();
            int pcfist = pc.ShowFist();
            this.pc.Text = pc.Fist1;

            //比较出拳结果
            int r = CaiPan.IsPlayerWin(playerfist,pcfist);
            switch (r)
            {
                case 0:
                    jieguo.Text = "平局";
                    break;
                case 1:
                    jieguo.Text = "赢了";
                    break;
                case -1:
                    jieguo.Text = "输了";
                    break;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string userfist = btn.Text;
            StartGame(userfist);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string userfist = btn.Text;
            StartGame(userfist);
        }
    }
}
