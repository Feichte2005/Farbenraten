namespace Farbenraten_DominikFeichtenschlager
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
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            btnRed = new Button();
            btnGreen = new Button();
            btnBlue = new Button();
            btnPurple = new Button();
            btnYellow = new Button();
            lblColorText = new Label();
            lblResults = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            rbtnPl1 = new RadioButton();
            rbtnPl2 = new RadioButton();
            rbtnCompare = new RadioButton();
            nudRounds = new NumericUpDown();
            difficultyTimer = new System.Windows.Forms.Timer(components);
            rbtnEasy = new RadioButton();
            rbtnMedium = new RadioButton();
            rbtnHard = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nudRounds).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 22);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.Location = new Point(185, 89);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(100, 50);
            btnRed.TabIndex = 1;
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += btnRed_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.FromArgb(0, 192, 0);
            btnGreen.Location = new Point(185, 205);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(100, 50);
            btnGreen.TabIndex = 2;
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.FromArgb(0, 0, 192);
            btnBlue.Location = new Point(280, 145);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(100, 50);
            btnBlue.TabIndex = 3;
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnPurple
            // 
            btnPurple.BackColor = Color.Purple;
            btnPurple.Location = new Point(380, 89);
            btnPurple.Name = "btnPurple";
            btnPurple.Size = new Size(100, 50);
            btnPurple.TabIndex = 4;
            btnPurple.UseVisualStyleBackColor = false;
            btnPurple.Click += btnPurple_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.Location = new Point(380, 205);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(100, 50);
            btnYellow.TabIndex = 5;
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += btnYellow_Click;
            // 
            // lblColorText
            // 
            lblColorText.AutoSize = true;
            lblColorText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblColorText.Location = new Point(291, 48);
            lblColorText.Name = "lblColorText";
            lblColorText.Size = new Size(76, 32);
            lblColorText.TabIndex = 6;
            lblColorText.Text = "Color";
            lblColorText.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(32, 225);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(55, 15);
            lblResults.TabIndex = 7;
            lblResults.Text = "Resultate";
            // 
            // timer1
            // 
            timer1.Interval = 10;
            // 
            // rbtnPl1
            // 
            rbtnPl1.AutoSize = true;
            rbtnPl1.Location = new Point(12, 95);
            rbtnPl1.Name = "rbtnPl1";
            rbtnPl1.Size = new Size(66, 19);
            rbtnPl1.TabIndex = 9;
            rbtnPl1.TabStop = true;
            rbtnPl1.Text = "Player 1";
            rbtnPl1.UseVisualStyleBackColor = true;
            rbtnPl1.CheckedChanged += rbtnPl1_CheckedChanged;
            // 
            // rbtnPl2
            // 
            rbtnPl2.AutoSize = true;
            rbtnPl2.Location = new Point(12, 120);
            rbtnPl2.Name = "rbtnPl2";
            rbtnPl2.Size = new Size(66, 19);
            rbtnPl2.TabIndex = 10;
            rbtnPl2.TabStop = true;
            rbtnPl2.Text = "Player 2";
            rbtnPl2.UseVisualStyleBackColor = true;
            rbtnPl2.CheckedChanged += rbtnPl2_CheckedChanged;
            // 
            // rbtnCompare
            // 
            rbtnCompare.AutoSize = true;
            rbtnCompare.Location = new Point(12, 145);
            rbtnCompare.Name = "rbtnCompare";
            rbtnCompare.Size = new Size(74, 19);
            rbtnCompare.TabIndex = 12;
            rbtnCompare.TabStop = true;
            rbtnCompare.Text = "Compare";
            rbtnCompare.UseVisualStyleBackColor = true;
            rbtnCompare.CheckedChanged += rbtnCompare_CheckedChanged;
            // 
            // nudRounds
            // 
            nudRounds.Location = new Point(12, 51);
            nudRounds.Name = "nudRounds";
            nudRounds.Size = new Size(75, 23);
            nudRounds.TabIndex = 13;
            nudRounds.Value = new decimal(new int[] { 15, 0, 0, 0 });
            nudRounds.ValueChanged += nudRounds_ValueChanged;
            // 
            // difficultyTimer
            // 
            difficultyTimer.Interval = 10;
            // 
            // rbtnEasy
            // 
            rbtnEasy.AutoSize = true;
            rbtnEasy.Location = new Point(529, 95);
            rbtnEasy.Name = "rbtnEasy";
            rbtnEasy.Size = new Size(48, 19);
            rbtnEasy.TabIndex = 14;
            rbtnEasy.TabStop = true;
            rbtnEasy.Text = "Easy";
            rbtnEasy.UseVisualStyleBackColor = true;
            rbtnEasy.CheckedChanged += rbtnEasy_CheckedChanged;
            // 
            // rbtnMedium
            // 
            rbtnMedium.AutoSize = true;
            rbtnMedium.Location = new Point(529, 120);
            rbtnMedium.Name = "rbtnMedium";
            rbtnMedium.Size = new Size(70, 19);
            rbtnMedium.TabIndex = 15;
            rbtnMedium.TabStop = true;
            rbtnMedium.Text = "Medium";
            rbtnMedium.UseVisualStyleBackColor = true;
            rbtnMedium.CheckedChanged += rbtnMedium_CheckedChanged;
            // 
            // rbtnHard
            // 
            rbtnHard.AutoSize = true;
            rbtnHard.Location = new Point(529, 144);
            rbtnHard.Name = "rbtnHard";
            rbtnHard.Size = new Size(51, 19);
            rbtnHard.TabIndex = 16;
            rbtnHard.TabStop = true;
            rbtnHard.Text = "Hard";
            rbtnHard.UseVisualStyleBackColor = true;
            rbtnHard.CheckedChanged += rbtnHard_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(625, 348);
            Controls.Add(rbtnHard);
            Controls.Add(rbtnMedium);
            Controls.Add(rbtnEasy);
            Controls.Add(nudRounds);
            Controls.Add(rbtnCompare);
            Controls.Add(rbtnPl2);
            Controls.Add(rbtnPl1);
            Controls.Add(lblResults);
            Controls.Add(lblColorText);
            Controls.Add(btnYellow);
            Controls.Add(btnPurple);
            Controls.Add(btnBlue);
            Controls.Add(btnGreen);
            Controls.Add(btnRed);
            Controls.Add(btnStart);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudRounds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnRed;
        private Button btnGreen;
        private Button btnBlue;
        private Button btnPurple;
        private Button btnYellow;
        private Label lblColorText;
        private Label lblResults;
        private System.Windows.Forms.Timer timer1;
        private RadioButton rbtnPl1;
        private RadioButton rbtnPl2;
        private RadioButton rbtnCompare;
        private NumericUpDown nudRounds;
        private System.Windows.Forms.Timer difficultyTimer;
        private RadioButton rbtnEasy;
        private RadioButton rbtnMedium;
        private RadioButton rbtnHard;
    }
}
