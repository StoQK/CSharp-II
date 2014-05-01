//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class PrintMatrixNxNab
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int number = 1;

        //Solution for a)
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                matrix[row, col] = number;
                number++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("a)");
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                Console.Write("{0,-4}", matrix[col, row]);
            }

            Console.WriteLine();
        }

        //Solution for b)
        number = 1;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[col, row] = number;
                    number++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[col, row] = number;
                    number++;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("b)");
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                Console.Write("{0,-4}", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}