using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBoyScuffedEdition
{
    class Temperature
    {
        public int TempCelcius { get; set; }

        
        public Temperature(int tempCelcius)
        {
            TempCelcius = tempCelcius;
        }
        public static void ConvertTemp(int tempCelcius)
        {
            Console.WriteLine("What do you want to convert from F to C?");
            tempCelcius = Console.Read();

            Console.WriteLine("So you want to convert {0} from Celcius to Farenheit.\n\n", tempCelcius);
            Console.WriteLine("TEST FOR NEW LINE");

        }
        
    }
}
