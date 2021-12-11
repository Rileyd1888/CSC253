using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinishReadingLibrary
{
    public static class Reader
    {
        public static string ReadPeopleFile()
        {
            StreamReader inputFile;

            try
            {
                inputFile = File.OpenText(@"E:\Fall 2021\CSC  C#\Redo_WriteToFile_RileyDerek\Redo_WriteToFileUI\bin/Debug\UserInformation.csv");

                while (!inputFile.EndOfStream)
                {
                    string[] tokens = inputFile.ReadLine().Split(',');

                    ListBuilder.people.Add(new DemoClass(tokens[0], tokens[1], tokens[2], int.Parse(tokens[3])));

                }

                inputFile.Close();
                //return "Loaded";

                return "Loaded";
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return message;
            }
        }
    }
}
