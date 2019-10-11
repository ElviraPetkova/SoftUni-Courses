namespace P03_JediGalaxy
{
    public class Evil
    {
        public int Row { get; private set; }

        public int Col { get; private set; }

        public void UpdateCoordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
}
