//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class PlatformInAMatrix
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        var matrix = new int[n,m];
        long sum = 0;
        long bestSum = long.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("index [{0},{1}]:", i, j );
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        //var randomNumber = new Random();
        //for (int i = 0; i < n; i++)
        //    for (int j = 0; j < m; j++)
        //        matrix[i, j] = randomNumber.Next(1, 101);

        int platformMaxX = 3;
        int platformMaxY = 3;

        for (int row = 0; row < matrix.GetLength(0) - (platformMaxX - 1) ; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - (platformMaxY - 1); col++)
            {
                sum = 0;
                for (int platformX = row; platformX < row + platformMaxX; platformX++)
                {
                    for (int platformY = col; platformY < col + platformMaxY; platformY++)
                    {
                        sum += matrix[platformX, platformY];
                    }
                }
                if (sum > bestSum)
                {
                    bestRow = row;
                    bestCol = col;
                    bestSum = sum;
                }
            }
        }

        Console.WriteLine(bestSum);

        for (int row = bestRow; row < bestRow + platformMaxX; row++)
        {
            for (int col = bestCol; col < bestCol + platformMaxY; col++)
            {
                Console.Write("{0,-4}",matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

