using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounterLibrary
{
    public class WordCount
    {
        // Method to return string
        public string GettingCount(string numberCount)
        {
            
            //getting rid of spaces and reading only the words
            string[] tokens = numberCount.Split(null);
            return tokens.ToString();
        }
        public string gettingCountAverage(string numberCount)
        {
            string[] tokens = numberCount.Split(null);
            char letter;
            int total = 0;

            for (int index = 0; index < numberCount.Length; index++)
            {
                letter = numberCount[index];
                total = index / tokens.Length;
                total.ToString();
            }
            return total.ToString();
        }

    }

}

