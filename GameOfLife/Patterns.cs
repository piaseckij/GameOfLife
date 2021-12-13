
namespace GameOfLife
{
    internal class Patterns
    {
        TableHandling tab;

        public const int tabWidth = 25;
        public const int tabHeight = 25;

        public int[,] board = new int[tabWidth, tabHeight];
        public int[,] board2 = new int[tabWidth, tabHeight];


        public Patterns()
        {
            for (int i = 0; i < tabHeight; i++)
            {
                for (int j = 0; j < tabWidth; j++)
                {
                    board[i, j] = 0;
                    board2[i, j] = 0;
                }
            }
        }

    }

    class block : Patterns
    {

        public block() : base()
        {
            board[11,12] = 1;
            board[12,12] = 1;
            board[13,12] = 1;

        }
    }
}
