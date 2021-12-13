
namespace GameOfLife
{
    internal class Patterns
    {
        TableHandling tab;

        public const int tabWidth = 25;
        public const int tabHeight = 25;

        public List<List<int>> board = new List<List<int>>();
        public List<List<int>> board2 = new List<List<int>>();

        public Patterns()
        {
            for (int i = 0; i < tabHeight; i++)
            {
                List<int> row = new List<int>();
                List<int> row2 = new List<int>();


                board.Add(row);
                board2.Add(row2);

                board[i].AddRange(Enumerable.Repeat(0, tabWidth));
                board2[i].AddRange(Enumerable.Repeat(0, tabWidth));
            }
        }

    }

    class block : Patterns
    {

        public block() : base()
        {
            board[11][12] = 1;
            board[12][12] = 1;
            board[13][12] = 1;

        }
    }
}
