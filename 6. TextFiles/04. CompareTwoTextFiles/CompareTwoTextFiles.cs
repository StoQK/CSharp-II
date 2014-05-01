//Write a program that compares two text files line by line and prints the number of lines that are the same
//and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.Text;
using System.IO;
namespace _04.CompareTwoTextFiles
{
    class CompareTwoTextFiles
    {
        static void Main()
        {
            int countSameLines = 0;
            int countDifferentLines = 0;

            using (StreamReader textFile = new StreamReader("TextFiles.txt", Encoding.GetEncoding("UTF-8")))
            {
                using (StreamReader textFile2 = new StreamReader("TextFiles2.txt", Encoding.GetEncoding("UTF-8")))
                {
                    string lineFirstText = textFile.ReadLine();
                    string lineSecondText = textFile2.ReadLine();

                    while (lineFirstText != null && lineSecondText != null)
                    {
                        if (lineFirstText == lineSecondText)
                        {
                            countSameLines++;
                        }
                        else if (lineFirstText != lineSecondText)
                        {
                            countDifferentLines++;
                        }

                        lineFirstText = textFile.ReadLine();
                        lineSecondText = textFile2.ReadLine();
                    }
                }
            }
            Console.Write("Number of same lines: {0}", countSameLines);
            Console.WriteLine();
            Console.Write("Number of different lines: {0}", countDifferentLines);
            Console.WriteLine();
        }
    }
}
