using System;

class HexToDecimalConversion
{
    static void Main()
    {
        Console.Write("Hex = ");
        string hex = Console.ReadLine().ToUpper();

        int count = hex.Length - 1;
        int digit;
        int result = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
                default: digit = int.Parse(Convert.ToString(hex[i])); break;
            }

            result = result + digit * Pow(count);
            count--;
        }

        Console.WriteLine();
        Console.WriteLine(result);
    }


    public static int Pow(int sqr)
    {
        return (1 << (sqr << 2));
    }
}
