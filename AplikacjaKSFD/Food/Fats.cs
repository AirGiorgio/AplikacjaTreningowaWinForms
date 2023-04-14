using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Food
{
    static class Fats //tablica kalorii do przemnożenia ilości i itemów spożywczych danej kategorii 
    {
        static double[] FatsArray = { 7.168, 7.168, 8.621, 9, 8.84, 8.84, 8.84, 8.84, 8.84, 8.84, 9.02 };
        static int Index;
        static int ProductAmount;
        static public double Calculate(int index, int amount)

        {
            Index = index;
            ProductAmount = amount;

            return amount * FatsArray[index];
        }
        public enum Products
        {
            [Description("Margaryna")] Fat1,
            [Description("Masło")] Fat2,
            [Description("Olej kokosowy")] Fat3,
            [Description("Olej kukurydziany")] Fat4,
            [Description("Olej migdałowy")] Fat5,
            [Description("Olej palmowy")] Fat6,
            [Description("Olej sojowy")] Fat7,
            [Description("Olej słonecznikowy")] Fat8,
            [Description("Olej rzepakowy")] Fat9,
            [Description("Oliwa z oliwek")] Fat10,
            [Description("Tran")] Fat11,
        }
    }
}
