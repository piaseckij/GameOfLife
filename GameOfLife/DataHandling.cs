namespace GameOfLife
{
    static class DataHandling
    {
        
 

        public static (int,int) receiveTableSize()
        {
            int tableSizeX;
            int tableSizeY;

            Console.WriteLine("Podaj wysokosc planszy");
            bool success = int.TryParse(Console.ReadLine(), out tableSizeY);

            if (!success)
            {
                Console.WriteLine("\nBłąd we wprowadzaniu");
                return (0, 0);


            }
            
            Console.WriteLine("Podaj szerokosc planszy");
            success= int.TryParse(Console.ReadLine(),out tableSizeX);

            if (!success)
            {
                Console.WriteLine("\nBłąd we wprowadzaniu");
                return (0, 0);
            }
            return (tableSizeX, tableSizeY);

            


        }
    }
}
