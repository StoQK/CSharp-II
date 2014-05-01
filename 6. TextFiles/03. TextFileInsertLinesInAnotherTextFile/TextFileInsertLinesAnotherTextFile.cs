//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

using System;
using System.Text;
using System.IO;

namespace _03.TextFileInsertLinesInAnotherTextFile
{
    class TextFileInsertLinesAnotherTextFile
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader("Levski.txt", Encoding.GetEncoding("windows-1251")))
            {
                using (StreamWriter sw = new StreamWriter("Levski2.txt", false, Encoding.GetEncoding("windows-1251")))
                {
                    int lineNumber = 0;

                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;
                        sw.WriteLine("{0}. {1}", lineNumber, line);
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}
