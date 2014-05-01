//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _11.DeleteAllWordsThatStartWithTest
{
    class DeleteAllWordsThatStartWithTest
    {

        static void Main()
        {
            using (StreamReader input = new StreamReader("input.txt", Encoding.GetEncoding("UTF-8")))
            {
                using (StreamWriter output = new StreamWriter("output.txt", true, Encoding.GetEncoding("UTF-8")))
                {

                    string line = input.ReadLine();

                    while (line != null)
                    {
                        output.WriteLine(Regex.Replace(line, @"\btest\w*\b", string.Empty));
                        line = input.ReadLine();
                    }
                }

            }
        }
    }
}
