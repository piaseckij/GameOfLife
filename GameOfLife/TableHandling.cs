namespace GameOfLife
{

    internal class TableHandling
    {
        //public int tableWidth; //X
        //public int tableHeight; //Y

        //public List<List<int>> frame1 = new List<List<int>>();
        //public List<List<int>> frame2 = new List<List<int>>();


        //public void generateTable()
        //{

        //    (int, int) tableSize = (50, 50);
        //        /*DataHandling.receiveTableSize();*/

        //    tableWidth = tableSize.Item1;
        //    tableHeight = tableSize.Item2;


        //    for (int i = 0; i < tableHeight; i++)
        //    {
        //        List<int> wiersz = new List<int>();
        //        frame1.Add(wiersz);
        //        frame2.Add(wiersz);


        //        frame1[i].AddRange(Enumerable.Repeat(0, tableWidth));
        //        frame2[i].AddRange(Enumerable.Repeat(0, tableWidth));
        //    }

        //    for (int i = 0; i < tableWidth; i++)
        //    {
        //        for (int j = 0; j < tableHeight; j++)
        //        {
        //            frame1[i][j] = 0;
        //            frame2[i][j] = 0;

        //        }
        //    }
        //}
        public void showTable(Patterns pat)
        {

            for (int i = 0; i < Patterns.tabHeight; i++)
            {
                for (int j = 0; j < Patterns.tabWidth; j++)
                {
                    Console.Write(pat.board[i][j] + " ");

                }
                Console.WriteLine();
            }

            
        }

        public void showTable2(Patterns pat)
        {
            for (int i = 0; i < Patterns.tabHeight; i++)
            {
                for (int j = 0; j < Patterns.tabWidth; j++)
                {
                    Console.Write(pat.board2[i][j] + " ");

                }
                Console.WriteLine();
            }
        }




    }


}

