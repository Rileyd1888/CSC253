using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonClassLibrary
{
    public static class Person
    {
        public static string readName(string userName)
        {
            try
            {

                // creating object
                StreamWriter outputFile;

                //creating the place to write the data 
                outputFile = File.AppendText("UserInformation.txt");

                outputFile.WriteLine(userName);

                //closing output file 
                outputFile.Close();



                //returning variable 
                return userName;

            }
            catch (Exception ex)
            {
                // catch error message
                string exceptionVariable = ex.Message;
                return exceptionVariable;
            }

        }

       
    }
}
