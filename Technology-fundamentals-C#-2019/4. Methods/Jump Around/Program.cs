using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Around
{
    class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxIndex = array.Length - 1;
            int sum = 0;
            int index = 0;

            while (true)
            {
                sum += array[index];
                int nextIndex = index + array[index];

                if(nextIndex <= maxIndex)
                {
                    index = nextIndex;
                    continue;
                }

                nextIndex = index - array[index];

                if(nextIndex >= 0)
                {
                    index = nextIndex;
                    continue;
                }

                break;
            }


            Console.WriteLine(sum);
        }

        
    }
}
