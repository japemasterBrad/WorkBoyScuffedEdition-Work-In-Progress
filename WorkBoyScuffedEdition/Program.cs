using System;

namespace WorkBoyScuffedEdition
{
    class Program
    {

        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            temperature.tempCelcius = 24;

            Console.WriteLine(temperature);
        }
    }
}
