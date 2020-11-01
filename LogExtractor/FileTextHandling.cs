using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LogExtractor
{
    class FileTextHandling
    {
        String myRexex = "TC[0-9]+ ";
        //String myRexex = rexExpTextBox.Text;
        string[] fileList = { @"C:\Users\gadif\Documents\SPIRA_PLUGIN\Latest_Logs\SQALAB1_Shell_TraceLog.txt" };
        List<string> extractedTTxt = new List<string>();


        public void matchRegExAfter(string RegX, String inputFile)
        {
            Regex _regex = new Regex(myRexex);

            //foreach (string file in fileList)
            //{
                using (System.IO.StreamReader reader = new StreamReader(inputFile))
                {
                    //while ((line = reader.ReadLine()) != null)
                    while (!reader.EndOfStream)
                    {
                        String currentLine = reader.ReadLine();
                        // Try to match each line against the Regex.
                        Match match = _regex.Match(currentLine);

                        int idx = match.Index;

                        if (match.Success && currentLine.Length > 0)
                        {

                            Console.WriteLine(currentLine.Substring(idx));
                            extractedTTxt.Add(currentLine.Substring(idx));

                        }
                    }
                }

                //return "";
            

            //return null;
        }

        public void SaveToLog(string fileName)
        {
            using (System.IO.StreamWriter file =
                //new System.IO.StreamWriter(@"\Users\gadif\Documents\SPIRA_PLUGIN\PlatinumDriveSmoke\SQALAB2\SQALAB2_Shell_TraceLog-EXTRACTED2", true))
                new System.IO.StreamWriter(fileName, false))
            {
                foreach (string line in extractedTTxt)
                {
                    file.WriteLine(line);
                }
            }
        }

    }
}
