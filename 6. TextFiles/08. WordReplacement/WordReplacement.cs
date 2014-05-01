//Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace _08.WordReplacement
{
    class WordReplacement
    {

        static void Main()
        {
            using (StreamReader input = new StreamReader("input.txt", Encoding.GetEncoding("UTF-8")))
            {
                using (StreamWriter output = new StreamWriter("output.txt", true, Encoding.GetEncoding("UTF-8")))
                {
                    string lines = input.ReadLine();

                    while (lines != null)
                    {
                        output.WriteLine(Regex.Replace(lines, @"\bstart\b", "finish"));
                        lines = input.ReadLine();
                    }

                }
            }
        }
    }
}