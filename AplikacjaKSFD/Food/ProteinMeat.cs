using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Food
{
    static class ProteinMeat //tablica kalorii do przemnożenia ilości i itemów spożywczych danej kategorii 
    {
        static double[] ProteinArray = { 1.53, 5.406, 5.179, 1.93, 1.55, 1.585, 3.461, 2.689, 2.36, 2.01, 3.00, 2.59, 2.99, 1.14,
        1.21, 3.363, 1.59, 1.924, 0.98, 1.451, 2.421, 2.54, 1.771, 1.24, 1.649, 1.36, 2.77 };

        static int Index;
        static int ProductAmount;
        static public double Calculate(int index, int amount)

        {
            Index = index;
            ProductAmount = amount;

            return amount * ProteinArray[index];
        }
        public enum Products
        {
             [Description("Antrykot wołowy")]Meat1,
             [Description("Bekon")]Meat2,
             [Description("Boczek")]Meat3,
             [Description("Golonka wieprzowa")]Meat4,
             [Description("Jaja kurze")]Meat5,
             [Description("Jaja przepiórcze")]Meat6,
             [Description("Kiełbasa wieprzowa")]Meat7,
             [Description("Karkówka wieprzowa")]Meat8,
             [Description("Łopatka wieprzowa")]Meat9,
             [Description("Pasztet drobiowy")]Meat10,
             [Description("Pasztet zajęczy")]Meat11,
             [Description("Parówki drobiowe")]Meat12,
             [Description("Parówki wieprzowe")]Meat13,
             [Description("Pierś z indyka")]Meat14,
             [Description("Pierś z kurczaka")]Meat15,
             [Description("Salami")]Meat16,
             [Description("Salceson")]Meat17,
             [Description("Stek z łaty wołowej")]Meat18,
             [Description("Szynka drobiowa")]Meat19,
             [Description("Szynka wieprzowa")]Meat20,
             [Description("Schab wieprzowy")]Meat21,
             [Description("Skrzydełka z kurczaka")]Meat22,
             [Description("Udko kurczaka")]Meat23,
             [Description("Udziec wołowy")]Meat24,
             [Description("Wątróbka kurczaka")]Meat25,
             [Description("Wątróbka kacza")]Meat26,
             [Description("Żeberka wieprzowe")]Meat27,
        }
    }
}
