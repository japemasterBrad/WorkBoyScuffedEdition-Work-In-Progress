using System;

namespace WorkBoyScuffedEdition
{
    class Program
    {
        public static Temperatures temperature = new Temperatures();
        public static Distances dist = new Distances();
        public static Convertor convert = new Convertor();

        public static string currentConvertorType;

        public static bool running = true;
        public static string workboyFunctionSelector;
        public static string workboyRunAgain;

        public static string temperatureRunAgainInput;
        public static bool temperatureRunAgain = false;

        public static string distancesRunAgainInput;
        public static bool distancesRunAgain = false;

        static void Main(string[] args)
        {
            FunctionSelector();
        }

        public static void FunctionSelector()
        {
            OpeningArt();

            Console.WriteLine("What do you want to do?\n" +
                "1) Convert\n" +
                "");

            workboyFunctionSelector = Console.ReadLine();
            Console.Clear();

            if (workboyFunctionSelector.Equals("1"))
            {
                ConversionSelector();
            }
        }

        public static void ConversionSelector()
        {
            Console.WriteLine("What do you want to convert?\n" +
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
            else if (convertPicker.Equals("2"))
            {
                DistanceConvertor();
            }
            else if (convertPicker.Equals("3"))
            {

            }
            else if (convertPicker.Equals("4"))
            {

            }
            else if (convertPicker.Equals("5"))
            {

            }
        }

        public static void ConvertorRunAgain()
        {
            Console.WriteLine("Do you want to make another conversion?");
            workboyRunAgain = Console.ReadLine();

            if (workboyRunAgain.Equals("y") || workboyRunAgain.Equals("Y"))
            {
                Console.Clear();
                ConversionSelector();
            }
            else if (workboyRunAgain.Equals("n") || workboyRunAgain.Equals("N"))
            {
                Console.Clear();
                running = false;
                FunctionSelector();
            }
            else
            {
                Console.WriteLine("Didn't catch that, try again using either y or n!");
                ConvertorRunAgain();
            }
        }


        public static void TemperatureConverter()
        {
            do
            {
                currentConvertorType = "temperature";

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

                ConvertorRunAgain();

            } while (temperatureRunAgain.Equals(true));
        }

        public static void DistanceConvertor()
        {
            currentConvertorType = "distance";
            do
            {
                Console.WriteLine("What distances would you like to convert?\n" +
                    "1) Inches to CM\n" +
                    "2) CM to Inches\n" +
                    "3) KM to Miles\n" +
                    "4) Miles to KM\n");

                string distancePicker = Console.ReadLine();

                if (distancePicker.Equals("1"))
                {
                    Console.WriteLine("How many inches would you like to convert to CM?");

                    string inchesToConvert = Console.ReadLine();

                    float ParsedInchesReading = float.Parse(inchesToConvert);



                    Console.WriteLine("inches to convert: {0}", inchesToConvert);
                    dist.InchToCM(ParsedInchesReading);
                    Console.ReadKey();
                }
                else if (distancePicker.Equals("2"))
                {
                    Console.WriteLine("How many CM would you like to convert to inches?");

                    string cmToConvert = Console.ReadLine();

                    float ParsedCMReading = float.Parse(cmToConvert);

                    dist.CMToInch(ParsedCMReading);
                    Console.ReadKey();
                }
                else if (distancePicker.Equals("3"))
                {
                    Console.WriteLine("How many kilometers would you like to conver to miles?");
                    string kmToMiles = Console.ReadLine();

                    float parsedKmConvertor = float.Parse(kmToMiles);

                    dist.KMtoMiles(parsedKmConvertor);
                }
                else if (distancePicker.Equals("4"))
                {
                    Console.WriteLine("How many miles would you like to conver to kilometers?");
                    string milesToKM= Console.ReadLine();

                    float parsedMolesConvertor = float.Parse(milesToKM);

                    dist.MilesToKM(parsedMolesConvertor);
                }

                ConvertorRunAgain();

            } while (distancesRunAgain.Equals(true));
        }

        public static void VolumeConvertor()
        {

        }

        public static void OpeningArt()
        {
            Console.WriteLine("     ╔═╗     ╔═╗   ╔═══════╗  ╔═══════╗   ╔═╗  ╔══╗  ╔═══════╗  ╔═══════╗   ╔═╗ ╔═╗\n" +
                              "    ║ ║ ╔══╗ ║ ║  ║ ╔═══╗ ║  ║ ║  ║ ║    ║ ╚══╝ ╔╝  ║  ║ ║  ║  ║ ╔═══╗ ║   ║ ║ ║ ║\n" +
                              "   ║ ║ ║  ║ ║ ║  ║ ║   ║ ║  ║     ══╝╗  ║      ║   ║       ╗  ║ ║   ║ ║   ║ ╚═╝ ║\n" +
                              "  ║ ║ ║  ║ ║ ║  ║ ║   ║ ║  ║ ╔══╗   ║  ║ ╔══╗ ╚╗  ║  ║  ║ ║  ║ ║   ║ ║   ╚═╗  ╔═╝ \n" +
                              " ║ ╚═╝  ╚═╝ ║  ║ ╚═══╝ ║  ║ ║  ║   ║  ║ ║  ╚╗ ║  ║  ║  ║ ║  ║ ╚═══╝ ║     ║  ║     \n" +
                              "╚══════════╝  ╚═══════╝  ╚═╝  ╚═══╝  ╚═╝   ╚═╝  ╚═══════╝  ╚═══════╝    ╚═══╝  \n" +
                              "                                                          *SCUFFED EDITION*");


        }
    }
}