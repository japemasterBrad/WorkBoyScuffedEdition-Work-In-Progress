using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBoyScuffedEdition
{
    public class Temperature
    {
        public int tempCelcius;
        public int tempFarenheit;

        public static void ConvertTemp(int tempCelcius, int tempFarenheit)
        {
            Console.WriteLine("What do you want to convert from F to C?");
            tempCelcius = Console.Read();

            Console.WriteLine("So you want to convert {0} from Celcius to Farenheit.\n\n", tempCelcius);
            Console.WriteLine("TEST FOR NEW LINE");

            tempFarenheit = tempCelcius * (9 / 5) + 32;

            Console.WriteLine("{0} converted to Farenheit is {1}", tempCelcius, tempFarenheit);
        }
        
    }
}
