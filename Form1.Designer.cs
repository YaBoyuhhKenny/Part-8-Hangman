namespace Part_8_Hangman
{
    partial class frmHangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lstGuessedLetters = new System.Windows.Forms.ListBox();
            this.lblLetters = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.imgHangmanBase = new System.Windows.Forms.PictureBox();
            this.imgHangmanOneThird = new System.Windows.Forms.PictureBox();
            this.imgHangmanTwoThirds = new System.Windows.Forms.PictureBox();
            this.imgfull = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangmanBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangmanOneThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangmanTwoThirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgfull)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(124, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hang Man";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(87, 358);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(32, 73);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "\r\n";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblInstructions.Location = new System.Drawing.Point(97, 54);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(330, 36);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "guess letters to uncover the secret word, \r\nevery incorrect guesses gets you clos" +
    "er to losing";
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(35, 320);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(59, 22);
            this.txtGuess.TabIndex = 3;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.Color.Black;
            this.btnGuess.Location = new System.Drawing.Point(100, 313);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(59, 29);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lstGuessedLetters
            // 
            this.lstGuessedLetters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuessedLetters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstGuessedLetters.FormattingEnabled = true;
            this.lstGuessedLetters.ItemHeight = 16;
            this.lstGuessedLetters.Location = new System.Drawing.Point(35, 175);
            this.lstGuessedLetters.Name = "lstGuessedLetters";
            this.lstGuessedLetters.Size = new System.Drawing.Size(124, 132);
            this.lstGuessedLetters.TabIndex = 5;
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLetters.Location = new System.Drawing.Point(31, 152);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(113, 20);
            this.lblLetters.TabIndex = 7;
            this.lblLetters.Text = "Used Letters";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Location = new System.Drawing.Point(29, 8);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(0, 13);
            this.lblLives.TabIndex = 8;
            // 
            // imgHangmanBase
            // 
            this.imgHangmanBase.BackgroundImage = global::Part_8_Hangman.Properties.Resources.hangman4;
            this.imgHangmanBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHangmanBase.Location = new System.Drawing.Point(196, 113);
            this.imgHangmanBase.Name = "imgHangmanBase";
            this.imgHangmanBase.Size = new System.Drawing.Size(181, 243);
            this.imgHangmanBase.TabIndex = 12;
            this.imgHangmanBase.TabStop = false;
            // 
            // imgHangmanOneThird
            // 
            this.imgHangmanOneThird.BackgroundImage = global::Part_8_Hangman.Properties.Resources.hangman3;
            this.imgHangmanOneThird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHangmanOneThird.Location = new System.Drawing.Point(196, 113);
            this.imgHangmanOneThird.Name = "imgHangmanOneThird";
            this.imgHangmanOneThird.Size = new System.Drawing.Size(181, 243);
            this.imgHangmanOneThird.TabIndex = 11;
            this.imgHangmanOneThird.TabStop = false;
            // 
            // imgHangmanTwoThirds
            // 
            this.imgHangmanTwoThirds.BackgroundImage = global::Part_8_Hangman.Properties.Resources.hangman2;
            this.imgHangmanTwoThirds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHangmanTwoThirds.Location = new System.Drawing.Point(196, 113);
            this.imgHangmanTwoThirds.Name = "imgHangmanTwoThirds";
            this.imgHangmanTwoThirds.Size = new System.Drawing.Size(181, 243);
            this.imgHangmanTwoThirds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHangmanTwoThirds.TabIndex = 10;
            this.imgHangmanTwoThirds.TabStop = false;
            // 
            // imgfull
            // 
            this.imgfull.BackgroundImage = global::Part_8_Hangman.Properties.Resources.hangman;
            this.imgfull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgfull.Location = new System.Drawing.Point(196, 113);
            this.imgfull.Name = "imgfull";
            this.imgfull.Size = new System.Drawing.Size(181, 243);
            this.imgfull.TabIndex = 9;
            this.imgfull.TabStop = false;
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(510, 467);
            this.Controls.Add(this.imgHangmanBase);
            this.Controls.Add(this.imgHangmanOneThird);
            this.Controls.Add(this.imgHangmanTwoThirds);
            this.Controls.Add(this.imgfull);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.lstGuessedLetters);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmHangman";
            this.Text = "Hang Man";
            ((System.ComponentModel.ISupportInitialize)(this.imgHangmanBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangmanOneThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangmanTwoThirds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgfull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.ListBox lstGuessedLetters;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.PictureBox imgfull;
        private System.Windows.Forms.PictureBox imgHangmanTwoThirds;
        private System.Windows.Forms.PictureBox imgHangmanOneThird;
        private System.Windows.Forms.PictureBox imgHangmanBase;
    }
}

