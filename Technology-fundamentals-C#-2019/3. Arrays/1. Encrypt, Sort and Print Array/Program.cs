using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterOfNames = int.Parse(Console.ReadLine());
            List<int> numbersOfNames = new List<int>();
            char[] vowers = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u'};

            for (int i = 0; i < counterOfNames; i++)
            {
                string name = Console.ReadLine();
                int sumOfName = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    char leter = name[j];
                    bool isVower = false;
                    for (int k = 0; k < vowers.Length; k++)
                    {
                        char vower = vowers[k];
                        if(leter == vower)
                        {
                            sumOfName += (int)leter * name.Length;
                            isVower = true;
                            break;
                        }
                    }
                    if(isVower == false)
                    {
                        sumOfName += (int)leter / name.Length;
                    }
                }

                numbersOfNames.Add(sumOfName);
            }

            numbersOfNames.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, numbersOfNames));
        }
    }
}
