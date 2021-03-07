using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBoyScuffedEdition
{
    class Distances
    {

        #region CM and Inch
        public void InchToCM(float inputInches)
        {
            // multiply inch by 2.54

            float inchConvertor = inputInches * 2.54f;

            if (inputInches == 1)
            {
                Console.WriteLine("{0} inch converts  to {1} cm.",
                    inputInches, inchConvertor);
            }
            else if (inputInches > 1)
            {
                Console.WriteLine("{0} inches convert to {1} cm.",
                    inputInches, inchConvertor);
            }
        }

        public void CMToInch(float inputCM)
        {
            float cmConvertor = inputCM / 2.54f;

            if (cmConvertor == 1)
            {
                Console.WriteLine("{0} cm converts to {1} inch.",
                    inputCM, cmConvertor);
            }
            else if (cmConvertor > 1)
            {
                Console.WriteLine("{0} cm convert to {1} inches.",
                    inputCM, cmConvertor);
            }
        }
        #endregion

        #region km and miles
        public void KMtoMiles(float inputKM)
        {
            float kmConvertor = inputKM / 1.609f;

            if (inputKM == 1)
            {
                Console.WriteLine("{0} km approximately converts to {1} mile",
                inputKM, kmConvertor);
            }
            else if (inputKM > 1 || inputKM < 1)
            {
                Console.WriteLine("{0} km approximately converts to {1} miles",
                inputKM, kmConvertor);
            }

            Console.WriteLine("\n");
        }

        public void MilesToKM(float inputMiles)
        {
            float milesConvertor = inputMiles * 1.609f;

            if (inputMiles == 1)
            {
                Console.WriteLine("{0} mile approximately converts to {1} km",
                    inputMiles, milesConvertor);

            }
            else if (inputMiles > 1)
            {
                Console.WriteLine("{0} miles approximately converts to {1} km",
                    inputMiles, milesConvertor);
            }

            Console.WriteLine("\n");
        }
            #endregion

        public void FeetToMeter(float inputFeet)
        {
            float feetConvertor = inputFeet / 3.281f;

            Console.WriteLine("{0} ft converts to {1}m",
                inputFeet, feetConvertor);
        }

        public void MeterToFeet(float inputMeter)
        {
            float meterConvertor = inputMeter * 3.281f;

            Console.WriteLine("{0}m converts to {1} ft", 
                inputMeter, meterConvertor);
        }
    }
}