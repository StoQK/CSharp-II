//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace _07.SubstringReplacement
{
    class SubstringReplacement
    {
        static List<string> GetInput()
        {
            List<string> linesList = new List<string>();
            using (StreamReader input = new StreamReader("input.txt", Encoding.GetEncoding("UTF-8")))
            {
                string lines = input.ReadLine();

                while (lines != null)
                {
                    string newLines = lines.Replace("start", "finish");
                    linesList.Add(newLines);
                    lines = input.ReadLine();
                }
            }
            return linesList;
        }

        static void WriteOutput(List<string> lines)
        {
            using (StreamWriter output = new StreamWriter("output.txt", true, Encoding.GetEncoding("UTF-8")))
            {
                foreach (var line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }

        static void Main()
        {
            WriteOutput(GetInput());
        }
    }
}
