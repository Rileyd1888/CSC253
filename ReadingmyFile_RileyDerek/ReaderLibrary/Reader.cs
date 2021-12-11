using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReaderLibrary
{
    public static class Reader
    {
        public static string ReadPeopleFile()
        {
          

            //Try - catch to read file 
            try
            {

                String userName = "";
               

                StreamReader inputFile;


                inputFile = File.OpenText(@"E:\Fall 2021\CSC  C#\InfoToFile_Riley\WriteClassUI\bin\Debug\UserInformation.txt");
                // loop to read file 
                while (!inputFile.EndOfStream)
                {
                    userName = inputFile.ReadLine();

                    return userName;


               }
               
               
                inputFile.Close();

                return userName;
             
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return message;
            }
        }
    }
}
