using System;

namespace WorkBoyScuffedEdition
{
    class Program
    {
        public static Temperatures temperature = new Temperatures();
        public static Distances dist = new Distances();
        public static Weights weight = new Weights();
        public static Volumes vol = new Volumes();

        public static string returnToHome;

        public static string currentConvertorType;

        public static bool running = true;
        public static string workboyFunctionSelector;
        public static string workboyRunAgain;
        public static string distancePicker;

        public static string temperatureRunAgainInput;
        public static bool temperatureRunAgain = false;

        public static string distancesRunAgainInput;
        public static bool distancesRunAgain = false;

        public static string weightsRunAgainInput;
        public static bool weightsRunAgain;

        public static string VolumeRunAgainInput;
        public static bool VolumeRunAgain;

        static void Main(string[] args)
        {
            FunctionSelector();

            

        }

        public static void AboutThisProgram()
        {
            Console.WriteLine("This program emulates the functionality of a WorkBoy from Fabtek, Inc.\n\n" +

                                "Originally conceptualised in Jan 1992, it was a project that never released due to\n" +
                                "price cuts considered for the GameBoy by Nintendo.\n\n" +
                                "I decided to make this project for two reasons\n" +
                                "\t1) I thought it was a neat idea for the GameBoy, which would have given it another\n" +
                                    "\t   edge aside from just, a gaming console\n" +
                                "\t2) I wanted to get some more practice with programming.I've been learning C# and\n" +
                                "\t   thought this would be a good thing to get some experience with.\n\n" +
                                "Thank you for downloading this project!  I hope it's charming enough to brighten your day!\n\n" +
                                "As I get better with programming, I hope to add more functionality to it, and flesh it out\n" +
                                "good and proper.\n\n" +
                                "Stay cheeky, keep smiling <3\n\n" +
                                "- Bradley Thomas, London UK, Mar 2021\n\n");
            Console.WriteLine("HIT SPACE AND ENTER TO CONTINUE");
            string headHome = Console.ReadLine();

            if (headHome.Equals(" ")) FunctionSelector();
        }


        public static void Author()
        {
            Console.WriteLine("\n\n\n\n\n\n\n(c) 2021 Bradley Stuart Thomas\n" +
                              "Original Concept by Fabtek, Inc");
        }

        public static void FunctionSelector()
        {
            OpeningArt();

            Console.WriteLine("|--------------------------|\n" +
                              "|  What do you want to do? |\n" +
                              "|--------------------------|\n" +
                              "|1) Convert                |\n" +
                              "|--------------------------|\n" +
                              "|2) TBC                    |\n" +
                              "|--------------------------|\n" +
                              "|3) (COMING SOON)          |\n" +
                              "| -------------------------|\n" +
                              "|4) (About This Program    |\n" + 
                              "|--------------------------|\n" +
                              "\n\n\nPress Enter to Close");
            Author();
            Console.WriteLine("------------------------------------------------");
            Console.Write("> ");
            workboyFunctionSelector = Console.ReadLine();

            Console.Clear();


            if (workboyFunctionSelector.Equals("1"))
            {
                ConversionSelector();
            }
            else if (workboyFunctionSelector.Equals("2"))
            {
                FunctionSelector();
            }
            else if (workboyFunctionSelector.Equals("3"))
            {
                Console.WriteLine("-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-");
                Console.WriteLine("This list is still being built, come back later and there might be something else here!");
                Console.WriteLine("\nPRESS SPACE AND ENTER TO PROGRESS TO HOME SCREEN");
                Console.WriteLine("-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-");
                returnToHome = Console.ReadLine();
                programEndSaver();
            }
            else if (workboyFunctionSelector.Equals("4"))
            {
                AboutThisProgram();
            }
            
        }

        public static void programEndSaver()
        {
            if (returnToHome.Equals(" "))
            {
                FunctionSelector();
            }
            else
            {
                Console.WriteLine("Closing program now.\nPlease hit Enter.");
                Console.ReadKey();
            }
        }

        #region -----------------CONVERTOR CODE (LEADS TO CLASSES ---------------------------
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
                WeightConvertor();
            }
            else if (convertPicker.Equals("4"))
            {
                VolumeConvertor();
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
                    "4) Miles to KM\n" +
                    "5) Ft to Meter\n" +
                    "6) Meter to Ft\n");

                distancePicker = Console.ReadLine();

