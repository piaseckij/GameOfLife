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
                "6.Blinker\n"+
                "7.Glider\n");

            bool success = int.TryParse(Console.ReadLine(), out input);

            if (!success)
            {
                Console.WriteLine("Błąd we wprowadzeniu");
            }

            else
            {
                switch (input)
                {
                    case 1:
                        BeeHive bee = new BeeHive();
                        LifeCycle.live(bee);
                        break;

                    case 2:
                        Loaf loaf = new Loaf();
                        LifeCycle.live(loaf);
                        break;
                    case 3:
                        Boat boat = new Boat();
                        LifeCycle.live(boat);
                        break;
                    case 4:
                        Block block = new Block();
                        LifeCycle.live(block);
                        break;
                    case 5:
                        Tub tub = new Tub();
                        LifeCycle.live(tub);
                        break;
                    case 6:
                        Blinker blink = new Blinker();
                        LifeCycle.live(blink);
                        break;
                    case 7:
                        Glider glider = new Glider();
                        LifeCycle.live(glider);
                        break;

                }
            }

        }
    }
}