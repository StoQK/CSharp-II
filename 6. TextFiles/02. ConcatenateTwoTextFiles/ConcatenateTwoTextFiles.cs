//Write a program that concatenates two text files into another text file.

using System;
using System.Text;
using System.IO;

namespace _02.ConcatenateTwoTextFiles
{
    class ConcatenateTwoTextFiles
    {
        static void Main()
        {
           using (StreamReader firstText = new StreamReader("NBA.txt", Encoding.GetEncoding("UTF-8")))
           {
               using (StreamWriter concatenated = new StreamWriter("Concatenated.txt", false, Encoding.GetEncoding("UTF-8")))
               {
                   string line = firstText.ReadLine();

                   while (line != null)
                   {
                       concatenated.WriteLine(line);
                       line = firstText.ReadLine();
                   }
               }
           }
            
           using (StreamReader secondText = new StreamReader("LeBron James.txt", Encoding.GetEncoding("UTF-8")))
           {
               using (StreamWriter concatenated = new StreamWriter("Concatenated.txt", true, Encoding.GetEncoding("UTF-8")))
               {
                   string line = secondText.ReadLine();
                   concatenated.WriteLine();

                   while (line != null)
                   {
                       concatenated.WriteLine(line);
                       line = secondText.ReadLine();
                   }
               }
           }
        }
    }
}
