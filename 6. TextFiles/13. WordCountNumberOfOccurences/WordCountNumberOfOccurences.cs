//Write a program that reads a list of words from a file words.txt 
//and finds how many times each of the words is contained in another file test.txt. 
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. 
//Handle all possible exceptions in your methods.

using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace _13.WordCountNumberOfOccurences
{
    class WordCountNumberOfOccurences
    {
        static void Main()
        {
            string input = "test.txt";
            string output = "result.txt";
            string words = "words.txt";

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            try
            {
                using (StreamReader reader = new StreamReader(words, Encoding.GetEncoding("UTF-8")))
                {
                    while (!reader.EndOfStream)
                    {
                        string word = reader.ReadLine();
                        dictionary.Add(word, 0);
                    }
                }

                using (StreamReader reader = new StreamReader(input, Encoding.GetEncoding("UTF-8")))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        List<string> wordList = new List<string>(dictionary.Keys);

                        foreach (string word in wordList)
                        {
                            string regex = String.Format("\\b{0}\\b", word);
                            MatchCollection matches = Regex.Matches(line, regex);
                            dictionary[word] += matches.Count;
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(output, false, Encoding.GetEncoding("UTF-8")))
                {
                    foreach (var wordCounter in dictionary.OrderByDescending(key => key.Value))
                    {
                        writer.Write(wordCounter.Key);
                        writer.Write(" - ");
                        writer.WriteLine(wordCounter.Value);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (RegexMatchTimeoutException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
