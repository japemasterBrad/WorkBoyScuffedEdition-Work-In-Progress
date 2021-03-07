using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBoyScuffedEdition
{
    class Volumes
    {
        public void USGalToLiter(float inputUSGal)
        {
            float ConvertedUSGal = inputUSGal * 4.546f;

            if (inputUSGal == 1)
            {
                Console.WriteLine("{0} US Galon converts to {1}l",
                    inputUSGal, ConvertedUSGal);
            }
            else if (inputUSGal > 1)
            {
                Console.WriteLine("{0} US Gallons converts to {1}l",
                    inputUSGal, ConvertedUSGal);
                
            }
            Console.ReadKey();
        }

        public void LiterToUSGal(float inputLiter)
        {
            float ConvertedLiter = inputLiter / 4.546f;

            if (ConvertedLiter == 1)
            {
                Console.WriteLine("{0}l converts to {1} US Gallon",
                    inputLiter, ConvertedLiter);
            } else {
                Console.WriteLine("{0}l converts to {1} US Gallons",
                    inputLiter, ConvertedLiter);
            }
                Console.ReadKey();
        }

        public void QuartToLiter(float inputQuart)
        {
            float convertedQuart = inputQuart * 1.137f;

            Console.WriteLine("{0} Quart converts to {1}l",
                inputQuart, convertedQuart);
        }

        public void LiterToQuart(float inputLiter)
        {
            float ConvertedQuart = inputLiter / 1.137f;

            Console.WriteLine("{0} Quart converts to {1}l",
                inputLiter, ConvertedQuart);
        }

    }
}
