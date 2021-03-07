using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBoyScuffedEdition
{
    class Distances
    {
        public double inches;
        public double cm;

        public void InchToCM(double inputInches)
        {
            // multiply inch by 2.54

            double inchConvertor = inputInches * 2.54;
            Console.WriteLine("{0} inches convert to {1}cm.", 
                inputInches, inchConvertor);
        }

        public void CMToInch(int inputCM)
        {

        }
    }
}
