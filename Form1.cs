using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_8_Hangman
{
    public partial class frmHangman : Form
    {
        string secretWord;
        string displayWord;
        int guesses;
        int lives;
        public frmHangman()
        {
            InitializeComponent();
            secretWord = "SAVATHUN";
            displayWord = "--------";
            guesses = 0;
            lives = 3;
            lblLives.Text = $"lives:{lives}";
            imgfull.Visible = false;
            imgHangmanTwoThirds.Visible = false;
            imgHangmanOneThird.Visible = false;
            imgHangmanBase.Visible = true;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guessedLetter = txtGuess.Text.ToUpper();

            guesses += 1;

            if(guessedLetter.IndexOf("S") == 0)
            {
                int index = secretWord.IndexOf("S");
                displayWord = displayWord.Remove(index, 1);
                displayWord = displayWord.Insert(index, guessedLetter);
                lblWord.Text = displayWord;
            }

            else if (guessedLetter.IndexOf("A") == 0)
            {
                int index = secretWord.IndexOf("A");
                displayWord = displayWord.Remove(index, 1);
                displayWord = displayWord.Insert(index, guessedLetter);
                lblWord.Text = displayWord;

                int index2 = secretWord.LastIndexOf("A");
                displayWord = displayWord.Remove(index2, 1);
                displayWord = displayWord.Insert(index2, guessedLetter);
                lblWord.Text = displayWord;
            }

            else if (guessedLetter.IndexOf("V") == 0)
            {
                int index = secretWord.IndexOf("V");
                displayWord = displayWord.Remove(index, 1);
                displayWord = displayWord.Insert(index, guessedLetter);
                lblWord.Text = displayWord;
            }

            else if (guessedLetter.IndexOf("H") == 0)
            {
                int index = secretWord.IndexOf("H");
                displayWord = displayWord.Remove(index, 1);
                displayWord = displayWord.Insert(index, guessedLetter);
                lblWord.Text = displayWord;
            }

            else if (guessedLetter.IndexOf("U") == 0)
            {
                int index = secretWord.IndexOf("U");
                displayWord = displayWord.Remove(index, 1);
                displayWord = displayWord.Insert(index, guessedLetter);
                lblWord.Text = displayWord;
            }

            else if (guessedLetter.IndexOf("T") == 0)
            {
                int index = secretWord.IndexOf("T");
                displayWord = displayWord.Remove(index, 1);
                displayWord = displayWord.Insert(index, guessedLetter);
                lblWord.Text = displayWord;
            }

            else if (guessedLetter.IndexOf("N") == 0)
            {
                int index = secretWord.IndexOf("N");
                displayWord = displayWord.Remove(index, 1);
                displayWord = displayWord.Insert(index, guessedLetter);
                lblWord.Text = displayWord;
            }


            else
            {
                imgHangmanBase.Visible = false;
                lives -= 1;
                lblLives.Text = $"lives:{lives}";
                lstGuessedLetters.Items.Add(guessedLetter);

                if(lives == 2)
                {
                    imgHangmanOneThird.Visible = true;
                }

                if (lives == 1)
                {
                    imgHangmanOneThird.Visible = false;
                    imgHangmanTwoThirds.Visible = true;
                }
                if (lives == 0)
                {
                    imgHangmanTwoThirds.Visible = false;
                    imgfull.Visible = true;
                    lblTitle.Text = "Game over";
                }
            }
        }
    }
}
