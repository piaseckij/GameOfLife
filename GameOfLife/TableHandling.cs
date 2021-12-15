namespace GameOfLife
{

    internal static class TableHandling
    {
        public static void showTable(Patterns pat)
        {

            for (int i = 0; i < Patterns.tabHeight; i++)
            {
                for (int j = 0; j < Patterns.tabWidth; j++)
                {
                    if (pat.board[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(pat.board[i, j] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.Write(pat.board[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }


        }

    }


}

