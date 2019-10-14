namespace Throne_Conquering
{
    using System;
    using System.Linq;

    public class Program
    {
        public static int energyByParis;

        static void Main(string[] args)
        {
            energyByParis = int.Parse(Console.ReadLine());
            int numberOfRows = int.Parse(Console.ReadLine());

            char[][] fieldOfSparta = new char[numberOfRows][];

            CompleteField(fieldOfSparta, numberOfRows);

            int[] coordinationByParis = GetCoordination(fieldOfSparta, 'P');

            string command = Console.ReadLine();

            while (true)
            {
                string[] arguments = command.Split();
                string direction = arguments[0];
                int indexRowByEnemy = int.Parse(arguments[1]);
                int indexColByEnemy = int.Parse(arguments[2]);

                fieldOfSparta[indexRowByEnemy][indexColByEnemy] = 'S';

                MoveParis(fieldOfSparta, coordinationByParis, direction);
                
                energyByParis--;

                bool isReachesThron = ChekingIsReaches(fieldOfSparta, coordinationByParis);

                if (isReachesThron)
                {
                    fieldOfSparta[coordinationByParis[0]][coordinationByParis[1]] = '-';
                    Console.WriteLine($"Paris has successfully sat on the throne! Energy left: {energyByParis}");
                    break;
                }
                else
                {
                    bool isDead = ChekingIsDead(fieldOfSparta, coordinationByParis);

                    if(isDead)
                    {
                        fieldOfSparta[coordinationByParis[0]][coordinationByParis[1]] = 'X';
                        Console.WriteLine($"Paris died at {coordinationByParis[0]};{coordinationByParis[1]}.");
                        break;
                    }
                }             

                command = Console.ReadLine();
            }

           
            foreach (var row in fieldOfSparta)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static bool ChekingEnemy(char[][] fieldOfSparta, int[] coordinationByParis)
        {
            if (fieldOfSparta[coordinationByParis[0]][coordinationByParis[1]] == 'S')
            {
                return true;
            }

            return false;
        }

        private static bool ChekingIsDead(char[][] fieldOfSparta, int[] coordinationByParis)
        {
            bool isDead = false;
            if(energyByParis <= 0)
            {
                isDead = true;
            }

            if (ChekingEnemy(fieldOfSparta, coordinationByParis))
            {
                energyByParis -= 2;

                if (energyByParis > 0)
                {
                    fieldOfSparta[coordinationByParis[0]][coordinationByParis[1]] = '-';
                }
                else
                {
                    isDead = true;
                }


            }

            return isDead;
        }

        private static bool ChekingIsReaches(char[][] fieldOfSparta, int[] coordinationByParis)
        {
            if (fieldOfSparta[coordinationByParis[0]][coordinationByParis[1]] == 'H')
            {
                return true;
            }

            return false;
        }

        private static void MoveParis(char[][] fieldOfSparta, int[] coordinationByParis, string direction)
        {
            fieldOfSparta[coordinationByParis[0]][coordinationByParis[1]] = '-';

            switch (direction)
            {
                case "up":
                    if (coordinationByParis[0] - 1 >= 0)
                    {
                        coordinationByParis[0]--;
                    }
                    break;
                case "down":
                    if (coordinationByParis[0] + 1 < fieldOfSparta.GetLength(0))
                    {
                        coordinationByParis[0]++;
                    }
                    break;
                case "right":
                    if (coordinationByParis[1] + 1 < fieldOfSparta.Length - 1)
                    {
                        coordinationByParis[1]++;
                    }
                    break;
                case "left":
                    if (coordinationByParis[1] - 1 >= 0)
                    {
                        coordinationByParis[1]--;
                    }
                    break;
            }

        }

        private static int[] GetCoordination(char[][] fieldOfSparta, char player)
        {
            int[] coordinationByPlayer = new int[2];

            for (int row = 0; row < fieldOfSparta.GetLength(0); row++)
            {
                char[] currentRow = fieldOfSparta[row];
                
                if (currentRow.Contains(player))
                {
                    int indexCol = Array.IndexOf(currentRow, player);
                    coordinationByPlayer[0] = row;
                    coordinationByPlayer[1] = indexCol;

                    break;
                }
            }

            return coordinationByPlayer;
        }

        private static void CompleteField(char[][] fieldOfSparta, int numberOfRows)
        {
            for (int row = 0; row < numberOfRows; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                fieldOfSparta[row] = currentRow;
            }
        }
    }
}
