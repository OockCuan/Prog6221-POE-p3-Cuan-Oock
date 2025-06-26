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
        //declaring the username to be used in responses and the keywords
        private string username;
        private string response;
        private string rkeywords;
        private string input = "";

        //declaring array and arraylist for recall, activity log and tasks
        private ArrayList topics = new ArrayList();
        private String[] activityLog = null;
        private ArrayList tasks = new ArrayList();

        //declaring variables for keyword class and extended responses
        KeywordsFinder chat = new KeywordsFinder();
        ExtendedResponse eResponder = new ExtendedResponse();
        Tasks taskMaker = new Tasks();
        
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
            //declaring response class with username and giving variable names to 
            
            Response responder = new Response(username);

            //logic to add task
            if (chat.keyWords(userInput.Text) == "Z")
            {
                response = "When would you like to be reminded?";
                //saving previous input for later task 
                input = userInput.Text;
            }
            else if (responseBox.Text.Equals("When would you like to be reminded?"))
            {
                try
                {
                    //using old input and new input to form one reminder

                    Tasks newTask = taskMaker.createTask(input, userInput.Text);
                    tasks.Add(newTask);
                    
                    response = "Great, I'll remind you " + newTask.getReminder();
                }
                catch (ArgumentOutOfRangeException)
                {
                    response = "It looks like you didn't specify the task properly there, " +
                        "to add a task, please include the phrase 'add task' or 'remind me to'";
                }
            }
            //Logic to display all tasks
            else if (chat.keyWords(userInput.Text) == "Y") {

                string allTasks = "Tasks:\n---------------\n";
                foreach (var task in tasks) {
                    allTasks = allTasks + task.ToString() + "\n---------------\n";
                }
                response = allTasks;
            }


            //checking is user is still confused to assist them further before next response
            else if ((userInput.Text.Contains("Explain") || userInput.Text.Contains("explain") || userInput.Text.Contains("confu") ||
                    userInput.Text.Contains("Confu") || userInput.Text.Contains("detail") || userInput.Text.Contains("Detail")) &&
                    chat.keyWords(userInput.Text).Equals("A"))
            {
                //using previous user input
                response = response + "\n" + eResponder.checkConfusion(chat.keyWords(input));
            }
            else
            {
                //forming the response with sentiment checking and recall features
                rkeywords = chat.keyWords(userInput.Text);
                response = responder.sentimentCheck(rkeywords) + "\n" +
                    responder.respond(rkeywords, chat.questionWords(userInput.Text)) + "\n" +
                    eResponder.recall(topics, rkeywords);

                topics.Add(rkeywords);
                //saving previous input in case user is confused 
                input = userInput.Text;
            }

            //making response display
            responseBox.Text = response;
            userInput.Text = "";
            
        }


    }
}
