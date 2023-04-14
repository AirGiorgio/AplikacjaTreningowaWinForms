using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Food
{
    static class Fruits //tablica kalorii do przemnożenia ilości i itemów spożywczych danej kategorii 
    {
       static double[] FruitsArray = { 0.44, 0.5, 0.304, 1.601, 0.887, 0.394, 0.289, 0.5, 2.815, 0.74, 0.827, 0.571, 0.521,
        0.574, 0.433, 0.609, 0.473, 0.301, 0.526, 0.53, 0.598, 0.8, 0.48, 0.442, 1.15, 0.428, 0.569, 0.533, 0.325, 0.21, 2.99,
        0.325, 0.669, 0.5, 0.46, 3.08};

        static int Index;
        static int ProductAmount;
        static public double Calculate(int index, int amount)

        {
            Index = index;
            ProductAmount = amount;

            return amount * FruitsArray[index];
        }
        public enum Products
        {
            [Description("Agrest")] Fruit0,
            [Description("Ananas")] Fruit1,
            [Description("Arbuz")] Fruit2,
            [Description("Awokado")] Fruit3,
            [Description("Banan")] Fruit4,
            [Description("Brzoskwinia")] Fruit5,
            [Description("Cytryna")] Fruit6,
            [Description("Czereśnie")] Fruit7,
            [Description("Daktyle")] Fruit8,
            [Description("Figi")] Fruit9,
            [Description("Granat")] Fruit10,
            [Description("Gruszki")] Fruit11,
            [Description("Jabłka")] Fruit12,
            [Description("Jagody")] Fruit13,
            [Description("Jeżyna")] Fruit14,
            [Description("Kiwi")] Fruit15,
            [Description("Klementynki")] Fruit16,
            [Description("Limonki")] Fruit17,
            [Description("Maliny")] Fruit18,
            [Description("Mandarynki")] Fruit19,
            [Description("Mango")] Fruit20,
            [Description("Mirabelki")] Fruit21,
            [Description("Morele")] Fruit22,
            [Description("Nektarynki")] Fruit23,
            [Description("Oliwki")] Fruit24,
            [Description("Papaje")] Fruit25,
            [Description("Pigwy")] Fruit26,
            [Description("Pomarańcze")] Fruit27,
            [Description("Poziomki")] Fruit28,
            [Description("Rabarbar")] Fruit29,
            [Description("Rodzynki")] Fruit30,
            [Description("Truskawki")] Fruit31,
            [Description("Winogrona")] Fruit32,
            [Description("Wiśnie")] Fruit33,
            [Description("Śliwka")] Fruit34,
            [Description("Żurawina")] Fruit35,
        }
    }
}

