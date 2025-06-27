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
using System.Windows.Shapes;

namespace Prog6221_POE
{
    /// <summary>
    /// Interaction logic for QuizWindow.xaml
    /// </summary>
    public partial class QuizWindow : Window
    {
        private int highScore = 0;
        private int currentScore = 0;
        private History history;

        //getters and setters for high and current score
        public int getHighScore() {
            return highScore;
        }
        public int getCurrentScore() {
            return currentScore;
        }
        public QuizWindow(int highScore, History history)
        {
            this.highScore = highScore;
            InitializeComponent();
            this.history = history;
        }

        private void closeBtnQ_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void qSubmssion_Click(object sender, RoutedEventArgs e)
        {
            currentScore = 0;
            //logic to check answers
            if (f1.IsChecked == true)
            {
                currentScore += 1;
                cb1.IsChecked = true;
            }
            //sets the marker to false to show incorrect answer
            else { cb1.IsChecked = false; }
            if (f2.IsChecked == true){
                currentScore += 1;
                cb2.IsChecked = true;
            }
            else { cb2.IsChecked = false; }
            if (f3.IsChecked == true) { 
                currentScore += 1;
                cb3.IsChecked = true;
            }
            else { cb3.IsChecked = false; }
            if (t4.IsChecked == true) { 
                currentScore += 1;
                cb4.IsChecked = true;
            }
            else { cb4.IsChecked = false; }
            if (f5.IsChecked == true) { 
                currentScore += 1;
                cb5.IsChecked = true;
            }
            else { cb5.IsChecked = false; }
            if (b6.IsChecked == true) {
                currentScore += 1;
                cb6.IsChecked = true;
            }
            else { cb6.IsChecked = false; }
            if (c7.IsChecked == true)
            {
                currentScore += 1;
                cb7.IsChecked = true;
            }
            else { cb7.IsChecked = false; }
            if (a8.IsChecked == true)
            {
                currentScore += 1;
                cb8.IsChecked = true;
            }
            else { cb8.IsChecked = false; }
            if (c9.IsChecked == true)
            {
                currentScore += 1;
                cb9.IsChecked = true;
            }
            else { cb9.IsChecked = false; }
            if (a10.IsChecked == true)
            {
                currentScore += 1;
                cb10.IsChecked = true;
            }
            else { cb10.IsChecked = false; }

            //Check to see if high score should change
            if (currentScore > highScore) {
                highScore = currentScore;
            }

            //Display results
            resultsBox.Text = "Current score:\n" + currentScore + "\n-----------\nHigh score:\n" + highScore;

            history.addTask("Took quiz, Score: " + currentScore);

        }
    }
}
