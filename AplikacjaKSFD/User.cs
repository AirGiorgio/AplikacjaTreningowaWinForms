using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD
{
    public static class User //klasa statyczna z wzorami do obliczania zapotrzebowania kalorycznego
    {
        public static int Kcal = 0;
        public static int weight { get; set; }
        public static int height { get; set; }
        public static int age { get; set; }

        public static int gender { get; set; }

        public static int activity { get; set; }

        public static int goal { get; set; }

        public static int Calculate()
        {
            double result;

            if (gender == 0)
            {
                result = CalculateMale();
            }
            else
            {
                result = CalculateFemale();
            }

            if (activity == 0)
            {
                result *= 1.1;
            }
            else if (activity == 1)
            {
                result *= 1.2;
            }
            else if (activity == 2)
            {
                result *= 1.3;
            }
            else if (activity == 3)
            {
                result *=  1.4;
            }
            else if (activity == 4)
            {
                result *= 1.5;
            }

            if (goal == 0)
            {
                result -= 250;
            }
            else if (goal == 1)
            {

            }
            else if (goal == 2)
            {
                result += 250;
            }
          
            return Convert.ToInt32(result);
        }

        private static double CalculateMale()
        {
            return ((13.7 * weight) + (5 * height) + (6.8 * age) +66);
        }

        private static double CalculateFemale()
        {
            return ((9.6 * weight) + (1.8 * height) + (4.7 * age) + 655);
        }
    }
}
