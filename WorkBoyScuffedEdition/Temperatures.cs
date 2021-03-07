using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBoyScuffedEdition
{
    public class Temperatures
    {
        public float tempCelcius;
        public float tempFarenheit;

        public void ConvertCtoF(float tempCelcius)
        {
            float ConvertedCtoF = tempCelcius * 9 / 5 + 32;

            Console.WriteLine("{0}F is equal to {1}C", tempCelcius, ConvertedCtoF);
            //Console.ReadKey();
        }

        public void ConvertFtoC(float tempFarenheit)
        {
            float ConvertedFtoC = (tempFarenheit - 32) * 5/9;
           
            Console.WriteLine("{0}F is equal to {1}C", tempFarenheit, ConvertedFtoC);
            Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
            //Console.ReadKey();
        }
    }
}
