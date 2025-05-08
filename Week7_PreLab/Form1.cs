using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Week7_PreLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_startGame_Click(object sender, EventArgs e)
        {
            Form2 gamescreen = new Form2();
            gamescreen.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Settings.SelectedTheme))
            {
                Settings.SelectedTheme = "Man";
            }


            UpdateBackground();
        }

        public void UpdateBackground()
        {
            string bgPath = "backgrounds/" + Settings.SelectedTheme + ".jpg";
            if (File.Exists(bgPath))
            {
                this.BackgroundImage = Image.FromFile(bgPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (Settings.SelectedTheme == "Stick_Man")
            {
                btn_startGame.BackColor = Color.LightSkyBlue;
                btn_settings.BackColor = Color.LightSkyBlue;
            }
            else if (Settings.SelectedTheme == "Man")
            {
                btn_startGame.BackColor = Color.Green;
                btn_settings.BackColor = Color.Green;
            }
            else if (Settings.SelectedTheme == "Flower")
            {
                btn_startGame.BackColor = Color.Green;
                btn_settings.BackColor = Color.Green;
            }
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                var selectedCategories = Settings.SelectedCategories;
                var selectedDifficulty = Settings.SelectedDifficulty;
            }
        }
    }
}
