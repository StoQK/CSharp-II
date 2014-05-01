using System;
using System.Text;

class DecimalToHexConversion
{
    static void Main()
    {
        Console.Write("n = ");
        int num = int.Parse(Console.ReadLine());
        StringBuilder hex = new StringBuilder();
        while (num > 0)
        {
            switch (num % 16)
            {
                case 10:
                    hex.Append('A');
                    break;
                case 11:
                    hex.Append('B');
                    break;
                case 12:
                    hex.Append('C');
                    break;
                case 13:
                    hex.Append('D');
                    break;
                case 14:
                    hex.Append('E');
                    break;
                case 15:
                    hex.Append('F');
                    break;
                default:
                    hex.Append(num % 16);
                    break;
            }
            num /= 16;
        }
        string finalNum = hex.ToString();
        Console.Write("Hexadecimal representation: ");
        for (int i = finalNum.Length - 1; i > -1; i--)
        {
            Console.Write(finalNum[i]);
        }
        Console.WriteLine();
    }
}