                if (distancePicker.Equals("1"))
                {
                    Console.WriteLine("How many inches would you like to convert to CM?");

                    string inchesToConvert = Console.ReadLine();

                    float ParsedInchesReading = float.Parse(inchesToConvert);

                    Console.WriteLine("inches to convert: {0}", inchesToConvert);
                    dist.InchToCM(ParsedInchesReading);
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
                    string milesToKM = Console.ReadLine();

                    float parsedMolesConvertor = float.Parse(milesToKM);

                    dist.MilesToKM(parsedMolesConvertor);
                }
                else if (distancePicker.Equals("5"))
                {
                    Console.WriteLine("How many Feet would you like to conver to Meters?");
                    string ftToMeter = Console.ReadLine();

                    float parsedFeetConvertor = float.Parse(ftToMeter);

                    dist.FeetToMeter(parsedFeetConvertor);
                }
                else if (distancePicker.Equals("6"))
                {
                    Console.WriteLine("How many Meters would you like to conver to Feet?");
                    string MeterToFeet = Console.ReadLine();

                    float parsedMeterConvertor = float.Parse(MeterToFeet);

                    dist.FeetToMeter(parsedMeterConvertor);
                }
                ConvertorRunAgain();

            } while (distancesRunAgain.Equals(true));
        }

        public static void WeightConvertor()
        {
            do
            {
                currentConvertorType = "weight";

                Console.WriteLine("What weights would you like to convert?\n" +
                    "1) Lbs to Kilograms\n" +
                    "2) Kg to Lbs\n" +
                    "3) US Ton to Tonne\n" +
                    "4) Tonne to US Ton\n" +
                    "5) Oz to Gram\n" +
                    "6) Gram to Oz\n");
                string weightPicker = Console.ReadLine();

                if (weightPicker.Equals("1"))
                {
                    Console.WriteLine("How many Lbs would you like to convert to kg?");

                    string lbsToKg = Console.ReadLine();

                    float ParsedLbsReading = float.Parse(lbsToKg);
                    weight.LbsToKg(ParsedLbsReading);
                }
                else if (weightPicker.Equals("2"))
                {
                    Console.WriteLine("How many kg would you like to convert to lbs?");

                    string kgToLbs = Console.ReadLine();

                    float ParsedKgReading = float.Parse(kgToLbs);
                    weight.KgToLbs(ParsedKgReading);
                }
                else if (weightPicker.Equals("3"))
                {
                    Console.WriteLine("How many US Ton would you like to convert to Tonnes?");

                    string TonToTonne = Console.ReadLine();

                    float ParsedTonReading = float.Parse(TonToTonne);
                    weight.TonToTonne(ParsedTonReading);
                }
                else if (weightPicker.Equals("4"))
                {
                    Console.WriteLine("How many Tonne would you like to convert to US Ton?");

                    string TonneToTon = Console.ReadLine();

                    float ParsedTonneReading = float.Parse(TonneToTon);
                    Console.WriteLine("parsed tonne reading: {0}", ParsedTonneReading);
                    weight.TonToTonne(ParsedTonneReading);
                }
                else if (weightPicker.Equals("5"))
                {
                    Console.WriteLine("How many Ounce would you like to convert to Grams?");

                    string OzToGrams = Console.ReadLine();

                    float ParsedOzReading = float.Parse(OzToGrams);
                    weight.OzToGram(ParsedOzReading);
                }
                else if (weightPicker.Equals("6"))
                {
                    Console.WriteLine("How many Grams would you like to convert to Ounce?");

                    string GramsToOz = Console.ReadLine();

                    float ParsedGramReading = float.Parse(GramsToOz);
                    weight.GramToOz(ParsedGramReading);
                }
                ConvertorRunAgain();
            } while (weightsRunAgain.Equals(true));
        }

        public static void VolumeConvertor()
        {
            do
            {
                currentConvertorType = "weight";

                Console.WriteLine("What volumes would you like to convert?\n" +
                    "1) US Gallon to Liter\n" +
                    "2) Liter to US Gallon\n" +
                    "3) Quarts to Liters\n" +
                    "4) Liters to Quarts\n");

                string volumePicker = Console.ReadLine();

                if (volumePicker.Equals("1"))
                {
                    Console.WriteLine("How many US Gallons would you like to convert to Liters?");

                    string USGalToL = Console.ReadLine();

                    float ParsedUSGalReading = float.Parse(USGalToL);
                    vol.USGalToLiter(ParsedUSGalReading);
                }
                else if (volumePicker.Equals("2"))
                {
                    Console.WriteLine("How many liters would you like to convert to US Gallons?");

                    string LtoUSGAL = Console.ReadLine();

                    float ParsedLReading = float.Parse(LtoUSGAL);
                    vol.LiterToUSGal(ParsedLReading);
                }
                else if (volumePicker.Equals("3"))
                {
                    Console.WriteLine("How many Quarts would you like to convert to Liters?");

                    string QuartsToLiter = Console.ReadLine();

                    float ParsedQuartsReading = float.Parse(QuartsToLiter);
                    vol.QuartToLiter(ParsedQuartsReading);
                }
                else if (volumePicker.Equals("4"))
                {
                    Console.WriteLine("How many liters would you like to convert to US Gallons?");

                    string LiterToQuarts = Console.ReadLine();

                    float ParsedLReading2 = float.Parse(LiterToQuarts);
                    vol.LiterToQuart(ParsedLReading2);
                }

                ConvertorRunAgain();

            } while (VolumeRunAgain.Equals(true));

        }
        #endregion
        
        
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
