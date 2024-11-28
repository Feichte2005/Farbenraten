using System.Diagnostics;

namespace Farbenraten_DominikFeichtenschlager
{
    public partial class Form1 : Form
    {
        private readonly string[] colorNames = { "Blue", "Red", "Purple", "Yellow", "Green" };
        private readonly Color[] colors = { Color.Blue, Color.Red, Color.Purple, Color.Yellow, Color.Green };
        private int correctColorIndex;
        int textColorIndex;
        private int attempts;
        private int penalty;
        private Stopwatch stopwatch;
        private Random random;
        private int maxtime;
        private int mintime;
        private int cummtime;
        private int player = 0;
        private int totalRounds = 15;
        private int difficultyLevel = 1; // 1 = easy, 2 = medium, 3 = hard

        //Values for Player 1
        private int pl1attempts;
        private int pl1penalty;
        private int pl1maxtime;
        private int pl1mintime;
        private int pl1cummtime;

        //Values for Player 2 
        private int pl2attempts;
        private int pl2penalty;
        private int pl2maxtime;
        private int pl2mintime;
        private int pl2cummtime;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            btnRed.Enabled = false;
            btnGreen.Enabled = false;
            btnBlue.Enabled = false;
            btnYellow.Enabled = false;
            btnPurple.Enabled = false;
            rbtnPl1.Enabled = true;
            rbtnPl2.Enabled = true;
        }

        private void InitializeGame()
        {                                                                   //Resets all Values
            random = new Random();
            stopwatch = new Stopwatch();
            maxtime = 0;
            mintime = int.MaxValue;
            cummtime = 0;
            attempts = 0;
            penalty = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)              // Start Game
        {
            
            InitializeGame();
            StartRound();
            btnStart.Enabled = false;
            rbtnCompare.Enabled = false;
            rbtnPl1.Enabled = false;
            rbtnPl2.Enabled = false;
        }

        private void StartRound()                                           //Start Round
        {

            do
            {
                correctColorIndex = random.Next(0, colorNames.Length);      //Change Colour until textcolor is corret colour
                textColorIndex = random.Next(0, colors.Length);
            }
            while (correctColorIndex == textColorIndex);


            lblColorText.Text = colorNames[textColorIndex];                 //Change Label Text to the correct color
            lblColorText.ForeColor = colors[correctColorIndex];             //Change Label Forecolor to the correct Color

            stopwatch.Restart();
            difficultyTimer?.Start();

            btnPurple.Enabled = true;                                        // Enable Purple Button
            btnYellow.Enabled = true;                                        // Enable Yellow Button
            btnGreen.Enabled = true;                                         // Enable Green Button
            btnBlue.Enabled = true;                                          // Enable Blue Button
            btnRed.Enabled = true;                                           // Enable Red Button

        }

