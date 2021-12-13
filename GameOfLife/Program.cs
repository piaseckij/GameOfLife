namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            TableHandling table=new TableHandling();
            LifeCycle life=new LifeCycle();
            block blok=new block();

            table.showTable(blok);
            life.checkDie(blok);
            Console.ReadLine();
            Console.Clear();
            table.showTable2(blok);
            
            Console.WriteLine();
        }
    }
}