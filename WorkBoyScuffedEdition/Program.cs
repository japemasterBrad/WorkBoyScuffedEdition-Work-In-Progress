using System;

namespace WorkBoyScuffedEdition
{
    class Program
    {
        Temperature temperature = new Temperature();

        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to convert from C to F?");
            int CelciusReading = Console.Read();

            Console.WriteLine(CelciusReading);
            
            //temperature.ConvertCtoF(CelciusReading);
        }
    }
}
