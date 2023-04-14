using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Food
{
    static class Supplements //tablica kalorii do przemnożenia ilości i itemów spożywczych danej kategorii 
    {
        static double[] SuppArray = { 4.2, 3.8, 3.7, 4.0, 4.1, 3.9, 3.7, 4.1, 4.4, 4.0, 3.9, 4.3, 2.4,
        2.1, 2.1, 2.3, 2.3, 2.0 , 2.0, 2.1, 2.3, 2.2, 2.2, 2.3, 2.3, 2.0, 2.1, 2.2, 2.8, 2.7, 2.6,
        2.7, 3.0, 2.8, 2.9, 2.9, 3.1, 3.0 , 2.9, 3.1};
     
        static int Index;
        static int ProductAmount;
        static public double Calculate(int index, int amount)

        {
            Index = index;
            ProductAmount = amount;

            return amount * SuppArray[index];
        }
        public enum Products
        {
            [Description("Gainer Mass Up Extreme Czekoladowy")] Gainer1,
            [Description("Gainer Mass Up Extreme Bananowy")] Gainer2,
            [Description("Gainer Mass Up Extreme Waniliowy")] Gainer3,
            [Description("Gainer Mass Up Extreme Truskawkowy")] Gainer4,
            [Description("Gainer True Gain Czekoladowy")] Gainer5,
            [Description("Gainer True Gain Bananowy")] Gainer6,
            [Description("Gainer True Gain Waniliowy")] Gainer7,
            [Description("Gainer True Gain Truskawkowy")] Gainer8,
            [Description("Gainer XXL MASS Czekoladowy")] Gainer9,
            [Description("Gainer XXL MASS Bananowy")] Gainer10,
            [Description("Gainer XXL MASS Waniliowy")] Gainer11,
            [Description("Gainer XXL MASS Truskawkowy")] Gainer12,
            [Description("Węglowodany Carbo Plus Czekoladowy")] Gainer13,
            [Description("Węglowodany Carbo Plus Bananowy")] Gainer14,
            [Description("Węglowodany Carbo Plus Waniliowy")] Gainer15,
            [Description("Węglowodany Carbo Plus Truskawkowy")] Gainer16,
            [Description("Węglowodany Carbomax Czekoladowy")] Gainer17,
            [Description("Węglowodany Carbomax Bananowy")] Gainer18,
            [Description("Węglowodany Carbomax Waniliowy")] Gainer19,
            [Description("Węglowodany Carbomax Truskawkowy")] Gainer20,
            [Description("Węglowodany Glikotor Czekoladowy")] Gainer21,
            [Description("Węglowodany Glikotor Bananowy")] Gainer22,
            [Description("Węglowodany Glikotor Waniliowy")] Gainer23,
            [Description("Węglowodany Glikotor Truskawkowy")] Gainer24,
            [Description("Węglowodany Isoactive Pro Czekoladowy")] Gainer25,
            [Description("Węglowodany Isoactive Pro Bananowy")] Gainer26,
            [Description("Węglowodany Isoactive Pro Waniliowy")] Gainer27,
            [Description("Węglowodany Isoactive Pro Truskawkowy")] Gainer28,
            [Description("Białko Hydro Whey Isolate Czekoladowy")] Gainer29,
            [Description("Białko Hydro Whey Isolate  Bananowy")] Gainer30,
            [Description("Białko Hydro Whey Isolate Waniliowy")] Gainer31,
            [Description("Białko Hydro Whey Isolate Truskawkowy")] Gainer32,
            [Description("Białko Isolate Pro Czekoladowy")] Gainer33,
            [Description("Białko Isolate Pro Bananowy")] Gainer34,
            [Description("Białko Isolate Pro Waniliowy")] Gainer35,
            [Description("Białko Isolate Pro Truskawkowy")] Gainer36,
            [Description("Białko WPC 80 Whey Czekoladowy")] Gainer37,
            [Description("Białko WPC 80 Whey Bananowy")] Gainer38,
            [Description("Białko WPC 80 Whey Waniliowy")] Gainer39,
            [Description("Białko WPC 80 Whey Truskawkowy")] Gainer40,
        }

    }
}
