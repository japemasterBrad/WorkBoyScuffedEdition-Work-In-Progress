using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBoyScuffedEdition
{
    class Weights
    {
        public void LbsToKg(float inputLbs)
        {
            float lbsConverted = inputLbs / 2.205f;

            Console.WriteLine("{0}lbs converts to {1}kg",
                inputLbs, lbsConverted);
        }

        public void KgToLbs(float inputKg)
        {
            float kgConverted = inputKg * 2.205f;

            Console.WriteLine("{0}kg converts to {1}lbs",
                inputKg, kgConverted);
        }

        public void TonToTonne(float inputTon)
        {
            float TonConverted = inputTon / 1.102f;

            Console.WriteLine("{0} Ton converts to {1} Tonne",
                inputTon, TonConverted);
        }

        public void TonneToTon(float inputTonne)
        {
            float TonneConverted = inputTonne * 1.102f;

            Console.WriteLine("{0} Tonne converts to {1} Ton",
                inputTonne, TonneConverted);
        }

        public void OzToGram(float inputOz)
        {
            float convertedOz = inputOz * 28.35f;

            Console.WriteLine("{0}oz converts to {1}g",
                inputOz, convertedOz);
        }

        public void GramToOz(float inputGram)
        {
            float convertedGram = inputGram / 28.35f;

            Console.WriteLine("{0}g converts to {1}oz",
                inputGram, convertedGram);
        }
    }
}
