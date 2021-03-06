using System;

namespace WorkBoyScuffedEdition
{
    class Program
    {
        public static Temperature temperature = new Temperature();

        static void Main(string[] args)
        {
            bool running = true;

            do
            {
                Console.WriteLine("What do you want to convert from C to F?");
                string CelciusReading = Console.ReadLine();

                int ParsedCelciusReading = Convert.ToInt32(CelciusReading);

                temperature.ConvertCtoF(ParsedCelciusReading);
                Console.WriteLine("Convert another temperature? (Y/N)");
                string runAgain = Console.ReadLine();

                if (runAgain.Equals("Y") || runAgain.Equals("y")) running = true;
                else running = false;

            } while (running == true);
        }
    }
}
