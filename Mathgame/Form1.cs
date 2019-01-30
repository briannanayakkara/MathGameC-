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
    public partial class Form1 : Form
    {
        double score =159;
        string name = "brian";
        public Form1()
        {
            InitializeComponent();

            //GetHighScore();

        }

        public  void textBoxName_TextChanged(object sender, EventArgs e)
        {
           
            if (textBoxName.Text == "")
            {
                ButtonPlay.Enabled = false;
            }
            else
            {
                ButtonPlay.Enabled = true;
            }
        }


       
        public void ButtonPlay_Click(object sender, EventArgs e)
        {

            TheGame openTheGame = new TheGame();

            openTheGame.name = textBoxName.Text;
            openTheGame.Show();
        }



       /* public void GetHighScore()
        {

            //TheGame game = new TheGame();
            //name = textBoxName.Text;
            //this.score = game.score;
            labelHighScore.Text = name + " has the high score of " + score.ToString();



        }*/
    }
}
