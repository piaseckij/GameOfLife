
namespace GameOfLife
{
    internal class Patterns
    {


        public const int tabWidth = 25;
        public const int tabHeight = 25;

        public int[,] board = new int[tabWidth, tabHeight];
        public int[,] board2 = new int[tabWidth, tabHeight];

        public static void ClearTable(int[,] tab)
        {
            for (int i = 0; i < tabHeight; i++)
            {
                for (int j = 0; j < tabWidth; j++)
                {
                    tab[i, j] = 0;
                    tab[i, j] = 0;
                }
            }
        }

        public Patterns()
        {
            ClearTable(board);
            ClearTable(board2);
        }

    }

    class Block : Patterns
    {

        public Block() : base()
        {
            board[11, 12] = 1;
            board[11, 13] = 1;
            board[12, 12] = 1;
            board[12, 13] = 1;
        }
    }

    class BeeHive : Patterns
    {
        public BeeHive() : base()
        {
            board[12, 12] = 1;
            board[12, 13] = 1;
            board[11, 14] = 1;
            board[10, 12] = 1;
            board[10, 13] = 1;
            board[11, 11] = 1;

        }

    }

    class Loaf : Patterns
    {
        public Loaf() : base()
        {
            board[10, 11] = 1;
            board[10, 12] = 1;
            board[11, 13] = 1;
            board[12, 13] = 1;
            board[13, 12] = 1;
            board[12, 11] = 1;
            board[11, 10] = 1;
        }
    }

    class Boat : Patterns
    {
        public Boat() : base()
        {
            board[13, 12] = 1;
            board[11, 12] = 1;
            board[12, 13] = 1;
            board[12, 11] = 1;
            board[11, 11] = 1;

        }
    }

    class Tub : Patterns
    {
        public Tub() : base()
        {
            board[13, 12] = 1;
            board[11, 12] = 1;
            board[12, 13] = 1;
            board[12, 11] = 1;

        }
    }

    class Glider : Patterns
    {
        public Glider() : base()
        {
            board[9, 12] = 1;
            board[10, 13] = 1;
            board[10, 14] = 1;
            board[9, 14] = 1;
            board[8, 14] = 1;

        }
    }

    class Blinker : Patterns
    {
        public Blinker() : base()
        {
            board[11, 12] = 1;
            board[12, 12] = 1;
            board[13, 12] = 1;
        }
    }
}