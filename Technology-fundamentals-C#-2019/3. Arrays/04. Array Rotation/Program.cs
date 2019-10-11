using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            int n = int.Parse(Console.ReadLine()); 
            int[] rotation = new int[arr1.Length];
            int count = arr1.Length - 1; 

            if(n == 0)
            {
                Console.WriteLine(string.Join(" ", arr1));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (count == 0)
                    {
                        rotation[j] = arr1[count];
                        count = arr1.Length - 1;
                        break;
                    }
                    rotation[count - 1] = arr1[count];
                    count--;

                }
                if (n - i == 1)
                {
                    break;
                }
                for (int k = 0; k < arr1.Length; k++)
                {
                    arr1[k] = rotation[k];
                }
            }

            for (int i = 0; i < rotation.Length; i++)
            {
                Console.Write(rotation[i] + " ");
            }
        }
    }
}
