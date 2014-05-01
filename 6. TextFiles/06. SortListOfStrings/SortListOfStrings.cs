//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
//Example:

//Ivan			George
//Peter			Ivan
//Maria			Maria
//George		Peter

using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace _06.SortListOfStrings
{
    class SortListOfStrings
    {
        static List<string> GetInput()
        {
            List<string> linesInput = new List<string>();
            using (StreamReader input = new StreamReader("input.txt", Encoding.GetEncoding("UTF-8")))
            {
                string line = input.ReadLine();
                
                while (line != null)
                {
                    linesInput.Add(line);
                    line = input.ReadLine();
                }
                
            }
            return linesInput;
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
            List<string> lines = GetInput();
            lines.Sort();
            WriteOutput(lines);
        }
    }
}
