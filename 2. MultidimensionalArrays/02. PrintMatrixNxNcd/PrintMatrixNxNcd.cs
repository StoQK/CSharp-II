//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class PrintMatrixNxNcd
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        string direction = "down";
        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "down" && (currentRow >= n || matrix[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol++;
                direction = "right";
            }

            else if (direction == "right" && (currentCol >= n || matrix[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol--;
                direction = "up";
            }

            else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol++;
                direction = "down";
            }

            matrix[currentRow, currentCol] = i;

            if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }

        Console.WriteLine("d)");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        int number = 1;

        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < n - row; col++)
            {
                matrix[row + col, col] = number;
                number++;
            }
        }

        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < n - col; row++)
            {
                matrix[row, col + row] = number;
                number++;
            }
        }

        Console.WriteLine("c)");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,-4}", matrix[i, j]);
            }
            Console.WriteLine();
        } 
    }
}

