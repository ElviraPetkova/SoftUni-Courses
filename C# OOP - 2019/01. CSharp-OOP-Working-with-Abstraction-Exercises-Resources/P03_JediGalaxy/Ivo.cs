namespace P03_JediGalaxy
{
    public class Ivo
    {
        public int Row { get; private set; }

        public int Col { get; private set; }

        public long Score { get; private set; }

        public void UpdateCoordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public void CollectPoints(int points)
        {
            this.Score += points;
        }
    }
}
