//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Text;

class BinaryToHexConversion
{
    static string ConvertBinaryToHex(string binInput)
    {
        for (int i = 4; i < 32; i *= 4)
        {
            if (binInput.Length < i)
            {
                string leadingZeros = new String('0', i - binInput.Length);
                binInput = leadingZeros + binInput;
                break;
            }
        }
        StringBuilder binStr = new StringBuilder();
        for (int i = 0; i < binInput.Length; i += 4)
        {
            switch (binInput.Substring(i, 4))
            {
                case "0000": binStr.Append("0"); break;
                case "0001": binStr.Append("1"); break;
                case "0010": binStr.Append("2"); break;
                case "0011": binStr.Append("3"); break;
                case "0100": binStr.Append("4"); break;
                case "0101": binStr.Append("5"); break;
                case "0110": binStr.Append("6"); break;
                case "0111": binStr.Append("7"); break;
                case "1000": binStr.Append("8"); break;
                case "1001": binStr.Append("9"); break;
                case "1010": binStr.Append("A"); break;
                case "1011": binStr.Append("B"); break;
                case "1100": binStr.Append("C"); break;
                case "1101": binStr.Append("D"); break;
                case "1110": binStr.Append("E"); break;
                case "1111": binStr.Append("F"); break;
                default:
                    break;
            }
        }
        return binStr.ToString();
    }
    static void Main()
    {
        Console.Write("Binary number = ");
        string input = Console.ReadLine();
        Console.Write("Hexadecimal representation: 0x{0}", ConvertBinaryToHex(input));
        Console.WriteLine();
    }
}

