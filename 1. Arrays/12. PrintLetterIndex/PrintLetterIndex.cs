// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.


using System;

class PrintLetterIndex
{
    static void Main()
    {
        char[] lettersArray = new char[26];
        string word = Console.ReadLine().ToLower();

        for (int i = 0; i < 26; i++)
        {
            lettersArray[i] = Convert.ToChar('a' + i);
        }
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < lettersArray.Length; j++)
            {
                if (word[i] == lettersArray[j])
                {
                    Console.WriteLine("Letter {0} is at index {1}", word[i], j + 1);
                    break;
                }
            }

        }
        
    }
}
