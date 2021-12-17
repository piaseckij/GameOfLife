namespace GameOfLife
{
    internal static class LifeCycle
    {

        public static void CheckDie(Patterns pat)
        {



            int suma;
            for (int i = 1; i < Patterns.tabHeight - 1; i++)
            {
                for (int j = 1; j < Patterns.tabWidth - 1; j++)
                {


                    suma = 0;

                    suma = pat.board[i, j - 1] + pat.board[i, j + 1] + pat.board[i - 1, j] + pat.board[i + 1, j] +
                        pat.board[i - 1, j + 1] + pat.board[i + 1, j + 1] + pat.board[i - 1, j - 1] + pat.board[i + 1, j - 1];

                    if (pat.board[i, j] == 1 && (suma == 2 || suma == 3))
                    {

                        pat.board2[i, j] = 1;


                    }


                    else if (pat.board[i, j] == 0 && suma == 3)
                    {

                        pat.board2[i, j] = 1;

                    }
                    else
                    {

                        pat.board2[i, j] = 0;
                    }


                }
            }

            var temp = pat.board2;
            pat.board2 = pat.board;
            pat.board = temp;



            Patterns.ClearTable(pat.board2);

        }
        public static void Live(Patterns pat)
        {
            int z = 0;
            do
            {

                TableHandling.ShowTable(pat);
                CheckDie(pat);
                Thread.Sleep(1000);
                Console.Clear();

            } while (z == 0);
        }







    }
}
