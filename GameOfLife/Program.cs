namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;


            Console.WriteLine("Podaj życie jakiej figury chcesz zobaczyc");
            Console.Write("1.BeeHive\n" +
                "2.Loaf\n" +
                "3.Boat\n" +
                "4.Block\n" +
                "5.Tub\n" +
                "6.Blinker\n" +
                "7.Glider\n");

            bool success = int.TryParse(Console.ReadLine(), out input);

            if (!success || input < 0 || input > 7)
            {
                Console.WriteLine("Błąd we wprowadzeniu");
            }

            else
            {
                switch (input)
                {
                    case 1:
                        BeeHive bee = new BeeHive();
                        LifeCycle.Live(bee);
                        break;

                    case 2:
                        Loaf loaf = new Loaf();
                        LifeCycle.Live(loaf);
                        break;
                    case 3:
                        Boat boat = new Boat();
                        LifeCycle.Live(boat);
                        break;
                    case 4:
                        Block block = new Block();
                        LifeCycle.Live(block);
                        break;
                    case 5:
                        Tub tub = new Tub();
                        LifeCycle.Live(tub);
                        break;
                    case 6:
                        Blinker blink = new Blinker();
                        LifeCycle.Live(blink);
                        break;
                    case 7:
                        Glider glider = new Glider();
                        LifeCycle.Live(glider);
                        break;

                }
            }

        }
    }
}