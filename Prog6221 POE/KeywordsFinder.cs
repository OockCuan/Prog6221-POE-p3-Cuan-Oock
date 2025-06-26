using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog6221_POE
{
    internal class KeywordsFinder
    {
        //Method that sees what keywords are in user questions and returns a response key
        public string keyWords(string text)
        {
            string key = "A";

            if (text.Contains("phish") | text.Contains("Phish"))
            {
                //if asked about phishing vs vishing vs pharming
                if (text.Contains("vish") | text.Contains("Vish") | text.Contains("pharm") | text.Contains("Pharm"))
                {
                    key = "G";
                }
                else
                {
                    key = "B";
                }
            }
            //Checking for key for all phrases using the word safe
            else if (text.Contains("safe") | text.Contains("Safety"))
            {
                //safe browsing
                if (text.Contains("brows") | text.Contains("Brows"))
                {
                    key = "C";
                }
                //internet safety
                else if (text.Contains("internet") | text.Contains("Internet"))
                {
                    key = "D";
                }
                //defaults to password safety
                else
                {
                    key = "M";
                }

            }
            //default browsing
            else if (text.Contains("brows") | text.Contains("Brows"))
            {
                key = "F";
            }
            //passwords
            else if (text.Contains("Password") | text.Contains("password"))
            {
                key = "H";
            }
            //vishing
            else if (text.Contains("vish") | text.Contains("Vishing"))
            {
                if (text.Contains("pharm") | text.Contains("Pharming"))
                { key = "G"; }
                else
                {
                    key = "I";
                }
            }
            //pharming
            else if (text.Contains("pharm") | text.Contains("Pharming"))
            {
                key = "J";
            }
            //generic questions
            else if (text.Contains("how are you") | text.Contains("How are you"))
            {
                key = "K";
            }
            else if (text.Contains("your purpose"))
            {
                key = "L";
            }
            else if (text.Contains("ask you about") | text.Contains("ask about"))
            {
                key = "M";
            }
            else if (text.Contains("Privacy") | text.Contains("privacy"))
            {
                key = "N";
            }
            else if (text.Contains("Scam") | text.Contains("scam"))
            {
                key = "O";
            }

            return key;
        }

        //Method that identifies what question words are used in the user input to better structure the answer
        public string questionWords(string text)
        {
            string key = "what";
            if (text.Contains("tip") | text.Contains("Tip"))
            {
                key = "tip";
            }
            else if (text.Contains("what") | text.Contains("What"))
            {
                key = "what";
            }


            return key;
        }
    }
}
