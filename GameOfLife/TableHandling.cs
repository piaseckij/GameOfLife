namespace GameOfLife
{

    internal class TableHandling
    {
        public int tableWidth; //X
        public int tableHeight; //Y

        List<List<int>> frame1 = new List<List<int>>();
        List<List<int>> frame2 = new List<List<int>>();


        public void generateTable()
        {

            (int, int) tableSize = DataHandling.receiveTableSize();

            tableWidth = tableSize.Item1;
            tableHeight = tableSize.Item2;


            for (int i = 0; i < tableHeight; i++)
            {
                List<int> wiersz = new List<int>();
                frame1.Add(wiersz);
                frame2.Add(wiersz);


                frame1[i].AddRange(Enumerable.Repeat(0, tableWidth));
                frame2[i].AddRange(Enumerable.Repeat(0, tableWidth));
            }

            for (int i = 0; i < tableWidth; i++)
            {
                for (int j = 0; j < tableHeight; j++)
                {
                    frame1[i][j] = 0;
                    frame2[i][j] = 0;

                }
            }
        }
        public void showTable()
        {
            for (int i = 0; i < tableHeight; i++)
            {
                for (int j = 0; j < tableWidth; j++)
                {
                    Console.Write(frame2[i][j] + " ");

                }
                Console.WriteLine();
            }
        }




    }


}

