using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeperateLibrary
{
    public class Seperate
    {
        // Method 
        public string SeperatedWord(String person)
        {
            string test = person;
            string final = "";
            bool firstLetter = false;

            // Loop to get phrase and to seperate
            foreach (char letter in test)
            {
                if (char.IsUpper(letter))
                {
                    if (test.IndexOf(letter) == 0 && !firstLetter)
                    {

                        final += "" + letter.ToString().ToUpper();
                        firstLetter = true;

                    }
                    else
                    {
                        final += " " + letter.ToString().ToLower();
                    }
                }
                else
                {
                     final += "" + letter.ToString();
                }

            }
            return final;
          








        }

    }
}
