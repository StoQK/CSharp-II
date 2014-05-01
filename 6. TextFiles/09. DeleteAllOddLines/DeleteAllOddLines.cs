//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

namespace _09.DeleteAllOddLines
{
    class DeleteAllOddLines
    {
        static List<string> ReadEvenLines()
        {
            List<string> lines = new List<string>();
            int currentLine = 1;

            using (StreamReader input = new StreamReader("../../input.txt"))
            {
                string line = input.ReadLine();

                while (line != null)
                {
                    if (currentLine % 2 == 0)
                    {
                        lines.Add(line);
                    }
                    currentLine++;
                    line = input.ReadLine();
                }

                return lines;
            }
        }

        static void WriteOutput(List<string> lines)
        {
            using (StreamWriter output = new StreamWriter("../../input.txt"))
            {
                foreach (var line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }

        static void Main()
        {
            WriteOutput(ReadEvenLines()); 
        }
    }
}
