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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string username;
        public Window1(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            //exit application
            Environment.Exit(0);
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            KeywordsFinder chat = new KeywordsFinder();
            Response responder = new Response(username);
            ExtendedResponse eResponder = new ExtendedResponse();
            ArrayList topics = new ArrayList();
        }
    }
}