        private void checkAnswer(int clickedButtonIndex)                    //Check if given answer is correct
        {
            stopwatch.Stop();

            int reaktionTime = (int)stopwatch.ElapsedMilliseconds;
            //mintime = int.MaxValue;

            if (clickedButtonIndex == correctColorIndex)
            {
                maxtime = Math.Max(maxtime, reaktionTime);                  //Calculate the longest Reactiontime
                if (reaktionTime < mintime)                                 //Calculate the shortest Reactiontime
                {
                    mintime = reaktionTime;
                }
                cummtime += reaktionTime;
            }
            else
            {
                penalty += 1;                                               //Add 1 penalty poit if the answer is wrong
            }

            attempts++;                                                     //Add 1 attempt


            if (attempts < 15)                                              //Check if you are allowed to play another game
            {
                StartRound();
                btnStart.Enabled = false;
                rbtnCompare.Enabled = false;
                rbtnPl1.Enabled = false;
                rbtnPl2.Enabled = false;

            }

            if (attempts >= totalRounds)                                             //Check if round is done
            {

                lblColorText.ForeColor = Color.Black;
                lblColorText.Text = ("Thanks for Playing");

                ShowResults();

                btnStart.Enabled = true;                                    //Deactivate Buttons
                rbtnCompare.Enabled = true;                                 //Reactivate Radio Buttons
                rbtnPl1.Enabled = true;
                rbtnPl2.Enabled = true;
                btnRed.Enabled = false;
                btnGreen.Enabled = false;
                btnBlue.Enabled = false;
                btnYellow.Enabled = false;
                btnPurple.Enabled = false;

            }

            //Pass the variables to store them so they won't be overwritten.
            if (player == 1 && attempts >= totalRounds)
            {
                pl1attempts = attempts;
                pl1penalty = penalty;
                pl1maxtime = maxtime;
                pl1mintime = mintime;
                pl1cummtime = cummtime;
                player = 0;
            }


            //Pass the variables to store them so they won't be overwritten.
            if (player == 2 && attempts >= totalRounds)
            {
                pl2attempts = attempts;
                pl2penalty = penalty;
                pl2maxtime = maxtime;
                pl2mintime = mintime;
                pl2cummtime = cummtime;
                player = 0;
            }
        }
        private void ShowResults()
        {
            int averageTime = 0;
            if (attempts > 0)//Calculate Average Reactiontime
            {
                averageTime = cummtime / attempts;
            }
            lblResults.Text = $"Best Time: {mintime} ms\nWorst Time: {maxtime} ms\nAverage Time: {averageTime} ms\nPenaltypoints: {penalty}";
        }

        private void btnBlue_Click(object sender, EventArgs e)              //Rediect the Button Click to the corrosponding check awnser
        {
            checkAnswer(0);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            checkAnswer(1);
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            checkAnswer(2);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            checkAnswer(3);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            checkAnswer(4);
        }


        //Multiplayer

        private void Multiplayer()                                          //Multiplayer
        {
            int input = 0;
            //Check Mode
            if (rbtnPl1.Checked)
            {
                input = 1;
            }
            else if (rbtnPl2.Checked)
            {
                input = 2;
            }
            else if (rbtnCompare.Checked)
            {
                input = 3;
            }

            switch (input)
            {
                case 1:
                                                              //Start Round in Multiplayer
                    InitializeGame();
                    StartRound();
                    btnPurple.Enabled = true;
                    btnYellow.Enabled = true;
                    btnGreen.Enabled = true;
                    btnBlue.Enabled = true;
                    btnRed.Enabled = true;
                    player = 1;
                    rbtnPl1.Checked = false;
                    break;

                case 2:
                    
                    InitializeGame();
                    StartRound();
                    btnPurple.Enabled = true;
                    btnYellow.Enabled = true;
                    btnGreen.Enabled = true;
                    btnBlue.Enabled = true;
                    btnRed.Enabled = true;
                    player = 2;
                    rbtnPl2.Checked = false;
                    break;

                case 3:
                    compare();
                    rbtnCompare.Checked = false;
                    break;

            }
        }

