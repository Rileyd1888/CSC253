using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtentionLibrary;


namespace ExtentionLibrary
{

    public static class Extensions
    {
        //String extention method that converts a string to an array of char
        public static char[] stringChar(this String user)
        {
            return user.ToCharArray();
        }
        // String extension methond that returns the string backwards
        public static string backwardsString(this string user)
        {
            string rev = "";

            for(int i = user.Length - 1; i >= 0; i--)
            {
                rev += user[i];
            }
            return rev;

        }

        //String extention method that counts the number of words in a string
        public static int stringCount(this string count)
        {
            //getting rid of spaces and reading only the words
            string[] userString = count.Split(new char[] { ' ', '.', '?' },
                                          StringSplitOptions.RemoveEmptyEntries);
            int wordCount = userString.Length;
            return wordCount;
        }

    //String extension method that formats a 10-character string as a telephone number
    public static string stringToCharString(this string toChar)
        {
            string tel = "(";
            tel += toChar.Substring(0, 3);
            tel += ")";
            tel += toChar.Substring(3, 3);
            tel += "-";
            tel += toChar.Substring(6);

            return tel;
        }

        //String extention that takes a string formatted as a dat and breaks it into a three element 
        //string array containing the month, day and year
        public static string stringToString(this string stringMove)
        {
            String date; //hold the result 

            char[] delim = { '/' }; // Token delimiter 

            string[] tokens = stringMove.Split(delim); //Tokenize the string

            // Validate 
            if (tokens.Length == 3)
            {
                date = tokens[0] + "  " + tokens[1] + "  " + tokens[2] + "  "; 
            }
            else
            {
                date = stringMove;

            }
            return date;
        }
    }
}
