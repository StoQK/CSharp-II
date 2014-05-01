//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.

using System;

namespace _01.SquareRootCheck
{
    class SquareRootCheck
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            
            try
            {
                uint n = uint.Parse(Console.ReadLine());
                Console.WriteLine("Square root: {0}", Math.Sqrt(n));
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("The integer should have a value!");
            }
            catch(FormatException fe)
            {
                throw new FormatException("Invalid integer!" + fe.Message);
            }
            catch(OverflowException)
            {
                Console.Error.WriteLine("Integer out of range!");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