        private void compare()                                              //Compare and decide who won
        {
            //disables the calculation, because of the attempts (divided by Zero)
            if (pl1attempts >= totalRounds && pl2attempts >= totalRounds)
            {
                int pointsPl1 = 0;
                int pointsPl2 = 0;

                int pl1averageTime = pl1cummtime / pl1attempts;
                int pl2averageTime = pl2cummtime / pl2attempts;

                //Compare Penaltypoints
                if (pl1penalty < pl2penalty)
                {
                    pointsPl1++;
                }
                if (pl1penalty > pl2penalty)
                {
                    pointsPl2++;
                }

                //Compare Maximal Reaction Time
                if (pl1maxtime < pl2maxtime)
                {
                    pointsPl1++;
                }
                if (pl1maxtime > pl2maxtime)
                {
                    pointsPl2++;
                }

                //Compare Shortest Reactiontime
                if (pl1mintime < pl2mintime)
                {
                    pointsPl1++;
                }
                if (pl1mintime > pl2mintime)
                {
                    pointsPl2++;
                }

                //Compare Cumulative Time
                if (pl1cummtime < pl2cummtime)
                {
                    pointsPl1++;
                }
                if (pl1cummtime > pl2cummtime)
                {
                    pointsPl2++;
                }


                if (pointsPl1 > pointsPl2)                                      //Evaluate Who Won
                {
                    MessageBox.Show("Player 1 Wins!");
                    MessageBox.Show($"Player 1 \nBest Time: {pl1mintime} ms\nWorst Time: {pl1maxtime} ms\nAverage Time: {pl1averageTime} ms\nPenaltypoints: {pl1penalty}");
                    MessageBox.Show($"Player 2 \nBest Time: {pl2mintime} ms\nWorst Time: {pl2maxtime} ms\nAverage Time: {pl2averageTime} ms\nPenaltypoints: {pl2penalty}");
                }

                else if (pointsPl1 < pointsPl2)
                {
                    MessageBox.Show("Player 2 Wins!");
                    MessageBox.Show($"Player 1 \nBest Time: {pl1mintime} ms\nWorst Time: {pl1maxtime} ms\nAverage Time: {pl1averageTime} ms\nPenaltypoints: {pl1penalty}");
                    MessageBox.Show($"Player 2 \nBest Time: {pl2mintime} ms\nWorst Time: {pl2maxtime} ms\nAverage Time: {pl2averageTime} ms\nPenaltypoints: {pl2penalty}");
                }
                else
                {
                    MessageBox.Show("Draw:");
                    MessageBox.Show($"Player 1 \nBest Time: {pl1mintime} ms\nWorst Time: {pl1maxtime} ms\nAverage Time: {pl1averageTime} ms\nPenaltypoints: {pl1penalty}");
                    MessageBox.Show($"Player 2 \nBest Time: {pl2mintime} ms\nWorst Time: {pl2maxtime} ms\nAverage Time: {pl2averageTime} ms\nPenaltypoints: {pl2penalty}");
                }
            }

            else
            {
                MessageBox.Show("Only one player has played!");
            }

        }

        private void rbtnPl1_CheckedChanged(object sender, EventArgs e)
        {
            Multiplayer();
            btnStart.Enabled = false;
            rbtnCompare.Enabled = false;
            rbtnPl1.Enabled = false;
            rbtnPl2.Enabled = false;
        }

        private void rbtnPl2_CheckedChanged(object sender, EventArgs e)
        {
            Multiplayer();
            btnStart.Enabled = false;
            rbtnCompare.Enabled = false;
            rbtnPl1.Enabled = false;
            rbtnPl2.Enabled = false;
        }

        private void rbtnCompare_CheckedChanged(object sender, EventArgs e)
        {
            Multiplayer();
        }

        //individual roundsettings
        private void nudRounds_ValueChanged(object sender, EventArgs e)
        {
            totalRounds = (int)nudRounds.Value;
        }

        //Difficulty level
        private void SetDifficulty(int level)
        {
            difficultyLevel = level;

            difficultyTimer = new System.Windows.Forms.Timer();
            difficultyTimer.Interval = level switch
            {
                1 => 5000, // 5 s (easy)
                2 => 3000, // 3 s (medium)
                3 => 2000, // 2 s (hard)
                _ => 5000
            };
            difficultyTimer.Tick += DifficultyTimer_Tick;
        }

        private void DifficultyTimer_Tick(object sender, EventArgs e)
        {
            if (attempts < totalRounds)
            {
                penalty++; //gives the player penalty points
                attempts++;
                StartRound();
            }
            else
            {
                difficultyTimer.Stop();
                ShowResults();
            }
        }

        private void rbtnEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEasy.Checked) SetDifficulty(1);
        }

        private void rbtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMedium.Checked) SetDifficulty(2);
        }

        private void rbtnHard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHard.Checked) SetDifficulty(3);
        }
    }
}

