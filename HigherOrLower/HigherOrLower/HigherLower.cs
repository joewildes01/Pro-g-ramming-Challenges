using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HigherOrLower
{
    public partial class HigherLower : Form
    {
        private Random random = new Random();
        private int currentNum = 0;
        private int lockedNum = 0;
        private int score = 0;


        public HigherLower()
        {
            InitializeComponent();

            currentNum = random.Next(0, 100);
            lockedNum = currentNum;
            MainCountlbl.Text = currentNum.ToString();
            stsText.Visible = false;

        }

        private void btnHigher_Click(object sender, EventArgs e)
        {
            currentNum = random.Next(0, 100);
            MainCountlbl.Text = currentNum.ToString();

            if (lockedNum > currentNum)
            {
                Lose();
            }
            else
            {
                score++;
                txtScore.Text = score.ToString();
                lockedNum = currentNum;
            }

        }
        private void Lose()
        {
            stsText.Text = "You lose";
            stsText.Visible = true;
            MainCountlbl.ForeColor = Color.Red;

            btnHigher.Enabled = false;
            btnLower.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            score = 0;

            currentNum = random.Next(0, 100);
            lockedNum = currentNum;
            MainCountlbl.Text = currentNum.ToString();
            stsText.Visible = false;

            btnHigher.Enabled = true;
            btnLower.Enabled = true;

            MainCountlbl.ForeColor = Color.Black;
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            currentNum = random.Next(0, 100);
            MainCountlbl.Text = currentNum.ToString();

            if (lockedNum < currentNum)
            {
                Lose();
            }
            else
            {
                score++;
                txtScore.Text = score.ToString();
                lockedNum = currentNum;
            }
        }
    }
}
