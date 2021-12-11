using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RandomLibrary
{
    public static class RaNum
    {
        // method
        public static int randomNumbers(int randomNumber)
        {
            try
            {

                // creating object
                StreamWriter outputFile;

                //creating the place to write the data 
                outputFile = File.CreateText("RandomNumber.txt");

                
                Random rand = new Random(100);
             

                while (randomNumber <= 100)
                {
                    //Write random numbers 1 - 100 to the file 
                    for (int count = 0; count < randomNumber; count++)
                    {
                        outputFile.WriteLine(rand.Next(100));
                    }

                    //closing output file 
                    outputFile.Close();

                    
                }
                //returning variable 
                return randomNumber;

            }
            catch (Exception ex)
            {
                // catch error message
                string exceptionVariable = ex.Message;
                return 1;
            }
        
        }
    }
}
