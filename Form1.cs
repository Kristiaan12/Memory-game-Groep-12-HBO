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
        int[] Highscore = new int[10];
        string[] Highscorenaam = new string[10];
        int intScore1 = 0;
        int intScore2 = 0;
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };

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

        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("De tijd is op!");
                    ResetImages();
                }

                var ssTime = TimeSpan.FromSeconds(time);

                label1.Text = "00:" + time.ToString();
            };
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
            timer.Start();
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
                intScore1 += 10;
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }
            firstGuess = null;
            lblspeler1.Text = "Speler 1 score:" + intScore1.ToString();
            if (pictureBoxes.Any(p => p.Visible)) return;

            MessageBox.Show("U heeft gewonnen, Probeer het nog een keer");
            ResetImages();
        }

        private void startGame(object sender, EventArgs e)
        {
            //lblspeler1.Text = "Speler 1 score:" + intScore1.ToString();
            //lblspeler2.Text = "Speler 2 score:" + intScore2.ToString();
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            button1.Enabled = false;
        }

        Highscores HighscoresForm = new Highscores();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

