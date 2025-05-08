namespace Week7_PreLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_gameName = new Label();
            btn_startGame = new Button();
            btn_settings = new Button();
            SuspendLayout();
            // 
            // label_gameName
            // 
            label_gameName.AutoSize = true;
            label_gameName.BackColor = Color.Transparent;
            label_gameName.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_gameName.Location = new Point(574, 342);
            label_gameName.Name = "label_gameName";
            label_gameName.Size = new Size(525, 128);
            label_gameName.TabIndex = 0;
            label_gameName.Text = "Hangman";
            // 
            // btn_startGame
            // 
            btn_startGame.BackColor = Color.Green;
            btn_startGame.Cursor = Cursors.Hand;
            btn_startGame.FlatAppearance.BorderSize = 0;
            btn_startGame.FlatStyle = FlatStyle.Flat;
            btn_startGame.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_startGame.ForeColor = Color.Black;
            btn_startGame.Location = new Point(670, 499);
            btn_startGame.Name = "btn_startGame";
            btn_startGame.Size = new Size(349, 80);
            btn_startGame.TabIndex = 1;
            btn_startGame.Text = "Start";
            btn_startGame.UseVisualStyleBackColor = false;
            btn_startGame.Click += btn_startGame_Click;
            // 
            // btn_settings
            // 
            btn_settings.BackColor = Color.Green;
            btn_settings.Cursor = Cursors.Hand;
            btn_settings.FlatAppearance.BorderSize = 0;
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_settings.ForeColor = Color.Black;
            btn_settings.Location = new Point(670, 601);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(349, 80);
            btn_settings.TabIndex = 3;
            btn_settings.Text = "Settings";
            btn_settings.UseVisualStyleBackColor = false;
            btn_settings.Click += btn_settings_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1731, 870);
            Controls.Add(btn_settings);
            Controls.Add(btn_startGame);
            Controls.Add(label_gameName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_gameName;
        private Button btn_startGame;
        private Button btn_settings;
    }
}
