using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingDGrizzles_Scammer_Bingo
{
    public partial class MainScreen : Form
    {
        public int score = 0;
        public String scoreString;
        public String scoreStringDefault = "0 / 24";

        score12Dialog score12Dialog = new score12Dialog();
        aboutDialog aboutDialog = new aboutDialog();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 232, 232);
        }

        public void handlerScore()
        {
            score++;
            //score = 12;
            score1224();
            scoreString = score.ToString() + " / 24";
            scoreLabel.Text = scoreString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            handlerScore();
        }

        public void score1224()
        {
            if(score == 12)
            {
                score12Dialog.Show();
            }
            if(score == 24)
            {
                MessageBox.Show("Balls");
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score = 0;
            scoreLabel.Text = scoreStringDefault;
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutDialog.Show();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {}
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {}
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            handlerScore();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            handlerScore();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            handlerScore();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            handlerScore();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            handlerScore();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            handlerScore();
        }
        private void button2_Click_1(object sender, EventArgs e) {}
        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            handlerScore();
        }
    }
}
