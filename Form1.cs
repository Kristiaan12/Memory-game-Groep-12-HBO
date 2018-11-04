using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Memory_game_Groep_12_HBO
{
    public partial class Form1 : Form
    {
        //Set save file
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "highscores.txt");

        //Initialize variables
        int currPlayer = 1;
        int streakP1 = 0;
        int streakP2 = 0;
        Boolean beginTurnP2 = true;
        Boolean p1Done = false;
        Boolean p2Done = false;
        int[] Highscore = new int[10];
        string[] Highscorenaam = new string[10];
        int intScore1 = 0;
        int intScore2 = 0;
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 60;
        int time2 = 60;
        Timer timer = new Timer { Interval = 1000 };
        Timer timer2 = new Timer { Interval = 1000 };

        private void load_Scores()
        {
            // to load save data:
            if (File.Exists(path))
            {
                string loaded_text = File.ReadAllText(path);
                //Parse string from textfile
                string[] scores = loaded_text.Split(';');
                //determine ranking
                int[] ranking = { 0, 0, 0, 0, 0 };
                int count = ranking.Length;
                //Loop trough all scores in file
                bool ranked = false;
                foreach (var score in scores)
                {
                    if (score.Length != 0)
                    {
                        string scoreStr = score.ToString();

                        //Seperate name from actual score
                        string[] scoreLines = scoreStr.Split(':');
                        //Get the last entry (the actual score/ points)
                        string points = scoreLines.Last();
                        int pointsInt = Int32.Parse(points);

                        if (ranked == false)
                        {
                            //Compare score to previous added highscores
                            for (int i = 0; i < count; i++)
                            {
                                //Check points from data vs highscores
                                if (pointsInt > ranking[i])
                                {
                                    int next = i + 1;
                                    for (int c = i; c < count; c++)
                                    {
                                        //Derank current rank holders equal to and below current rank

                                        if (next < 5)
                                        {
                                            System.Console.WriteLine($"<{ranking[next]}>");
                                            ranking[next] = ranking[c];
                                            next++;
                                        }
                                    }
                                    ////Set rank
                                    ranking[i] = pointsInt;
                                    ranked = true;
                                    break;
                                }
                            }
                        }
                    }
                    TbHighscore1.Text = ranking[0].ToString();
                    TbHighscore2.Text = ranking[1].ToString();
                    TbHighscore3.Text = ranking[2].ToString();
                    TbHighscore4.Text = ranking[3].ToString();
                    TbHighscore5.Text = ranking[4].ToString();

                }
            }
        }

        //Player info
        [Serializable]
        public class PlayerInfo
        {
            public string name = "";
            public float highScore = 0;
        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }

        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                    {
                    Properties.Resources.Atletiek,
                    Properties.Resources.Bergklimmen,
                    Properties.Resources.Bergwandelen,
                    Properties.Resources.Boksen,
                    Properties.Resources.Basketbal,
                    Properties.Resources.Curlen,
                    Properties.Resources.Duiken,
                    Properties.Resources.Bowlen
                    };
            }
        }

       

        private void startGameTimer(Boolean run)
        {

            if (run)
            {
                label3.Visible = true;
                timer.Start();

                timer.Tick += delegate
                {
                    time--;
                    if (time < 0)
                    {
                        timer.Stop();
                        MessageBox.Show("Je tijd is op!");
                        p1Done = true;
                        allowClick = false;
                        //Only reset when the game is over?
                        //ResetImages();
                    }

                    var ssTime = TimeSpan.FromSeconds(time);

                    label1.Text = "P1: 00:" + time.ToString();
                };
            }
            if (!run)
            {
                timer.Stop();
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            playerLbl.Text = Main.SetValueForText1;
            playerLbl2.Text = Main.SetValueForText2;
        
        }

        private void startGameTimerP2(Boolean run)
        {
         
            if (run)
            {
                label3.Visible = true;
                timer2.Start();
                timer2.Tick += delegate
                {
                    time2--;
                    if (time2 < 0)
                    {
                        timer2.Stop();
                        MessageBox.Show("Je tijd is op!");
                        p2Done = true;
                        allowClick = false;
                        //Only reset when the game is over?
                        //ResetImages();
                    }

                    var ssTime2 = TimeSpan.FromSeconds(time);

                    label3.Text = "P2: 00:" + time2.ToString();
                };
            }
            if (!run)
            {
                timer2.Stop();
            }
           
        }

        private void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }

            HideImages();
            setRandomImages();
            time = 60;
            time2 = 60;
            //Choose player timer
            if (currPlayer == 1)
            {
                timer.Stop();
                timer2.Start();
            }
            else
            {
                timer2.Stop();
                timer.Start();
            }
        }

        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.Kaartachtergrond;
            }
        }

        private PictureBox getFreeslot()
        {
            int num;

            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }

        private void setRandomImages()
        {
            foreach (var image in images)
            {
                getFreeslot().Tag = image;
                getFreeslot().Tag = image;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();

            allowClick = true;
            clickTimer.Stop();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void clickImage(object sender, EventArgs e)
        
        {
            string player1 = playerLbl.Text;
            string player2 = playerLbl2.Text;
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;

                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages();
                if (currPlayer == 1 || currPlayer == 0)
                {
                    streakP1++;
                    intScore1 += (10 * streakP1);
                }
                else
                {
                    streakP2++;
                    intScore2 += (10 * streakP2);
                }
            }
            else
            {
                allowClick = false;
                 //Check if the 'previous' player is 1.
                 if (currPlayer == 1 || currPlayer == 0)
                 {
                    //Check if player 2 is already out of time.
                    if (p2Done == false)
                    {
                        streakP1 = 0;
                        currPlayer = 2;
                        //Pauzeer timer1
                        timer.Stop();
                        MessageBox.Show(player2 + " is nu aan de beurt.");
                        //Initialize if player2 is starting his first round, else resume timer.
                        if (beginTurnP2)
                        {
                            //Begin timer2
                            startGameTimerP2(true);
                            beginTurnP2 = false;
                        }
                        else
                        {
                            //Hervat timer2
                            timer2.Start();

                        }
                    }
                 }
                 else
                 {
                    //Check if player 1 is already out of time.
                    if (p1Done == false)
                    {
                        streakP2 = 0;
                        currPlayer = 1;
                        //Pauzeer timer2
                        timer2.Stop();
                        MessageBox.Show(player1 + " is nu aan de beurt.");
                        timer.Start();
                        //Hervat timer1
                    }
                 }
                 clickTimer.Start();
            }
            firstGuess = null;

            lblspeler1.Text =  " score:" + intScore1.ToString();
            lblspeler2.Text =  " score:" + intScore2.ToString();
            if (pictureBoxes.Any(p => p.Visible)) return;
            intScore1 = intScore1 + 60 - (60 - time);
            intScore2 = intScore2 + 60 - (60 - time2);
            lblspeler1.Text = player1 + " score:" + intScore1.ToString();
            lblspeler2.Text = player2 + " score:" + intScore2.ToString();
            //Stop timers
            timer.Stop();
            timer2.Stop();
            //Reset timers?
            //
            //Reset first turn p2 for initializing timer & set currPlayer(next 'previous' player) to 2.
            beginTurnP2 = true;
            p2Done = false;
            p1Done = false;
            MessageBox.Show("U heeft gewonnen, Probeer het nog een keer");
            ResetImages();
            //Set save data!
            string saveData = player1 + "," + intScore1.ToString() + ";";
            saveData += player2 + "," + intScore2.ToString() + ";";
            //Save data to file
            File.WriteAllText(path, saveData);
            //Free set of clicks on 2nd game!?
        }

        private void startGame(object sender, EventArgs e)
        {
            

            //lblspeler1.Text = "Speler 1 score:" + intScore1.ToString();
            //lblspeler2.Text = "Speler 2 score:" + intScore2.ToString();
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer(true);
            startGameTimerP2(false);
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            button1.Enabled = false;
            load_Scores();
        }

        Highscores HighscoresForm = new Highscores();

        private void resetBtn_Click_1(object sender, EventArgs e)
        {
           Application.Restart();
        }

        //Pauze button wich stops current timer and disables clicks till resume!
    }
}

