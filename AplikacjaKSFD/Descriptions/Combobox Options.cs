using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Descriptions
{
    static class ComboboxOptions
    {
        static List<string> list = new List<string>();

        public static BindingSource comboboxData(int index) //itemy comboboxów w zależności od rodzaju ćwiczenia w innym comboboxie w klasie FrTraining
        {
            var binding = new BindingSource();
            list.Clear();
            if (index == 0)
            {
                string c = "Unoszenie sztangi do klatki piersiowej,Wyciskanie żołnierskie hantlami siedząc,Wyciskanie żołnierskie sztangą stojąc,Wznosy hantli bokiem,Wznosy hantli przodem,Wznosy hantli tyłem leżąc,Wznosy hantli tyłem w opadzie tułowia";
                list = c.Split(',').ToList();
            }
            else if (index == 1)
            {
                string c = "Uginanie ramion na modlitewniku,Pompki na poręczach,Uginanie nadgarstka,Uginanie ramion chwytem młotkowym,Uginanie ramion z hantlem,Uginanie ramion ze sztangą,Uginanie ramion na wyciągu dolnym,Wiszenie na drążku,Wyciskanie francuskie hantli,Wyciskanie francuskie sztangi,Wyprosty ramion na wyciągu dolnym,Wyprosty ramion na wyciągu górnym,Wyprosty ramion z hantlem zza głowy";
                list = c.Split(',').ToList();
            }
            else if (index == 2)
            {
                string c = "Martwy ciąg,Podciąganie na drążku,Ściąganie drążka do klatki siedząc,Wiosłowanie na maszynie siedząc,Wiosłowanie sztangą w opadzie tułowia,Wiosłowanie hantlem w oparciu o ławkę,Wznosy barków szrugs";
                list = c.Split(',').ToList();
            }
            else if (index == 3)
            {
                string c = "Przenoszenie hantla za głowę,Rozpiętki hantlami,Rozpiętki linami na bramie,Wyciskanie hantli na ławce prostej,Wyciskanie hantli na ławce skośnej,Wyciskanie sztangi na ławce prostej,Wyciskanie sztangi na ławce skośnej";
                list = c.Split(',').ToList();
            }
            else if (index == 4)
            {
                string c = "Deska bokiem side plank,Deska plank,Podnoszenie nóg wisząc na drążku,Rollowanie AB wheel,Rowerek leżąc,Zginanie tułowia leżąc,Przenoszenie hantla na boki leżąc,Unoszenie nóg leżąc";
                list = c.Split(',').ToList();
            }
            else if (index == 5)
            {
                string c = "Martwy ciąg na prostych nogach,Przysiady ze sztangą,Spinanie łydek na maszynie Smitha,Uginanie nóg z hantlem leżąc,Unoszenie bioder z hantlem Hip Thrust,Wspięcia na palce,Wyciskanie na suwnicy leżąc,Wykroki,Wyprosty na maszynie,Zginanie nóg na maszynie";
                list = c.Split(',').ToList();
            }
            binding.DataSource = list;
           return binding;
        
        }
    }
}
