using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Food
{
    static class Dairy //tablica kalorii do przemnożenia ilości i itemów spożywczych danej kategorii 
    {
        static double[] DairyArray = { 0.69, 0.51, 0.404, 0.36, 0.62, 0.48, 0.54, 3.72, 2.626, 3.56, 3.64, 2.801, 3.53,
        3.47, 3.563, 3.47, 1.36, 2.151, 0.985, 1.955, 1, 1.34, 1.74 };

        static int Index;
        static int ProductAmount;
        static public double Calculate(int index, int amount)

        {
            Index = index;
            ProductAmount = amount;

            return amount * DairyArray[index];
        }
        public enum Products
        {
            [Description("Jogurt naturalny")] diary1,
            [Description("Kefir")] diary2,
            [Description("Maślanka")] diary3,
            [Description("Mleko chude")] diary4,
            [Description("Mleko pełne")] diary5,
            [Description("Mleko półtłuste")] diary6,
            [Description("Mleko sojowe")] diary7,
            [Description("Oscypek")] diary8,
            [Description("Ser feta")] diary9,
            [Description("Ser gorgonzola")] diary10,
            [Description("Ser kozi")] diary11,
            [Description("Ser mozarella")] diary12,
            [Description("Ser niebieski pleśniowy")] diary13,
            [Description("Ser żółty edamski")] diary14,
            [Description("Ser żółty gouda")] diary15,
            [Description("Ser żółty masdaam")] diary16,
            [Description("Serek homogenizowany")] diary17,
            [Description("Serek topiony")] diary18,
            [Description("Serek wiejski")] diary19,
            [Description("Śmietana")] diary20,
            [Description("Twaróg chudy")] diary21,
            [Description("Twaróg półtłusty")] diary22,
            [Description("Twaróg tłusty")] diary23,
        }

    }
}
