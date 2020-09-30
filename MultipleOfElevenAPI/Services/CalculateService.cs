using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleOfElevenAPI.Services
{
    public class CalculateService
    {
        public static bool IsMultipleNumber(string number)
        {
            var numbersIndividual = number.ToCharArray();

            if (numbersIndividual.Count() == 2)
            {
                if (numbersIndividual[0] == numbersIndividual[1])
                    return true;

                int result = CalculateWithTwoNumbers(numbersIndividual);
                return (result % 11) == 0;
            }
            else
            {
                var result = CalculateWithMoreNumbers(numbersIndividual);
                return result % 11 == 0;

            }
        }

        private static int CalculateWithTwoNumbers(char[] numbersIndividual)
        {
            var numberConcatenated = string.Empty;
            for (int i = 0; i < numbersIndividual.Count(); i++)
            {
                numberConcatenated += int.Parse(numbersIndividual[i].ToString());
            }
            return int.Parse(numberConcatenated);
        }

        private static int CalculateWithMoreNumbers(char [] numbersIndividual)
        {
            var numberConcatenated = string.Empty;
            while (numbersIndividual.Count() != 2 && numbersIndividual.Count() != 1)
            {
                var lastnumber = numbersIndividual[numbersIndividual.Count() - 1];
                for (int i = 0; i < numbersIndividual.Count() - 1; i++)
                {
                    numberConcatenated += int.Parse(numbersIndividual[i].ToString());
                }

                var restNumbers = int.Parse(numberConcatenated);
                var lastone = int.Parse(lastnumber.ToString());
                numbersIndividual = (restNumbers - lastone).ToString().ToCharArray();
                numberConcatenated = string.Empty;
            }

            return numbersIndividual.Count() < 2 ? int.Parse($"{numbersIndividual[0].ToString()}") : int.Parse($"{numbersIndividual[0].ToString()}{numbersIndividual[1].ToString()}");
        }
    }
}