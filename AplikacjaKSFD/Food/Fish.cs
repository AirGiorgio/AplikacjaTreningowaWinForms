using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Food
{
    static class Fish //tablica kalorii do przemnożenia ilości i itemów spożywczych danej kategorii 
    {
        static double[] FishArray = { 0.82, 0.83, 0.91, 0.77, 1.05, 1.27, 2.641, 0.61, 1.81, 2.619, 0.86, 0.74, 0.89,
         0.91, 1.64, 1.408,  0.77,  0.93,  1.69, 1.6, 1.319, 2.81};


        static int Index;
        static int ProductAmount;
        static public double Calculate(int index, int amount)

        {
            Index = index;
            ProductAmount = amount;

            return amount * FishArray[index];
        }
        public enum Products
        {
             [Description("Dorsz")]Fish1,
             [Description("Flądra")]Fish2,
             [Description("Halibut")]Fish3,
             [Description("Homar")]Fish4,
             [Description("Jesiotr")]Fish5,
             [Description("Karp")]Fish6,
             [Description("Kawior")]Fish7,
             [Description("Leszcz")]Fish8,
             [Description("Łosoś")]Fish9,
             [Description("Makrela")]Fish10,
             [Description("Małż")]Fish11,
             [Description("Miruna")]Fish12,
             [Description("Morszczuk")]Fish13,
             [Description("Okoń morski")]Fish14,
             [Description("Ośmiornica")]Fish15,
             [Description("Pstrąg")]Fish16,
             [Description("Rak")]Fish17,
             [Description("Sandacz")]Fish18,
             [Description("Sardynki")]Fish19,
             [Description("Śledź")]Fish20,
             [Description("Tuńczyk")]Fish21,
             [Description("Węgorz")]Fish22,
        }
    }
}
