using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;

namespace Slutprojekt_Balloon_Pop
{
    public partial class MainWindow : Window
    {
        DispatcherTimer gameTimer = new DispatcherTimer();
        
        int balloonSpeed = 3;
        int creationInterval = 90;
        Random rand = new Random();

        //Lists which balloons passed the top of the screen to later calculate when you die
        List<Rectangle> itemRemover = new List<Rectangle>();

        ImageBrush backgroundImage = new ImageBrush();

        int balloonSkins;
        int sidewaysMovement;
        int missedBalloons;
        bool gameIsActive;
        int score;

        MediaPlayer player = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();

            //Tick rate of the game
            gameTimer.Tick += GameEngine;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            //Finds "background-image" and sets it as the background image
            backgroundImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/files/background-Image.jpg"));
            MyCanvas.Background = backgroundImage;

            RestartGame();
        }

        private void GameEngine(object sender, EventArgs e)
        {
            scoreText.Content = "Score: " + score;

            creationInterval -= 10;

            //Creates balloons and assigns skin
            if (creationInterval < 1)
            {
                ImageBrush balloonImage = new ImageBrush();

                //Rotates which skin is chosen
                balloonSkins += 1;

                //Resets "balloonSkins" if it's more than 5 (the ammount of skins that exist)
                if (balloonSkins > 5)
                {
                    balloonSkins = 1;
                }

                //assings skin to balloonImage
                switch (balloonSkins)
                {
                    case 1:
                        balloonImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/files/balloon1.png"));
                        break;

                    case 2:
                        balloonImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/files/balloon2.png"));
                        break;

                    case 3:
                        balloonImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/files/balloon3.png"));
                        break;

                    case 4:
                        balloonImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/files/balloon4.png"));
                        break;

                    case 5:
                        balloonImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/files/balloon5.png"));
                        break;
                }

                //Creates new balloon and attatches balloonImage
                Rectangle newBalloon = new Rectangle
                {
                    Tag = "balloon",
                    Height = 50,
                    Width = 50,
                    Fill = balloonImage
                };

                //choses where to spawn the new balloon
                Canvas.SetLeft(newBalloon, rand.Next(50, 400));
                Canvas.SetTop(newBalloon, 600);

                //Spawns the new balloon
                MyCanvas.Children.Add(newBalloon);

                //Sets a random timer for when to spawn the next balloon
                creationInterval = rand.Next(90, 150);
            }

            //Movement of balloons
            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                if ((string)x.Tag == "balloon")
                {
                    //Sideways movement
                    sidewaysMovement = rand.Next(-5, 5);

                    Canvas.SetLeft(x, Canvas.GetTop(x) - balloonSpeed);
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - (sidewaysMovement * -1));
                }
            }
        }

        private void PopBalloon(object sender, MouseButtonEventArgs e)
        {

        }

        private void StartGame()
        {
            //Starts gametimer
            gameTimer.Start();

            //Resets relevant things to default values
            missedBalloons = 0;
            score = 0;
            creationInterval = 90;
            gameIsActive = true;
            balloonSpeed = 3;
        }

        private void RestartGame()
        {
            //Adds any existing balloon on screen to deletion list
            foreach(var x in MyCanvas.Children.OfType<Rectangle>())
            {
                itemRemover.Add(x);
            }

            //Deletes everything in deletion list
            foreach (Rectangle y in itemRemover)
            {
                MyCanvas.Children.Remove(y);
            }

            //Clears deletion list
            itemRemover.Clear();

            //Restarts the game
            StartGame();
        }
    }
}
