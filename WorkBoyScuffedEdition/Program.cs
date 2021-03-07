using System;

namespace WorkBoyScuffedEdition
{
    class Program
    {
        public static Temperature temperature = new Temperature();
        public static bool running = true;
        public static string workboyFunctionSelector;
        public static string workboyRunAgain;

        public static string temperaturerunAgain;

        static void Main(string[] args)
        {
            FunctionSelector();
        }

        # region FUNCTION SELECTOR.

        public static void FunctionSelector()
        {
            Console.WriteLine("What do you want to do?\n" +
                "1) Tempertaure");
            workboyFunctionSelector = Console.ReadLine();

            do
            {
                if (workboyFunctionSelector.Equals("1"))
                {
                    TemperatureConverter();
                }

                RunAgain();

            } while (running);

            if (workboyFunctionSelector.Equals("1"))
            {
                TemperatureConverter();
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

        #region TEMPERATURE CONVERT
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
                    temperaturerunAgain = Console.ReadLine();

                    if (temperaturerunAgain.Equals("n"))
                    {
                        Console.WriteLine("\n\n\n");
                        FunctionSelector();
                    }
                }

            } while (temperaturerunAgain.Equals(true));
        }
        #endregion
    }
}