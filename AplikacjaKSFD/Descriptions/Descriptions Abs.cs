using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Descriptions
{
    static class DescriptionsAbs
    {
         static string Description;

        public static string showDescription(int index) //opisy cwiczen w zależności od rodzaju ćwiczenia w comboboxie w klasie FrTraining
        {
            if (index == 0)
            {
                Description = "Ćwiczenie izometryczne (czyli takie które polega wyłącznie na napinaniu mięśni, a nie na ich ruchu). " +
                "Polega na podporze na przedramionach i palcach stóp z utrzymaniem naturalnej krzywizny kręgosłupa. W tym celu klęknij" +
                " na podłodze, a następnie oprzyj łokcie i przedramiona na podłodze. Barki powinny znajdować się dokładnie nad łokciami." +
                " Następnie wyprostuj kolana, tak by nogi opierały się na palcach stóp. Wyprostuj plecy, zepnij brzuch. Nie wyginaj " +
                "odcinka lędźwiowego do góry ani do dołu, tak by całe ciało było w jednej linii. Postaraj się wytrzymać w tej pozycji" +
                " jak najdłużej. Ćwiczenie to angażuje mięśnie proste i skośne brzucha. Najczęstszy błąd to wyginanie odcinka lędźwiowego.";
            }
            else if (index == 1)
            {
                Description = "Ćwiczenie izometryczne (czyli takie które polega wyłącznie na napinaniu mięśni, a nie na ich ruchu). " +
                    "Polega na podporze na przedramieniu, w pozycji bocznej, z utrzymaniem naturalnej krzywizny kręgosłupa. W tym celu" +
                    " połóż się na podłodze na boku, podpierając się na przedramieniu, tak by kąt między ramieniem a przedramieniem " +
                    "wynosił 90 stopni. Bark powinien znajdować się nad łokciem. Drugą rękę połóż na drugim boku, jak na zdjęciu. " +
                    "Ciężar nóg oprzyj na stopie, która znajduje się niżej względem podłoża. Wyprostuj biodra, napnij mięśnie " +
                    "pośladkowe, ustaw miednicę w pozycji neutralnej, tak by całe ciało było w jednej linii. Postaraj się wytrzymać " +
                    "w tej pozycji jak najdłużej. Ćwiczenie angażuje mięśnie skośne brzucha. Najczęstszy błąd  to odchylanie bioder w " +
                    "kierunku podłogi.";
            }
            else if (index == 2)
            {
                Description = "Klęknij na podłodze, wyprostuj plecy i napnij brzuch. Ustaw kółko przed sobą na podłodze i złap je" +
                    " za uchwyty po bokach. Postaraj się trzymając proste plecy toczyć koło do przodu, posuwając w trakcie ruchu łuk" +
                    " biodrowy, do momentu w którym brzuch prawie dotyka ziemi. Następnie wróć do pozycji początkowej. Postaraj się" +
                    " wykonać jak najwięcej powtórzeń. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech " +
                    "powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Ćwiczenie angażuje mięśnie proste i " +
                    "skośne brzucha. Najczęstszy błąd to odchylanie odcinka lędźwiowego i garbienie się.";
            }
            else if (index == 3)
            {
                Description = "Złap za drążek poziomy nachwytem, podnieś stopy nad ziemię i ustabilizuj pozycję. Powoli unieś " +
                    "wyprostowane, zablokowane w kolanach nogi do pozycji równoległej z podłożem, a następnie opuść je. Staraj " +
                    "się nie wykonywać ruchu zbyt gwałtownie i hamować opuszczanie, co pozwoli uniknąć rozbujania się i " +
                    "destabilizacji. Jeśli wariant z wyprostowanymi całymi nogami jest zbyt trudny, możesz również unosić nogi" +
                    " ugięte w kolanach, jak na zdjęciach. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a " +
                    "wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonać co najmniej" +
                    " 12 powtórzeń. Ćwiczenie angażuje mięśnie proste brzucha. Najczęstszy błąd to zarzucanie nóg do góry, huśtanie.";
            }
            else if (index == 4)
            {
                Description = "Połóż się na plecach, głowę opierając o podłogę. Wyprostuj nogi i złącz je. Ramiona także wyprostuj" +
                    " i ułóż wzdłuż ciała. Nogi zablokuj w kolanach i podnieś je do kąta 90 stopni, nie odrywając odcinka lędźwiowego," +
                    " dłoni ani głowy od podłoża. Następnie opuść je, zatrzymując ruch tuż nad ziemią, tak aby brzuch cały czas był " +
                    "napięty. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas " +
                    "zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonać co najmniej 12 powtórzeń. Najczęstszy błąd to " +
                    "położenie nóg na podłodze, utrata napięcia mięśniowego.";
            }
            else if (index == 5)
            {
                Description = "Są to tak zwane popularne 'brzuszki'. Połóż się na plecach, głowę oprzyj na podłodze. Ramiona skrzyżuj" +
                    " na klatce piersiowej, jak na zdjęciach. Nogi ugnij w kolanach pod kątem 90 stopni, oprzyj całe stopy na ziemi." +
                    " Następnie pondnieś głowę w kierunku kolan, tak aby oderwać łopatki od ziemi, ale nie odrywając odcinka lędźwiowego." +
                    " Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania " +
                    "się do końcowej pozycji ćwiczenia. Zalecamy wykonać co najmniej 15 powtórzeń. Ćwiczenie angażuje mięśnie proste " +
                    "brzucha. Najczestszy błąd to zrywanie, zbyt szybki ruch i rozluźnienie mięśni.";
            }
            else if (index == 6)
            {
                Description = "Połóż się na plecach, dłonie ułóż na karku. Podnieś nogi pod kątem 90 stopni do góry i ugnij je w " +
                    "kolanach pod takim samym kątem, jak na zdjęciu. Nie odrywaj odcinka lędźwiowego od podłoża. Następnie unieś " +
                    "łopatki i poruszaj koniczynami, naprzemiennie starając się dotknąć lewym łokciem prawego kolana i prawym łokciem" +
                    " lewego kolana. Podczas, gdy jedna z nóg poruszana jest w górę tułowia, druga jest prostowana, lecz nie dotyka " +
                    "podłoża. Postaraj się wytrzymać w tej pozycji jak najdłużej. Ćwiczenie angażuje mięśnie proste i skośne brzucha." +
                    " Najczęstszy błąd to wyginanie odcinka lędźwiowego, zbyt szybki ruch.";
            }
            else if (index == 7)
            {
                Description = "Usiądź na podłodze. Lekko uginij kolana, złącz całe nogi ze sobą i podnieś je w powietrze jak na " +
                    "zdjęciu. Odchyl przy tym plecy do tyłu pod kątem 45 stopni względem podłoża. Wyprostuj plecy i cofnij brodę, " +
                    "aby głowa zachowała neutralną pozycję. Złap naszykowany ciężarek obiema dłońmi i trzymaj go przed klatką " +
                    "piersiową. Następnie przenoś go z jednej strony tułowia na drugą, w okolicach bioder. Ruch powtarzaj naprzemiennie. " +
                    "Zalecamy wykonać co najmniej 10 powtórzeń na stronę (czyli 20 ogółem). Ćwiczenie angażuje mięśnie proste i skośne " +
                    "brzucha. Najczęstszy błąd to opieranie nóg na podłodze.";
            }

            return Description;
        }

    }
}
