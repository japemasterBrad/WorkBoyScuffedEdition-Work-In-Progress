using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBoyScuffedEdition
{
    public class Temperature
    {
        public int tempCelcius;

        public void ConvertCtoF(int tempCelcius)
        {
            int tempFarenheit = tempCelcius * 9 / 5 + 32;

            Console.WriteLine("{0}F is equal to {1}C", tempCelcius, tempFarenheit);
            Console.ReadKey();
        }
    }
}
