using System;

namespace _5.Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int firtsNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            string typeProduct = FindsTypeProductWithoutMultiplying(firtsNumber, secondNumber, thirdNumber);
            Console.WriteLine(typeProduct);
        }

        private static string FindsTypeProductWithoutMultiplying(int firtsNumber, int secondNumber, int thirdNumber)
        {
            string typeProduct = string.Empty;

            if(firtsNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                typeProduct = "zero";
            }
            else if(firtsNumber > 0 && secondNumber > 0 && thirdNumber > 0)
            {
                typeProduct = "positive";
            }
            else
            {
                if(firtsNumber < 0 )
                {
                    if(secondNumber > 0 && thirdNumber > 0)
                    {
                        typeProduct = "negative";
                    }
                    else if(secondNumber < 0 && thirdNumber < 0)
                    {
                        typeProduct = "negative";
                    }
                    else if(secondNumber < 0 && thirdNumber > 0)
                    {
                        typeProduct = "positive";
                    }
                    else if(secondNumber > 0 && thirdNumber < 0)
                    {
                        typeProduct = "positive";
                    }
                }
                else if (secondNumber < 0)
                {
                    if (firtsNumber > 0 && thirdNumber > 0)
                    {
                        typeProduct = "negative";
                    }
                    else if (firtsNumber < 0 && thirdNumber < 0)
                    {
                        typeProduct = "negative";
                    }
                    else if (firtsNumber < 0 && thirdNumber > 0)
                    {
                        typeProduct = "positive";
                    }
                    else if (firtsNumber > 0 && thirdNumber < 0)
                    {
                        typeProduct = "positive";
                    }
                }
                else if (thirdNumber < 0)
                {
                    if (secondNumber > 0 && firtsNumber > 0)
                    {
                        typeProduct = "negative";
                    }
                    else if (secondNumber < 0 && firtsNumber < 0)
                    {
                        typeProduct = "negative";
                    }
                    else if (secondNumber < 0 && firtsNumber > 0)
                    {
                        typeProduct = "positive";
                    }
                    else if (secondNumber > 0 && firtsNumber < 0)
                    {
                        typeProduct = "positive";
                    }
                }
            }

            return typeProduct;
        }
    }
}
