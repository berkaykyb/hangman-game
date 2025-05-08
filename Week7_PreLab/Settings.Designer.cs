namespace Week7_PreLab
{
    partial class Settings
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
            groupBox_category = new GroupBox();
            buttonDeleteSelected = new Button();
            buttonSelectAll = new Button();
            checkBox_science = new CheckBox();
            checkBox_sport = new CheckBox();
            checkBox_Celebrities = new CheckBox();
            checkBox_geography = new CheckBox();
            checkBox_history = new CheckBox();
            checkBox_math = new CheckBox();
            comboBoxDifficulty = new ComboBox();
            label1 = new Label();
            buttonSave = new Button();
            labelTime = new Label();
            comboBoxTime = new ComboBox();
            labelTheme = new Label();
            comboBoxTheme = new ComboBox();
            groupBox_category.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_category
            // 
            groupBox_category.Controls.Add(buttonDeleteSelected);
            groupBox_category.Controls.Add(buttonSelectAll);
            groupBox_category.Controls.Add(checkBox_science);
            groupBox_category.Controls.Add(checkBox_sport);
            groupBox_category.Controls.Add(checkBox_Celebrities);
            groupBox_category.Controls.Add(checkBox_geography);
            groupBox_category.Controls.Add(checkBox_history);
            groupBox_category.Controls.Add(checkBox_math);
            groupBox_category.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox_category.Location = new Point(19, 26);
            groupBox_category.Name = "groupBox_category";
            groupBox_category.Size = new Size(700, 174);
            groupBox_category.TabIndex = 0;
            groupBox_category.TabStop = false;
            groupBox_category.Text = "Question Categories";
            // 
            // buttonDeleteSelected
            // 
            buttonDeleteSelected.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteSelected.Location = new Point(500, 96);
            buttonDeleteSelected.Name = "buttonDeleteSelected";
            buttonDeleteSelected.Size = new Size(170, 30);
            buttonDeleteSelected.TabIndex = 7;
            buttonDeleteSelected.Text = "Delete Selected";
            buttonDeleteSelected.UseVisualStyleBackColor = true;
            buttonDeleteSelected.Click += buttonDeleteSelected_Click;
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSelectAll.Location = new Point(500, 50);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(170, 30);
            buttonSelectAll.TabIndex = 6;
            buttonSelectAll.Text = "Select All";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += buttonSelectAll_Click;
            // 
            // checkBox_science
            // 
            checkBox_science.AutoSize = true;
            checkBox_science.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox_science.Location = new Point(203, 122);
            checkBox_science.Name = "checkBox_science";
            checkBox_science.Size = new Size(121, 36);
            checkBox_science.TabIndex = 5;
            checkBox_science.Text = "Science";
            checkBox_science.UseVisualStyleBackColor = true;
            // 
            // checkBox_sport
            // 
            checkBox_sport.AutoSize = true;
            checkBox_sport.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox_sport.Location = new Point(203, 80);
            checkBox_sport.Name = "checkBox_sport";
            checkBox_sport.Size = new Size(101, 36);
            checkBox_sport.TabIndex = 4;
            checkBox_sport.Text = "Sport";
            checkBox_sport.UseVisualStyleBackColor = true;
            // 
            // checkBox_Celebrities
            // 
            checkBox_Celebrities.AutoSize = true;
            checkBox_Celebrities.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox_Celebrities.Location = new Point(203, 38);
            checkBox_Celebrities.Name = "checkBox_Celebrities";
            checkBox_Celebrities.Size = new Size(154, 36);
            checkBox_Celebrities.TabIndex = 3;
            checkBox_Celebrities.Text = "Celebrities";
            checkBox_Celebrities.UseVisualStyleBackColor = true;
            // 
            // checkBox_geography
            // 
            checkBox_geography.AutoSize = true;
            checkBox_geography.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox_geography.Location = new Point(6, 122);
            checkBox_geography.Name = "checkBox_geography";
            checkBox_geography.Size = new Size(161, 36);
            checkBox_geography.TabIndex = 2;
            checkBox_geography.Text = "Geography";
            checkBox_geography.UseVisualStyleBackColor = true;
            // 
            // checkBox_history
            // 
            checkBox_history.AutoSize = true;
            checkBox_history.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox_history.Location = new Point(6, 80);
            checkBox_history.Name = "checkBox_history";
            checkBox_history.Size = new Size(120, 36);
            checkBox_history.TabIndex = 1;
            checkBox_history.Text = "History";
            checkBox_history.UseVisualStyleBackColor = true;
            // 
            // checkBox_math
            // 
            checkBox_math.AutoSize = true;
            checkBox_math.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox_math.Location = new Point(6, 38);
            checkBox_math.Name = "checkBox_math";
            checkBox_math.Size = new Size(100, 36);
            checkBox_math.TabIndex = 0;
            checkBox_math.Text = "Math";
            checkBox_math.UseVisualStyleBackColor = true;
            // 
            // comboBoxDifficulty
            // 
            comboBoxDifficulty.FormattingEnabled = true;
            comboBoxDifficulty.Location = new Point(25, 260);
            comboBoxDifficulty.Name = "comboBoxDifficulty";
            comboBoxDifficulty.Size = new Size(390, 40);
            comboBoxDifficulty.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 225);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 2;
            label1.Text = "Difficulty";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(509, 486);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(210, 54);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.Location = new Point(25, 335);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(70, 32);
            labelTime.TabIndex = 4;
            labelTime.Text = "Time";
            // 
            // comboBoxTime
            // 
            comboBoxTime.FormattingEnabled = true;
            comboBoxTime.Location = new Point(25, 370);
            comboBoxTime.Name = "comboBoxTime";
            comboBoxTime.Size = new Size(161, 40);
            comboBoxTime.TabIndex = 5;
            // 
            // labelTheme
            // 
            labelTheme.AutoSize = true;
            labelTheme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTheme.Location = new Point(295, 335);
            labelTheme.Name = "labelTheme";
            labelTheme.Size = new Size(90, 32);
            labelTheme.TabIndex = 6;
            labelTheme.Text = "Theme";
            // 
            // comboBoxTheme
            // 
            comboBoxTheme.FormattingEnabled = true;
            comboBoxTheme.Location = new Point(295, 370);
            comboBoxTheme.Name = "comboBoxTheme";
            comboBoxTheme.Size = new Size(308, 40);
            comboBoxTheme.TabIndex = 7;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(comboBoxTheme);
            Controls.Add(labelTheme);
            Controls.Add(comboBoxTime);
            Controls.Add(labelTime);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(comboBoxDifficulty);
            Controls.Add(groupBox_category);
            Name = "Settings";
            Text = "Settings";
            groupBox_category.ResumeLayout(false);
            groupBox_category.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_category;
        private CheckBox checkBox_science;
        private CheckBox checkBox_sport;
        private CheckBox checkBox_Celebrities;
        private CheckBox checkBox_geography;
        private CheckBox checkBox_history;
        private CheckBox checkBox_math;
        private Button buttonDeleteSelected;
        private Button buttonSelectAll;
        private ComboBox comboBoxDifficulty;
        private Label label1;
        private Button buttonSave;
        private Label labelTime;
        private ComboBox comboBoxTime;
        private Label labelTheme;
        private ComboBox comboBoxTheme;
    }
}