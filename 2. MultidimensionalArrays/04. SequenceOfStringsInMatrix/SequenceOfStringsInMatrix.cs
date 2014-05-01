// We are given a matrix of strings of size N x M.
// Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class SequenceOfStringsInMatrix
{
    static void Main()
    {
        string[,] matrix = new string[,] { { "ha", "fifi", "ho", "hi" }, 
                                           { "fo", "ha", "hi", "xx", }, 
                                           {"xxx", "ho", "ha", "xx" }};
        //string[,] matrix = new string[,] { {"s", "p", "s" }, 
        //                                   {"pp", "pp", "s"}, 
        //                                   {"pp", "qq", "s"}};

        int sequence = 1;
        int bestSequence = int.MinValue;
        string commonElement = "";
        for (int row = 0; row < matrix.GetLength(0); row++) //checks all horizontal lines
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++) 
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    sequence++;
                }
                else
                {
                    sequence = 1;
                }

                if (sequence > bestSequence)
                {
                    bestSequence = sequence;
                    commonElement = matrix[row, col];
                }
            }
            sequence = 1;
        }

        for (int col = 0; col < matrix.GetLength(1); col++) // checks all vertical lines
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    sequence++;
                }
                else
                {
                    sequence = 1;
                }

                if (sequence > bestSequence)
                {
                    bestSequence = sequence;
                    commonElement = matrix[row, col];
                }
            }
            sequence = 1;
        }

        for (int row = 0; row < matrix.GetLength(0) - 1; row++) //checks all diagonals starting from top left to bottom right
        {

            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                for (int rows = row, cols = col; rows < matrix.GetLength(0) - 1 && cols < matrix.GetLength(1) - 1; rows++, cols++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        sequence++;
                    }
                    else
                    {
                        sequence = 1;
                    }

                    if (sequence > bestSequence)
                    {
                        bestSequence = sequence;
                        commonElement = matrix[row, col];
                    }
                }
                sequence = 1;
            }
        }

        for (int row = 0; row < matrix.GetLength(0) - 1; row++) // checks all diagonals starting from top right to bottom left
        {
            for (int col = matrix.GetLength(1) - 1; col > 0; col--)
            {
                for (int rows = row, cols = col; rows < matrix.GetLength(0) - 1 && cols > 0; rows++, cols--)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        sequence++;
                    }
                    else
                    {
                        sequence = 1;
                    }

                    if (sequence > bestSequence)
                    {
                        bestSequence = sequence;
                        commonElement = matrix[row, col];
                    }
                }
                sequence = 1;
            }
        }

        for (int i = 0; i < bestSequence - 1; i++)
        {
            Console.Write("{0}, ", commonElement);
        }
        Console.WriteLine("{0}", commonElement);
    }
}