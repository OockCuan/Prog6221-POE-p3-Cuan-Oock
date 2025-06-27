using System;
using System.Collections;
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
    /// Interaction logic for History.xaml
    /// </summary>
    public partial class History : Window
    {
        private ArrayList actions = new ArrayList();

        public History()
        {
            InitializeComponent();
            
        }

        //method that updates the textbox to show full history
        public void update(History history) {
            logBox.Text = history.ToString();
        }

        public void addTask(string taskInfo) {
            actions.Add(taskInfo);
        }
        //overriding ToString to give all history
        public override string ToString()
        {
            string log = "History:";
            foreach (var action in actions)
            {
                log = log + "\n-------------\n" + action.ToString();
            }
            return log;
        }

        private void closeHistory_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        
    }
}
