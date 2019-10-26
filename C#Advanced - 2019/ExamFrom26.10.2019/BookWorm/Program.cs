namespace BookWorm
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int size = int.Parse(Console.ReadLine());

            char[][] field = ComleteField(size);
            int[] positionByPlayer = GetPosition(field, 'P');

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                int row = positionByPlayer[0];
                int col = positionByPlayer[1];
                switch (command)
                {
                    case "up": row--; break;
                    case "down": row++; break;
                    case "left": col--; break;
                    case "right": col++; break;
                }

                bool inSide = ValidationPosition(field, row, col);
                if (inSide)
                {
                    if(char.IsLetter(field[row][col]))
                    {
                        text = Concatenates(text, field[row][col]);
                    }

                    field[positionByPlayer[0]][positionByPlayer[1]] = '-';
                    positionByPlayer[0] = row;
                    positionByPlayer[1] = col;
                    field[positionByPlayer[0]][positionByPlayer[1]] = 'P';
                }
                else
                {
                    text = RemoveLastLetter(text);
                }
            }

            Console.WriteLine(text);
            foreach (var row in field)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static string Concatenates(string text, char value)
            => text + value.ToString();

        private static string RemoveLastLetter(string text)
            => text.Remove(text.Length - 1, 1);

        private static bool ValidationPosition(char[][] field, int row, int col)
            => row >= 0 && row < field.GetLength(0) && col >= 0 && col < field[row].Length;

        private static int[] GetPosition(char[][] field, char value)
        {
            int[] position = new int[2];

            for (int row = 0; row < field.GetLength(0); row++)
            {
                var col = field[row];
                if (col.Contains(value))
                {
                    int indexOfCol = Array.IndexOf(col, value);
                    position[0] = row;
                    position[1] = indexOfCol;
                    break;
                }
            }

            return position;
        }

        private static char[][] ComleteField(int size)
        {
            char[][] field = new char[size][];
            for (int row = 0; row < size; row++)
            {
                field[row] = Console.ReadLine().ToCharArray();
            }

            return field;
        }
    }
}
