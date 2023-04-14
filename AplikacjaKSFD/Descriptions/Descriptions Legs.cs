using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Descriptions
{
    static class DescriptionsLegs
    {
        static string Description;

        public static string showDescription(int index) //opisy cwiczen w zależności od rodzaju ćwiczenia w comboboxie w klasie FrTraining
        {
            if (index == 0)
            {
                Description = "Ustaw sztangę z dostosowanym do własnych możliwości obciążeniem na odpowiedniej wysokości na bramie, " +
                    "takiej, na której będziesz w stanie wyjść ze sztangę na karku z lekko ugiętymi nogami oraz odstawienia jej po " +
                    "zakończonej serii. Jako punkt oparcia sztangi wybierz okolice mięśni czworobocznych (kapturowych), ramiona rozstaw" +
                    " szeroko a dłoniami chwyć sztangę i ją kontruj (pozycja jak na zdjęciach). Koniecznie ściągnij łopatki, wypnij klatkę" +
                    " piersiową do przodu i zepnij brzuch. Stopy rozstaw nieco szerzej niż szerokość barków, postaraj się wykonać taki " +
                    "ruch, jakbyś chciał wkręcić je w podłogę delikatnie na zewnątrz. Następnie wykonaj przysiad do kąta 90 stopni lub" +
                    " trochę niżej. Zbyt wysoki przysiad będzie minimalizował efekty ćwiczenia, a zbyt głęboki może się okazać kontuzjogenny." +
                    " Pamiętaj o prawidłowym oddychaniu - tutaj będzie ono odwrotne niż w przypadku innych ćwiczeń - wydech powinien " +
                    "nastąpić w trakcie wypychania sztangi do góry, a wdech na górze. Zalecamy wykonanie co najmniej 10 powtórzeń. " +
                    "Ćwiczenie to angażuje mięśnie czworogłowe i dwugłowe uda oraz lędźwiowe. Najczęstszy błąd to garbienie się, wyginanie" +
                    " kolan do wewnątrz.";
            }
            else if (index == 1)
            {
                Description = "Oprzyj się plecami na linii łopatek o wcześniej przygotowaną ławeczkę lub akcesoria przeznaczone do" +
                    " tego rodzaju treningu, np skrzynię typu crossfit. Wysokość podpory w tym ćwiczeniu nie powinna przekraczać " +
                    "wysokości własnych kolan. Stopy mocno oprzyj o podłogę, nogi rozstaw na szerokość barków. Chwyć hantel lub sztangę" +
                    " z dostosowanym do swoich możliwości ciężarem i oprzyj go na linii zgięcia bioder lub brzuchu. Wyprostuj plecy, " +
                    "wypnij klatkę piersiową i zepnij pośladki. Stopy ustaw w takiej odległości od podpory, aby w górnej fazie ruchu" +
                    " osiągnąć kąt 90 stopni (jak na zdjęciach). Ćwiczenie polega na wypchnięciu bioder do góry do położenia pośladków " +
                    "na ziemi. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas " +
                    "zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. Ćwiczenie to angażuje " +
                    "mięśnie pośladkowe oraz dwugłowe uda. Najczęstszy błąd to garbienie się, położenie się zbyt płytko i skracanie ruchu.";
            }
            else if (index == 2)
            {
                Description = "Połóż się na ławeczce prostej na brzuchu. Swoje kolana ułóż dokładnie tam, gdzie ławeczka ma swój " +
                    "kraniec (jak na zdjęciach). Wcześniej przygotowany hantel z dostosowanym pod swoje możliwości ciężarem połóż na " +
                    "bocznym krążku, poziomo, lub poproś partnera, aby podał go w trakcie rozpoczęcia serii. Wyprostuj nogi w kolanach," +
                    " i postaraj się maksymalnie wyciągnąć stopy oraz złożyć je razem, tak by oplatały sztangielkę i podnieś ją z " +
                    "podłogi. Następnie z pozycji wyprostowanych nóg ułożonych równolegle do podłoża, podnieś hantel stopami do kąta 75" +
                    " stopni i powoli opuść. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić" +
                    " w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 12 powtórzeń. Ćwiczenie to" +
                    " angażuje zwłaszcza mięśnie dwugłowe ud. Najczęstszy błąd to przenoszenie hantla poza kąt 75 stopni i utrata napięcia mięśniowego.";
            }
            else if (index == 3)
            {
                Description = "Przed wykonaniem ćwiczenia załóż na pałąki po bokach maszyny jednakowe obciążenie dostosowane do " +
                    "swoich możliwości. Następnie usiądź na siedzisku przeznaczonym do wykonywania ćwiczenia na maszynie. Wyprostuj " +
                    "plecy i dokładnie przylgnij nimi do oparcia. Dłonie zaciśnij na uchwytach po bokach. Nogi oprzyj o specjalne wałki," +
                    " tak aby zapodać odpowiednią dźwignię dla tego ćwiczenia (jak na zdjęciach). Wyprostuj plecy, wypnij klatkę " +
                    "piersiową i zepnij brzuch. Następnie wykonaj wyprosty nóg w kolanie, tak aby z pozycji prostopadłej do podłoża " +
                    "znalazły się w pozycji równoległej. Ćwiczenie to wykonujemy zazwyczaj naprzemiennie, tj. jedną nogą naraz, " +
                    "zmieniając ją po każdym powtórzeniu. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech " +
                    "powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 12 " +
                    "powtórzeń na każdą nogę (24 powtórzenia). Ćwiczenie to angażuje mięśnie czworogłowe ud. Najczęstszy błąd to " +
                    "odrywanie tułowia od oparcia.";
            }
            else if (index == 4)
            {
                Description = "Przed wykonaniem ćwiczenia załóż na pałąki po bokach maszyny jednakowe obciążenie dostosowane do " +
                    "swoich możliwości. Następnie usiądź na siedzisku przeznaczonym do wykonywania ćwiczenia na maszynie. Wyprostuj" +
                    " plecy i dokładnie przylgnij nimi do oparcia wraz z głową. Dłonie zaciśnij na uchwytach po bokach. Stopy oprzyj " +
                    "na specjalnie do tego wyznaczonym panelu szerzej niż szerokość barków. Wypnij klatkę piersiową i zepnij brzuch." +
                    " Przestaw zawiasy zabezpieczające i wypchnij panel nogami do momentu, gdy będą one prawie proste w kolanach, " +
                    "ale nie wykonuj przeprostów (jak na zdjęciach). Następnie opuść go do momentu osiągnięcia przez stawy kolanowe" +
                    " kąta 90 stopni. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w " +
                    "podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 12 powtórzeń. Ćwiczenie to " +
                    "angażuje mięśnie czworogłowe i dwugłowe ud. Najczęstszy błąd to wykonywanie przeprostów w kolanach, opieranie " +
                    "ciężaru na stawach.";
            }
            else if (index == 5)
            {
                Description = "Usiądź na siedzisku przeznaczonym do wykonywania ćwiczenia na maszynie bokiem do wyciągu. Nogi oprzyj" +
                    " o specjalne wałki, tak aby zapodać odpowiednią dźwignię dla tego ćwiczenia (jak na zdjęciach). Jeden z nich " +
                    "powinien blokować nogi z dołu, a drugi od góry. Ustaw ciężar na wyciągu dostosowany do swoich możliwości. Dłonie " +
                    "zaciśnij na uchwytach po bokach, pozwoli to uniknąć oderwania się od siedziska w trakcie ruchu. Wyprostuj plecy, " +
                    "wypnij klatkę piersiową i zepnij brzuch. Następnie wykonaj zgięcie nóg w kolanie, tak aby z pozycji równoległej " +
                    "do podłoża znalazły się w pozycji prostopadłej około 90 stopni. Pamiętaj o prawidłowym oddychaniu: w pozycji " +
                    "początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy" +
                    " wykonanie co najmniej 12 powtórzeń. Ćwiczenie to angażuje mięśnie dwugłowe ud. Najczęstszy błąd to odrywanie tułowia od oparcia.";
            }
            else if (index == 6)
            {
                Description = "Ustaw sztangę, która porusza się na szynach suwnicy, z dostosowanym do własnych możliwości obciążeniem" +
                    " na odpowiedniej wysokości na bramie. Następnie ustaw pod suwnicą, dokładnie równolegle do sztangi patrząc z góry, " +
                    "skrzynię typu crossfit lub podest do ćwiczeń. Wysokość sztangi powinna być taka, abyś mógł przestawić zawiasy " +
                    "zabezpieczające przed ruchem oraz wraz ze sztangą położoną na plecach dokonać pełnego spięcia łydek (jak na zdjęciach)." +
                    "Podest ustaw na takiej głębokości, aby zachować naturalną krzywiznę kręgosłupa, bez pochylenia do przodu lub tyłu. " +
                    "Wejdź na podest pod sztangą, nogi rozstaw na szerokość barków, a dłońmi chwyć sztangę tak aby kontrować jej pozycję" +
                    " na karku. Następnie przestaw zawiasy zabezpieczające i Wykonaj pełne spięcia łydek wraz z ich rozciągnięciem w dolnej" +
                    " fazie ruchu. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas " +
                    "zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 12 powtórzeń. Ćwiczenie to angażuje mięśnie" +
                    " brzuchate łydek. Najczęstszy błąd to utrata napięcia mięśniowego, rozluźnienie mięśni.";
            }
            else if (index == 7)
            {
                Description = "Przed wykonaniem ćwiczenia załóż na pałąk na górze maszyny obciążenie dostosowane do swoich możliwości." +
                    " Następnie usiądź na siedzisku przeznaczonym do wykonywania ćwiczenia na maszynie. Dłonie zaciśnij na uchwytach przed" +
                    " sobą. Nogi oprzyj o specjalne wałki, tak aby zapodać odpowiednią dźwignię dla tego ćwiczenia, a stopy górną krawędzią" +
                    " oprzyj o dolne panele (jak na zdjęciach). Przestaw zawias zabezpieczający i wykonaj pełne spięcia łydek wraz z ich " +
                    "rozciągnięciem w dolnej fazie ruchu. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien" +
                    " nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 12 powtórzeń. Ćwiczenie" +
                    " to angażuje mięśnie brzuchate łydek. Najczęstszy błąd to utrata napięcia mięśniowego, rozluźnienie mięśni.";
            }
            else if (index == 8)
            {
                Description = "Stań wyprostowany i chwyć 2 jednakowe hantle z ciężarem dostosowanym do swoich możliwości. Wyprostuj" +
                    " ramiona i ułóż je wzdłuż linii ciała, aby hantle znajdowały się po bokach tułowia. Ściągnij łopatki, wypnij " +
                    "klatkę piersiową i zepnij brzuch. Następnie wykonaj wykrok do przodu aby kolano nogi wykrocznej zgięte było o " +
                    "kąt 90 stopni (jak na zdjęciach), a następnie wróć do pozycji początkowej. Ćwiczenie to wykonujemy zazwyczaj " +
                    "naprzemiennie, tj. jedną nogą naraz, zmieniając ją po każdym powtórzeniu. Możesz wykonywać je w miejscu, lub" +
                    " idąc wykrok za wykrokiem. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien " +
                    "nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 12 powtórzeń na" +
                    " każdą nogę (24 powtórzenia). Ćwiczenie to angażuje mięśnie czworogłowe i dwugłowe ud oraz pośladki. Najczęstszy" +
                    " błąd to garbienie się, opieranie kolana na podłodze.";
            }
            else if (index == 9)
            {
                Description = "Stań jak najbliżej sztangi z dostosowanym do swoich możliwości obciążeniem, tak aby patrząc od góry " +
                    "znajdowała się ona nad stopami. Przyjmij odpowiednią pozycję. Pochyl się, utrzymująć nogi wyprostowane w kolanach" +
                    " i chwyć sztangę trochę szerzej niż szerokość barków, tak aby podnosząc ją nie ocierać dłońmi o nogi. Stopy " +
                    "rozstaw na szerokość barków, wyprostuj plecy, wypnij klatkę piersiową i zepnij brzuch (jak na zdjęciach). W trakcie" +
                    " podnoszenia ciężaru utrzymuj delikatny przeprost pleców poprzez wypięcie pośladków. Unieś sztangę, trzymając ją " +
                    "jak najbliżej ciała, niemalże o nie ocierając, do momentu wyprostowania nóg i pleców w całości oraz spięcia łopatek." +
                    "Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do" +
                    " końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. Jest to wariant zwyczajnego martwego ciągu. " +
                    "Ćwiczenie to angażuje mięśnie dwugłowe ud, pośladkowe oraz lędźwiowe. Najczęściej popełnianie błędy to garbienie się," +
                    " rozluźnienie mięśni postawy.";
            }

            return Description;
        }
    }
}
