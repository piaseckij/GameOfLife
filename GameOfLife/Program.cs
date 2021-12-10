namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            TableHandling table=new TableHandling();


            table.generateTable();
            table.showTable();

            Console.WriteLine();
        }
    }
}