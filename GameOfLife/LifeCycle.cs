namespace GameOfLife
{
    internal class LifeCycle
    {
        public void checkDie(Patterns pat)
        {

            int suma = 0;
            for (int i = 1; i < Patterns.tabHeight - 1; i++)
            {
                for (int j = 1; j < Patterns.tabWidth - 1; j++)
                {


                    suma = 0;

                    suma = pat.board[i - 1][j] + pat.board[i + 1][j] + pat.board[i][j - 1] + pat.board[i][j + 1] +
                        pat.board[i - 1][j + 1] + pat.board[i + 1][j + 1] + pat.board[i - 1][j - 1] + pat.board[i - 1][j + 1];

                    if (suma == 2 || suma == 3)
                    {
                        pat.board2[i-1][j-1] = 1;

                    }
                    else
                    {
                        pat.board2[i][j] = 0;
                    }



                }

            }

        }

    }
}
