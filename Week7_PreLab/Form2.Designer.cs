namespace Week7_PreLab
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lbl_word = new Label();
            btn_hint = new Button();
            lbl_wordLength = new Label();
            lbl_wrongPredict = new Label();
            lbl_score = new Label();
            txtbox_guess = new TextBox();
            btn_guess = new Button();
            btn_finish = new Button();
            lbl_hint = new Label();
            pbHangman = new PictureBox();
            timerGame = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            label1 = new Label();
            pictureBoxInfo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbHangman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo).BeginInit();
            SuspendLayout();
            // 
            // lbl_word
            // 
            lbl_word.AutoSize = true;
            lbl_word.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_word.Location = new Point(473, 51);
            lbl_word.Name = "lbl_word";
            lbl_word.Size = new Size(326, 71);
            lbl_word.TabIndex = 0;
            lbl_word.Text = "_ _ _ _ _ _ _ _ ";
            // 
            // btn_hint
            // 
            btn_hint.BackColor = SystemColors.ActiveCaption;
            btn_hint.Location = new Point(474, 270);
            btn_hint.Name = "btn_hint";
            btn_hint.Size = new Size(216, 48);
            btn_hint.TabIndex = 1;
            btn_hint.Text = "Hint¿";
            btn_hint.UseVisualStyleBackColor = false;
            btn_hint.Click += btn_hint_Click;
            // 
            // lbl_wordLength
            // 
            lbl_wordLength.AutoSize = true;
            lbl_wordLength.BackColor = Color.Transparent;
            lbl_wordLength.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_wordLength.Location = new Point(473, 174);
            lbl_wordLength.Name = "lbl_wordLength";
            lbl_wordLength.Size = new Size(212, 37);
            lbl_wordLength.TabIndex = 2;
            lbl_wordLength.Text = "Word Length : ";
            // 
            // lbl_wrongPredict
            // 
            lbl_wrongPredict.AutoSize = true;
            lbl_wrongPredict.BackColor = Color.Transparent;
            lbl_wrongPredict.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_wrongPredict.Location = new Point(34, 554);
            lbl_wrongPredict.Name = "lbl_wrongPredict";
            lbl_wrongPredict.Size = new Size(278, 37);
            lbl_wrongPredict.TabIndex = 3;
            lbl_wrongPredict.Text = "Wrong Predictions :";
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.BackColor = Color.Transparent;
            lbl_score.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_score.Location = new Point(1289, 798);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(176, 45);
            lbl_score.TabIndex = 4;
            lbl_score.Text = "SCORE : ";
            // 
            // txtbox_guess
            // 
            txtbox_guess.Location = new Point(473, 602);
            txtbox_guess.Name = "txtbox_guess";
            txtbox_guess.Size = new Size(217, 39);
            txtbox_guess.TabIndex = 5;
            // 
            // btn_guess
            // 
            btn_guess.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guess.Location = new Point(474, 691);
            btn_guess.Name = "btn_guess";
            btn_guess.Size = new Size(219, 67);
            btn_guess.TabIndex = 6;
            btn_guess.Text = "GUESS";
            btn_guess.UseVisualStyleBackColor = true;
            btn_guess.Click += btn_guess_Click;
            // 
            // btn_finish
            // 
            btn_finish.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_finish.Location = new Point(474, 792);
            btn_finish.Name = "btn_finish";
            btn_finish.Size = new Size(219, 67);
            btn_finish.TabIndex = 7;
            btn_finish.Text = "END GAME";
            btn_finish.UseVisualStyleBackColor = true;
            btn_finish.Click += btn_finish_Click;
            // 
            // lbl_hint
            // 
            lbl_hint.AutoSize = true;
            lbl_hint.BackColor = Color.Transparent;
            lbl_hint.Location = new Point(474, 322);
            lbl_hint.Name = "lbl_hint";
            lbl_hint.Size = new Size(0, 32);
            lbl_hint.TabIndex = 8;
            // 
            // pbHangman
            // 
            pbHangman.Location = new Point(856, 51);
            pbHangman.Margin = new Padding(5);
            pbHangman.Name = "pbHangman";
            pbHangman.Size = new Size(769, 707);
            pbHangman.TabIndex = 9;
            pbHangman.TabStop = false;
            // 
            // timerGame
            // 
            timerGame.Interval = 1000;
            timerGame.Tick += timerGame_Tick;
            // 
            // lblTimer
            // 
            lblTimer.BackColor = Color.Wheat;
            lblTimer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblTimer.Location = new Point(856, 776);
            lblTimer.Margin = new Padding(5, 0, 5, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(159, 88);
            lblTimer.TabIndex = 10;
            lblTimer.Text = "Time : ";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(34, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(398, 610);
            label1.TabIndex = 11;
            label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBoxInfo
            // 
            pictureBoxInfo.Location = new Point(34, 14);
            pictureBoxInfo.Name = "pictureBoxInfo";
            pictureBoxInfo.Size = new Size(62, 60);
            pictureBoxInfo.TabIndex = 12;
            pictureBoxInfo.TabStop = false;
            pictureBoxInfo.MouseEnter += pictureBoxInfo_MouseEnter;
            pictureBoxInfo.MouseLeave += pictureBoxInfo_MouseLeave;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 883);
            Controls.Add(pictureBoxInfo);
            Controls.Add(label1);
            Controls.Add(lblTimer);
            Controls.Add(pbHangman);
            Controls.Add(lbl_hint);
            Controls.Add(btn_finish);
            Controls.Add(btn_guess);
            Controls.Add(txtbox_guess);
            Controls.Add(lbl_score);
            Controls.Add(lbl_wrongPredict);
            Controls.Add(lbl_wordLength);
            Controls.Add(btn_hint);
            Controls.Add(lbl_word);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pbHangman).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_word;
        private Button btn_hint;
        private Label lbl_wordLength;
        private Label lbl_wrongPredict;
        private Label lbl_score;
        private TextBox txtbox_guess;
        private Button btn_guess;
        private Button btn_finish;
        private Label lbl_hint;
        private PictureBox pbHangman;
        private System.Windows.Forms.Timer timerGame;
        private Label lblTimer;
        private Label label1;
        private PictureBox pictureBoxInfo;
    }
}