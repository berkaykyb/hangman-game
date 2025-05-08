using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Week7_PreLab
{
    public partial class Settings : Form
    {
        public static List<string> SelectedCategories { get; private set; } = new List<string>();
        public static string SelectedDifficulty { get; private set; }
        public static string SelectedTime { get; private set; }

        public static string SelectedTheme { get; set; }

        public Settings()
        {
            InitializeComponent();
            checkBox_Celebrities.Checked = true;
            checkBox_geography.Checked = true;
            checkBox_history.Checked = true;
            checkBox_sport.Checked = true;
            checkBox_math.Checked = true;
            checkBox_science.Checked = true;

            comboBoxDifficulty.Items.AddRange(new string[] { "Easy", "Medium", "Hard" });
            comboBoxTime.Items.AddRange(new string[] { "30 seconds", "60 seconds", "90 seconds", "120 seconds" });
            comboBoxTheme.Items.AddRange(new string[] { "Man", "Stick_Man","Flower"});
            comboBoxDifficulty.SelectedIndex = 0;
            comboBoxTime.SelectedIndex = 1;
            comboBoxTheme.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SelectedCategories.Clear();
            if (checkBox_Celebrities.Checked)
                SelectedCategories.Add("celebrities");
            if (checkBox_geography.Checked)
                SelectedCategories.Add("geography");
            if (checkBox_history.Checked)
                SelectedCategories.Add("history");
            if (checkBox_sport.Checked)
                SelectedCategories.Add("sports");
            if (checkBox_math.Checked)
                SelectedCategories.Add("math");
            if (checkBox_science.Checked)
                SelectedCategories.Add("science");

            if (SelectedCategories.Count == 0)
            {
                MessageBox.Show("You must select at least one category.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedDifficulty = comboBoxDifficulty.SelectedItem?.ToString();
            SelectedTime = comboBoxTime.SelectedItem?.ToString().Split(' ')[0];
            SelectedTheme = comboBoxTheme.SelectedItem?.ToString();

            if (Application.OpenForms["Form1"] is Form1 form1)
            {
                form1.UpdateBackground();
            }

            this.Close();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            checkBox_Celebrities.Checked = true;
            checkBox_geography.Checked = true;
            checkBox_history.Checked = true;
            checkBox_sport.Checked = true;
            checkBox_math.Checked = true;
            checkBox_science.Checked = true;
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            checkBox_Celebrities.Checked = false;
            checkBox_geography.Checked = false;
            checkBox_history.Checked = false;
            checkBox_sport.Checked = false;
            checkBox_math.Checked = false;
            checkBox_science.Checked = false;
        }
    }
}
