using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog6221_POE
{
    internal class Tasks
    {
        
        private string taskName;
        private string reminder;
        

        
        public string getReminder(){
            return reminder;
        }

        //Feature to create task
        public Tasks createTask(string input, string reminded, History history) {

            //checking how the user added a task and removing unnecessary language
            Tasks task = new Tasks();

            if (input.Contains("remind me to") || input.Contains("Remind me to"))
            {

                task.taskName = input.Remove(0, 13);
            }
            else if (input.Contains("dd task -")) {
                task.taskName = input.Remove(0, 11);
            }
            else if (input.Contains("dd task:"))
            {
                task.taskName = input.Remove(0, 10);
            }
            else if (input.Contains("remind me about") || input.Contains("Remind me about"))
            {

                task.taskName = input.Remove(0, 16);
            }
            else if (input.Contains("add task") || input.Contains("Add task"))
            {

                task.taskName = input.Remove(0, 9);
            }
            else { throw new ArgumentOutOfRangeException("Language to add tasks not present"); }


            //checking to see if user wants to be reminded
           if (reminded.Contains("no") || reminded.Contains("don") || reminded.Contains("None") || reminded.Contains("Don"))
            {
                task.reminder = "None";
            }
            else { task.reminder = reminded; }

            history.addTask("Added task: " + task.taskName);
            return task;
        }

        //getting task data by overriding ToString method 
        public override string ToString() {
            string taskData = "Task Name: " + taskName + "\n" + "Reminder: " + reminder;
            return taskData;
        }
    }
}
