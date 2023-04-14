using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Descriptions
{
    static class DescriptionsShoulders
    {
        static string Description;
        public static string showDescription(int index) //opisy cwiczen w zależności od rodzaju ćwiczenia w comboboxie w klasie FrTraining
        {
            if (index == 0)
            {
                Description = "Stań wyprostowany, nogi ustaw na szerokość barków, ściągnij łopatki, " +
                    "cofnij brodę tak aby głowa zachowała neutralną pozycję. Chwyć 2 jednakowe hantle " +
                    "dostosowane ciężarem do swoich możliwości. Ręce delikatnie ugnij w łokciach (nie " +
                    "zbyt bardzo ponieważ skróci to dźwignię) i unieś je w bok, wypchnij je do kąta 90 " +
                    "stopni jak na zdjęciach. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej " +
                    "wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia." +
                    " Zalecamy wykonać co najmniej 12 powtórzeń. Ćwiczenie angażuje przede wszystkim boczny " +
                    "akton barków. Najczęstszy błąd - wymachiwanie w pozycji pochylonej.";
            }
            else if (index == 1)
            {
                Description = "Stań wyprostowany, nogi ustaw na szerokość barków, ściągnij łopatki, cofnij " +
                    "brodę tak aby głowa zachowała neutralną pozycję. Chwyć 2 jednakowe hantle dostosowane " +
                    "ciężarem do swoich możliwości. Wyprostuj ręce i unieś je równo do przodu do kąta 90 stopni " +
                    "jak na zdjęciach. Ćwiczenie to wykonujemy zazwyczaj naprzemiennie, tj.jedną ręką naraz, " +
                    "zmieniając je po każdym powtórzeniu. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej " +
                    "wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. " +
                    "Zalecamy wykonać co najmniej 12 powtórzeń na każdą rękę (24 powtórzenia). Ćwiczenie to " +
                    "angażuje przede wszystkim przedni akton barków. Najczęstszy błąd to wymachiwanie w pozycji pochylonej.";
            }
            else if (index == 2)
            {
                Description = "Stań wyprostowany, nogi ustaw na szerokość barków, ściągnij łopatki, cofnij brodę " +
                    "tak aby głowa zachowała neutralną pozycję. Zepnij brzuch, chwyć sztangę nachwytem na szerokości " +
                    "barków lub trochę szerzej. Można zastosować sztangę prostą lub łamaną. Wyprostuj ramiona, a " +
                    "następnie unieś sztangę do wysokości klatki piersiowej, ruch wykonując możliwie najbliżej tułowia," +
                    " wypychając przy tym łokcie na boki. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech," +
                    " a wydech powiniennastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie " +
                    "co najmniej 12 powtórzeń. Ćwiczenie to angażuje przedni i boczny akton barków. Najczęstszy błąd to cofanie" +
                    " łokci do tyłu.";
            }
            else if (index == 3)
            {
                Description = "Chwyć 2 jednakowe hantle dostosowane ciężarem do swoich możliwości. Usiądź na siedzisku " +
                    "ławki poziomej. Pochyl się tak, aby kolana znajdowały się możliwie najbliżej klatki piersiowej, jednak" +
                    " pamiętaj o ściągnietych łopatkach. Pozwól hantlom zawisnąć po bokach twojego ciała w okolicach łydek. " +
                    "Wyprostuj ramiona a następnie unieś je maksymalnie do tyłu, spinając przy tym łopatki. W trakcie ruchu " +
                    "łokcie powinny skierowane być możliwie najbardziej ku sufitowi. Pamiętaj o prawidłowym oddychaniu: w " +
                    "pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji " +
                    "ćwiczenia. Zalecamy wykonanie co najmniej 12 powtórzeń. Ćwiczenie to angażuje tylny akton barków. " +
                    "Najczęstszy błąd to wymachiwanie z odchylonym tułowiem, zarzucanie.";
            }
            else if (index == 4)
            {
                Description = "Połóż się na ławce płaskiej bokiem. Wypnij klatkę piersiową, obejmij ręką która jest bliżej " +
                    "podłogi oparcie ławeczki oraz opleć ją stopami na jej przeciwległym krańcu, zaprzyj się tak, aby " +
                    "unieruchomić pozycję (jak na zdjęciach). Następnie chwyć ręką, która jest dalej od podłogi wcześniej " +
                    "przygotowany hantel z ciężarem dostosowanym do własnych możliwości i delikatnie ugnij ją w łokciu. " +
                    "Półkolistym ruchem przenieś hantel od strony podłoża ku górze do maksymalnego spięcia łopatek i barku, " +
                    "lecz trzymaj łokieć zablokowany (aby nie skrócić dźwigni). Ćwiczenie to wykonujemy zazwyczaj naprzemiennie, " +
                    "tj. jedną ręką naraz, zmieniając ją po każdej serii. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej " +
                    "wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie " +
                    "co najmniej 12 powtórzeń. Ćwiczenie to angażuje tylni akton barków. Najczęstszy błąd to brak blokady łokcia w " +
                    "trakcie ruchu";
            }
            else if (index == 5)
            {
                Description = "Ustaw oparcie ławki pod kątem 90 stopni i usiądź na niej opierając się o nią przylgiętymi " +
                    "łopatkami. Chwyć 2 jednakowe hantle dostosowane ciężarem do swoich możliwości. Zepnij mięśnie brzucha " +
                    "oraz wypnij klatkę piersiową. Mocno oprzyj stopy na ziemi. Chwyć hantle i unieś je na wysokość uszu, " +
                    "z szerokim rozstawem ramion, łokcie wysuwając przed boczną oś ciała (jak na zdjęciach). Następnie unieś " +
                    "je nad głowę, wykonując trajektorię ruchu zbliżoną do trójkąta. Pamiętaj o prawidłowym oddychaniu: w pozycji " +
                    "początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy " +
                    "wykonanie co najmniej 10 powtórzeń. Ćwiczenie to angażuje całą obręcz barkową. Najczęstszy błąd to wygięcie " +
                    "tułowia, gdzie linia ramion cofa się poza linię bioder i zbyt gwałtowne opuszczanie hantli.";
            }
            else if (index == 6)
            {
                Description = "Stań wyprostowany, nogi ustaw na szerokość barków, ściągnij łopatki, napnij mięśnie brzucha " +
                    "oraz pośladki. Sztangę złap na szerokość barków lub trochę szerzej, by łokcie tworzyły z ciałem kąt 45 " +
                    "stopni, i ułóż ją na wysokości szyi. Cofnij brodę tak, aby głowa zachowała neutralną pozycję, ponieważ " +
                    "ruch sztangi może kolidować z częścią twarzy. Podczas przenoszenia ciężaru nad głowę należy pamiętać, " +
                    "by w finalnej pozycji sztanga znajdowała się centralnie nad głową. Pamiętaj o prawidłowym oddychaniu: " +
                    "w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji " +
                    "ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. Ćwiczenie to angażuje całą obręcz barkową. " +
                    "Najczęstszy błąd to zbytnie odchylanie się w tył, wyginanie pleców oraz rozluźnienie mięśi.";
            }

            return Description;
        }
    }
}
