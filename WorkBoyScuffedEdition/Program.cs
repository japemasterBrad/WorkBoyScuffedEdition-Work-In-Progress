﻿using System;

namespace WorkBoyScuffedEdition
{
    class Program
    {
        public static Temperatures temperature = new Temperatures();
        public static Distances dist = new Distances();
        public static Convertor convert = new Convertor();

        public static bool running = true;
        public static string workboyFunctionSelector;
        public static string workboyRunAgain;

        public static string temperatureRunAgain;
        public static string volumesRunAgain;

        static void Main(string[] args)
        {
            OpeningArt();
            FunctionSelector();
        }

        # region FUNCTION SELECTOR.

        public static void FunctionSelector()
        {
            //Console.WriteLine("What do you want to do?\n" +
            //    "1) Tempertaure\n" +
            //    "2) Distances\n");

            Console.WriteLine("What do you want to do?\n" +
                "1) Convert\n" +
                "");

            workboyFunctionSelector = Console.ReadLine();
            Console.Clear();

            if (workboyFunctionSelector.Equals("1"))
            {
                Console.WriteLine("What do you want to conver?\n" +
                    "1) Tempertaure\n" +
                    "2) Distance\n" +
                    "3) Weight\n" +
                    "4) Volumes\n" +
                    "5) Timezones (Coming soon)\n");

                string convertPicker = Console.ReadLine();

                Console.Clear();

                if (convertPicker.Equals("1"))
                {
                    TemperatureConverter();
                }
                else if (workboyFunctionSelector.Equals("2"))
                {
                    DistanceConvertor();
                }
                else if (workboyFunctionSelector.Equals("3"))
                {

                }
                else if (workboyFunctionSelector.Equals("4"))
                {

                }
                else if (workboyFunctionSelector.Equals("5"))
                {

                }
                    
            }
        }

        #endregion

        #region RunAgain (MAYBE CAN LOSE, OR REFACTOR INTO WHOLE PROGRAM OR OTHERWISE)

        public static void RunAgain()
        {
            Console.WriteLine("Do you want to do anythig else? (y/n)");
            workboyRunAgain = Console.ReadLine();

            if (workboyFunctionSelector.Equals("y")) running = true;
            else if (workboyFunctionSelector.Equals("n")) running = false;
        }
        #endregion

        public static void TemperatureConverter()
        {
            do
            {
                Console.WriteLine("Do you want to convert from Celcius to Farenheit," +
                    " or Farenheit to Celcius?\n" +
                    "1) C to F\n" +
                    "2) F to C");

                string tempConversionPicker = Console.ReadLine();

                if (tempConversionPicker.Equals("1"))
                {
                    Console.WriteLine("What Celcius temperature do you want to convert to Farenheit?");
                    string celciusReading = Console.ReadLine();

                    float ParsedCelciusReading = float.Parse(celciusReading);

                    temperature.ConvertCtoF(ParsedCelciusReading);
                }
                else if (tempConversionPicker.Equals("2"))
                {
                    Console.WriteLine("What Farenheit temperature do you want to convert to Celcius?");
                    string farenheitReading = Console.ReadLine();

                    float ParsedFarenheitReading = float.Parse(farenheitReading);

                    temperature.ConvertFtoC(ParsedFarenheitReading);
                }

                RunTempAgain();

                void RunTempAgain()
                {
                    Console.WriteLine("Convert another temperature? (Y/N)");
                    temperatureRunAgain = Console.ReadLine();

                    if (temperatureRunAgain.Equals("n"))
                    {
                        Console.WriteLine("\n\n\n");
                        FunctionSelector();
                    }
                }

            } while (temperatureRunAgain.Equals(true));
        }

        #region Volumes

        public static void DistanceConvertor()
        {
            do
            {
                Console.WriteLine("What distances would you like to convert?\n" +
                    "1) Inches to CM\n" +
                    "2) CM to Inches\n" +
                    "");
                string distancePicker = Console.ReadLine();

                if (distancePicker.Equals("1"))
                {
                    Console.WriteLine("How many inches would you like to convert to CM?");
                    float inchesToConvert = Console.Read();
                    Console.WriteLine("inches to convert: {0}", inchesToConvert);
                    dist.InchToCM(inchesToConvert);
                }




            } while (volumesRunAgain.Equals(true));
        }

        public static void VolumeConvertor()
        {

        }
        #endregion





        #region OPENING ART
        public static void OpeningArt()
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("WORK BOY *SCUFFED EDITION*");
            Console.WriteLine("**********************************************************");
        }

        /*
         
         
         
         
         
         */

        #endregion
    }
}