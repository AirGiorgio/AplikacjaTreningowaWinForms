using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Food
{
    public static class Cereals //tablica kalorii do przemnożenia ilości i itemów spożywczych danej kategorii 
    {
        static private double[] CerealArray = { 3.46, 3.781, 3.5, 3.599, 5.844, 5.53, 3.64, 5.72, 6.283, 6.544, 5.674, 2.459, 2.161,
        2.81, 4.46, 3.66, 3.61, 3.5, 3.54, 3.571, 3.52, 5.339 };

        static int Index;
        static int ProductAmount;
        static public double Calculate(int index, int amount)

        {
            Index = index;
            ProductAmount = amount;

            return amount * CerealArray[index];
        }

        public enum Products
        {
             [Description("Kasza gryczana")] Cereal1,
             [Description("Kasza jaglana")] Cereal2,
             [Description("Kasza jęczmienna")] Cereal3,
             [Description("Kasza manna")] Cereal4,
             [Description("Nasiona słonecznika")] Cereal5,
             [Description("Nerkowiec")] Cereal6,
             [Description("Makaron")] Cereal7,
             [Description("Migdały")] Cereal8,
             [Description("Orzechy laskowe")] Cereal9,
             [Description("Orzechy włoskie")] Cereal10,
             [Description("Orzeszki ziemne")] Cereal11,
             [Description("Otręby owsiane")] Cereal12,
             [Description("Otręby pszenne")] Cereal13,
             [Description("Otręby żytnie")] Cereal14,
             [Description("Pestki dyni")] Cereal15,
             [Description("Płatki owsiane")] Cereal16,
             [Description("Płatki jaglane")] Cereal17,
             [Description("Ryż biały")] Cereal18,
             [Description("Ryż brązowy")] Cereal19,
             [Description("Ryż dziki")] Cereal20,
             [Description("Ryż parboiled")] Cereal21,
             [Description("Siemię lniane")] Cereal22,
        }
    }
}
