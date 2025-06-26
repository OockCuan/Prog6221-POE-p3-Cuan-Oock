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

namespace Prog6221_POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (nameBtn.Text.Equals(""))
            {
        //Checking to see if a name is actually entered and giving an error otherwise
                MessageBox.Show("Please enter your name");
            }
            else {
        //Displaying second window if name is given
                Window1 window1 = new Window1(nameBtn.Text);
                this.Visibility = Visibility.Hidden;
                window1.Show();
                
            }
        }
    }
}
