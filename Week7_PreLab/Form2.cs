using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Week7_PreLab
{
    public partial class Form2 : Form
    {
        private List<(string Category, string Word, string Hint, string Difficulty)> allQuestions = new List<(string, string, string, string)>();
        private string selectedWord;
        private string displayWord;
        private List<char> wrongGuesses = new List<char>();
        private int wrongCount = 0;
        private int score = 0;
        private int maxWrong = 10;
        private int timeLeft = 60;

        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MakePictureBoxRound(pictureBoxInfo);
            pictureBoxInfo.Image = Image.FromFile("img/information.png");
            pictureBoxInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Visible = false;
            LoadQuestionsFromFile();
            StartGame();
            this.AcceptButton = btn_guess;
        }

        private void LoadQuestionsFromFile()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "questions.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("questions.txt dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            foreach (string line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');
                if (parts.Length == 4)
                {
                    allQuestions.Add((parts[0], parts[1], parts[2], parts[3]));
                }
            }
        }

        private void StartGame()
        {
            string bgPath = "backgrounds/" + Settings.SelectedTheme + ".jpg"; ;
            if (File.Exists(bgPath))
            {
                this.BackgroundImage = Image.FromFile(bgPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }

            var filteredQuestions = allQuestions
                .Where(q => Settings.SelectedCategories.Contains(q.Category) && q.Difficulty == Settings.SelectedDifficulty)
                .ToList();

            if (filteredQuestions.Count == 0)
            {
                MessageBox.Show("No questions found for selected categories and difficulty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random random = new Random();
            var selected = filteredQuestions[random.Next(filteredQuestions.Count)];
            selectedWord = selected.Word.ToLower();
            displayWord = new string('_', selectedWord.Length);
            wrongGuesses.Clear();
            wrongCount = 0;
            score = 100;
            this.BackColor = SystemColors.Control;

            lbl_word.Text = string.Join(" ", displayWord.ToCharArray());
            lbl_wordLength.Text = "Word Length : " + selectedWord.Length;
            lbl_wrongPredict.Text = "Wrong Predictions :";
            lbl_score.Text = "Score : " + score;
            lbl_hint.Text = "";

            UpdateHangmanImage();
        }

        private void btn_hint_Click(object sender, EventArgs e)
        {
            var hint = allQuestions.FirstOrDefault(q => q.Word == selectedWord).Hint;
            lbl_hint.Text = "Hint: " + hint;

            if (!timerGame.Enabled)
            {
                timeLeft = int.Parse(Settings.SelectedTime);
                lblTimer.Text = "Time : " + timeLeft;
                timerGame.Start();
            }
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            string guess = txtbox_guess.Text.ToLower();
            txtbox_guess.Clear();

            if (guess.Length != 1 || string.IsNullOrWhiteSpace(guess) || !char.IsLetter(guess[0]))
            {
                MessageBox.Show("Please enter a single letter.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char guessedChar = guess[0];

            if (displayWord.Contains(guessedChar) || wrongGuesses.Contains(guessedChar))
            {
                MessageBox.Show("You already guessed that letter!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selectedWord.Contains(guessedChar))
            {
                char[] displayChars = displayWord.ToCharArray();
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == guessedChar)
                    {
                        displayChars[i] = guessedChar;
                    }
                }
                displayWord = new string(displayChars);
                lbl_word.Text = string.Join(" ", displayWord.ToCharArray());

                if (!displayWord.Contains('_'))
                {
                    this.BackColor = Color.Green;
                    var result = MessageBox.Show("Congratulations! You've guessed the word: " + selectedWord, "YOU WON!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Retry)
                    {
                        StartGame();
                    }
                }
            }
            else
            {
                if (!wrongGuesses.Contains(guessedChar))
                {
                    wrongGuesses.Add(guessedChar);
                    wrongCount++;
                    score -= 10;

                    lbl_wrongPredict.Text += guessedChar + " ";
                    lbl_score.Text = "Score : " + score;

                    UpdateHangmanImage();
                }

                if (wrongCount >= maxWrong)
                {
                    this.BackColor = Color.Red;
                    var result = MessageBox.Show("Game Over! The word was: " + selectedWord, "YOU LOSE!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        StartGame();
                    }
                }
            }
        }

        private void UpdateHangmanImage()
        {
            int imageIndex = wrongCount + 1;

            if (imageIndex <= 10)
            {
                string imagePath = $"img/{Settings.SelectedTheme}-{imageIndex:D2}.jpg";
                if (File.Exists(imagePath))
                {
                    pbHangman.Image = Image.FromFile(imagePath);
                    pbHangman.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbHangman.Image = null;
                }
            }
        }

        private void MakePictureBoxRound(PictureBox pic)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pic.Width, pic.Height);
            pic.Region = new Region(path);
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end the game?", "End Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You are leaving the game.");

                this.Close();

                foreach (Form form in Application.OpenForms)
                {
                    if (form is Form1)
                    {
                        form.Show();
                        break;
                    }
                }
            }
        }


        private void timerGame_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimer.Text = "Time: " + timeLeft;
            }
            else
            {
                timerGame.Stop();
                this.BackColor = Color.Red;
                MessageBox.Show("Time's up! You lost. The word was: " + selectedWord, "Time Over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (MessageBox.Show("Retry?", "New Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StartGame();
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void pictureBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBoxInfo.Visible = true;
        }

        private void pictureBoxInfo_MouseEnter(object sender, EventArgs e)
        {        
            label1.Visible = true;               
            label1.BringToFront();
        }
    }
}
