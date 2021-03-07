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

            if (ConvertedUSGal == 1)
            {
                Console.WriteLine("{0}US Galon converts to {1}l",
                    inputUSGal, ConvertedUSGal);
            }
            else if (ConvertedUSGal > 1)
            {
                Console.WriteLine("{0}US Gallons converts to {1}l",
                    inputUSGal, ConvertedUSGal);
            }
        }

        public void LiterToUSGal(float inputLiter)
        {
            float ConvertedLiter = inputLiter / 4.546f;

            if (ConvertedLiter == 1)
            {
                Console.WriteLine("{0}l converts to {1} US Gallon",
                    inputLiter, ConvertedLiter);
            } else if (ConvertedLiter > 1){
                Console.WriteLine("{0}l converts to {1} US Gallons",
                    inputLiter, ConvertedLiter);
            }
        }

    }
}
