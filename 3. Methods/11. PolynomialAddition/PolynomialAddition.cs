using System;

class PolynomialAddition
{
    class Polynomials
    {
        //sum polinomials
        static void SumOfPolinomials(decimal[] firstPolinomial, decimal[] secondPolinomial, decimal[] result)
        {
            int minLenght = 0;
            int smallerPolinomial = 0;

            if (firstPolinomial.Length > secondPolinomial.Length)
            {
                minLenght = secondPolinomial.Length;
                smallerPolinomial = 2;
            }
            else
            {
                minLenght = firstPolinomial.Length;
                smallerPolinomial = 1;
            }

            for (int i = 0; i < minLenght; i++)
            {
                result[i] = firstPolinomial[i] + secondPolinomial[i];
            }

            for (int i = minLenght; i < result.Length; i++)
            {
                if (smallerPolinomial == 1)
                {
                    result[i] = secondPolinomial[i];
                }
                else
                {
                    result[i] = firstPolinomial[i];
                }
            }
        }

        static void PrintPolinomial(decimal[] polinomial)
        {
            for (int i = polinomial.Length - 1; i >= 0; i--)
            {
                if (polinomial[i] != 0 && i != 0)
                {
                    if (polinomial[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} +", i, polinomial[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, polinomial[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", polinomial[i]);
                }
            }

            Console.WriteLine();
        }

        static void Main()
        {
            decimal[] firstPolinomial = { 5, -1 };
            Console.Write("First polinomial:                 ");
            PrintPolinomial(firstPolinomial);

            decimal[] secondPolinomial = { 10, -5, 6 };
            Console.Write("Second polinomial:                ");
            PrintPolinomial(secondPolinomial);

            int maxLenght = 0;
            if (firstPolinomial.Length > secondPolinomial.Length)
            {
                maxLenght = firstPolinomial.Length;
            }
            else
            {
                maxLenght = secondPolinomial.Length;
            }

            decimal[] result = new decimal[maxLenght];
            Console.WriteLine();

            //sum the polinomials into result
            SumOfPolinomials(firstPolinomial, secondPolinomial, result);

            //print the sum
            Console.Write("Sum:                              ");
            PrintPolinomial(result);

        }
    }
}
