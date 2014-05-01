//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

namespace _12.RemoveWordsListedInSomeTextFile
{
    class RemoveWordsListedInSomeTextFile
    {
        static void Main()
        {
            try
            {
                string regex = @"\b(" + String.Join("|", File.ReadAllLines("words list.txt", Encoding.GetEncoding("UTF-8"))) + @")\b";

                using (StreamReader input = new StreamReader("text.txt", Encoding.GetEncoding("UTF-8")))
                {
                    using (StreamWriter output = new StreamWriter("output.txt", true, Encoding.GetEncoding("UTF-8")))
                    {
                        string line = input.ReadLine();
                        while (line != null)
                        {
                            output.WriteLine(Regex.Replace(line, regex, string.Empty));
                            line = input.ReadLine();
                        }
                    }
                }
            }

            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }

            catch (DirectoryNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }

            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }

            catch (SecurityException exc)
            {
                Console.WriteLine(exc.Message);
            }

            catch (UnauthorizedAccessException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
