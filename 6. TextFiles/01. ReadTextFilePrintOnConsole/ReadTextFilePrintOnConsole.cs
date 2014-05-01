//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

namespace _01.ReadTextFilePrintOnConsole
{
    class ReadTextFilePrintOnConsole
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader("Levski.txt", Encoding.GetEncoding("Windows-1251")))
            {
                int lineNumber = 1;
                string line = sr.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine("Ред {0}: {1}", lineNumber, line);
                    }
                    lineNumber++;
                    line = sr.ReadLine();
                }
            }
        }
    }
}
