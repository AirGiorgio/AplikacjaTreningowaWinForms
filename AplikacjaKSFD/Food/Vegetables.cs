using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Food
{
    static class Vegetables //tablica kalorii do przemnożenia ilości i itemów spożywczych danej kategorii 
    {
        static double[] VegeArray = { 0.249, 0.22, 0.35, 0.375, 0.428, 0.43, 0.397, 0.167, 0.150, 0.261, 0.313, 0.81,
        0.222, 0.495, 0.249, 0.270, 0.246, 0.186, 0.471, 1.22, 0.413, 0.155, 0.0105, 0.32, 0.361, 0.19, 0.609, 0.251, 0.28, 0.158,
        0.148, 0.16, 0.301, 0.23, 1.09, 0.767};

        static int Index;
        static int ProductAmount;
        static public double Calculate(int index, int amount)

        {
            Index = index;
            ProductAmount = amount;

            return amount * VegeArray[index];
        }

        public enum Products
        {
            [Description("Bakłażan")]Vege1,
            [Description("Botwina")]Vege2,
            [Description("Brokuł")]Vege3,
            [Description("Brukiew")]Vege4,
            [Description("Brukselka")]Vege5,
            [Description("Burak")]Vege6,
            [Description("Cebula")]Vege7,
            [Description("Cukinia")]Vege8,
            [Description("Czosnek")]Vege9,
            [Description("Dynia")]Vege10,
            [Description("Fasolka zielona")]Vege11,
            [Description("Groszek")]Vege12,
            [Description("Grzyby")]Vege13,
            [Description("Jarmuż")]Vege14,
            [Description("Kalafior")]Vege15,
            [Description("Kalarepa")]Vege16,
            [Description("Kapusta")]Vege17,
            [Description("Kapusta kiszona")]Vege18,
            [Description("Karczoch")]Vege19,
            [Description("Kukurydza")]Vege20,
            [Description("Marchew")]Vege21,
            [Description("Ogórek zielony")]Vege22,
            [Description("Ogórek kiszony")]Vege23,
            [Description("Papryka")]Vege24,
            [Description("Pietruszka")]Vege25,
            [Description("Pomidor")]Vege26,
            [Description("Por")]Vege27,
            [Description("Rukola")]Vege28,
            [Description("Rzepa")]Vege29,
            [Description("Rzodkiewka")]Vege30,
            [Description("Sałata")]Vege31,
            [Description("Seler")]Vege32,
            [Description("Szczypiorek")]Vege33,
            [Description("Szpinak")]Vege34,
            [Description("Wasabi")]Vege35,
            [Description("Ziemniak")]Vege36,
        }
    }
}
