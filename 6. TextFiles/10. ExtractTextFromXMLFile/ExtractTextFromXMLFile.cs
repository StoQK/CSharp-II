//Write a program that extracts from given XML file all the text without the tags. 

using System;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace _10.ExtractTextFromXMLFile
{
    class ExtractTextFromXMLFile
    {
        static void Main()
        {

            using (StreamReader reader = new StreamReader("input.txt", Encoding.GetEncoding("windows-1251")))
            {
                bool writeLetter = false;
                int letterCode = reader.Read();
                while (letterCode != -1)
                {
                    if (letterCode == '>')
                    {
                        writeLetter = true;
                    }
                    if (letterCode == '<')
                    {
                        writeLetter = false;
                    }
                    if (writeLetter && letterCode != '>')
                    {
                        Console.Write((char)letterCode);
                    }
                    letterCode = reader.Read();
                }
            }
            Console.WriteLine();

            Process openFile = new Process();
            openFile.StartInfo.FileName = "input.txt";
            openFile.Start();
        }
    }
}
