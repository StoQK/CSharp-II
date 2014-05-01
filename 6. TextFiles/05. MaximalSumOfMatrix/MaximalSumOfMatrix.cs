//Write a program that reads a text file containing a square matrix of numbers 
//and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. 

using System;
using System.IO;
using System.Text;

namespace _05.MaximalSumOfMatrix
{
    class MaximalSumOfMatrix
    {
        static int[,] GetMatrixInput()
        {
            using (StreamReader input = new StreamReader("Matrix.txt", Encoding.GetEncoding("UTF-8")))
            {
                string line = input.ReadLine();
                int size = int.Parse(line);
                int[,] matrix = new int[size, size];

                for (int i = 0; i < size; i++)
                {
                    string[] numbers = input.ReadLine().Split(' ');

                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j] = int.Parse(numbers[j]);
                    }
                }
                return matrix;
            }
        }
        static int GetMaxSum(int[,] matrix)
        {
            int bestSum = int.MinValue;

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    bestSum = Math.Max(bestSum, matrix[rows, cols] + matrix[rows + 1, cols] +
                                                matrix[rows, cols + 1] + matrix[rows + 1, cols + 1]);
                }
            }
            return bestSum;
        }

        static void PrintResultInTextFile(int maxSum)
        {
            using (StreamWriter output = new StreamWriter("Result.txt", true, Encoding.GetEncoding("UTF-8")))
            {
                output.WriteLine(maxSum);
            }
        }
        static void Main()
        {
            PrintResultInTextFile(GetMaxSum(GetMatrixInput()));
        }
    }
}
