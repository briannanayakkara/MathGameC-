using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathgame
{
    public partial class TheGame : Form
    {
        Random rn = new Random();
        public double score,ranD1,ranD2,answer,answerShould,HighScore = 0;
        public int wrongAnswer = 0,time =121;
        public string name,Msymbols,HighScoreName;
        Form1 f1 = new Form1();

        public TheGame()
        {
            InitializeComponent();
            
            CountTheScore();
            SetTimer();
            ShowHighScore();
            if (time > 60)
            {
                SetValue();
            }
            if (time < 60)
            {
                level();
            }
            

        }

        // when press enter after giving the answer 
        private void textBoxAnswe_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                answer = double.Parse(textBoxAnswe.Text);
                textBoxAnswe.Clear();
                //MessageBox.Show(labelFormula.Text +" " + " = " + answer.ToString());
                CountTheScore();
                //MessageBox.Show(score.ToString());
                if (time > 60)
                {
                    SetValue();
                }
                if (time < 60)
                {
                    level();
                }
                SetScore();
                SetWrong();
                ShowHighScore();
            }
            
        }

        private void textBoxAnswe_TextChanged(object sender, EventArgs e)
        {

   
        }

        // time
        private void timer1_Tick(object sender, EventArgs e)
        {
            SetTimer();
        }

        public void SetTimer()
        {
            timer1.Enabled = true;
            timer1.Start();
            textBoxTime.Text = time.ToString();
            time--;
            textBoxTime.Text = time.ToString();
            if (time == 0)
            {
                timer1.Stop();
            }

            if (time == 0)
            {
                GameOver();
            }
        }


        public void SetValue()
        {
            ranD1 = rn.Next(50);
            ranD2 = rn.Next(5);
            char[] symbols = "+-*/".ToCharArray();
            //make the char to a sring 
            Msymbols = symbols[rn.Next(0, 3)].ToString();
            labelFormula.Text = ranD1.ToString() + " " + Msymbols + " " + ranD2.ToString() ;
        }

        public void SetScore()
        {
            labelScore.Text = score.ToString();
        }
        public void SetWrong()
        {
            labelWrong.Text = wrongAnswer.ToString();
        }

        public void GameOver()
        {
            MessageBox.Show("Game over");
            this.Close();
            MessageBox.Show("Your score is = " + score);
        }

        // game level

            public void level()
        {
                ranD1 = rn.Next(50);
                ranD2 = rn.Next(10);
                char[] symbols = "+-*/".ToCharArray();
                //make the char to a sring 
                Msymbols = symbols[rn.Next(0, 4)].ToString();
                labelFormula.Text = ranD1.ToString() + " " + Msymbols + " " + ranD2.ToString();
        }

        public void CountTheScore()
        {
            switch (Msymbols)
            {
                case "+":
                    answerShould = ranD1 + ranD2;
                    break;
                case "-":
                    answerShould = ranD1 - ranD2;
                    break;
                case "*":
                    answerShould = ranD1 * ranD2;
                    break;
                case "/":
                    answerShould = ranD1 / ranD2;
                    break;

                default:
                    break;
            }


            if (answer == answerShould)
            {
                score++;
                //time = 11;
            }
            if (answer != answerShould)
            {
                wrongAnswer +=1;
            }
            if (wrongAnswer == 4)
            {
                GameOver();
            }

        }

        public void ShowHighScore()
        {
            if (score >= HighScore)
            {
                HighScore = score;
                HighScoreName = name;
                labelHighScore.Text = name + " has the high score of " + score.ToString();
            }
            else
            {
                HighScore = HighScore;
                HighScoreName = HighScoreName;
                labelHighScore.Text = name + " has the high score of " + score.ToString();
            }

           
            //name + " has the high score of " + score.ToString();
        }
    }
}
