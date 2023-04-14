using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Descriptions
{
    static  class DescriptionsArms
    {
        static string Description;

        public static string showDescription(int index) //opisy cwiczen w zależności od rodzaju ćwiczenia w comboboxie w klasie FrTraining
        {
            if (index == 0)
            {
                Description = "Stań wyprostowany, chwyć sztangę z ciężarem dostosowanym do swoich możliwości podchwytem, " +
                    "na szerokości ramion lub trochę węziej. Można zastosować sztangę prostą lub łamaną. ściągnij łopatki, " +
                    "wypnij klatkę piersiową i zepnij brzuch. Trzymając stopy w delikatnym rozkroku, wyprostuj ramiona, tak " +
                    "aby sztanga dotykała przodu ud, lecz nie całkowicie, aby nie puścić napięcia mięśniowego w trakcie ruchu" +
                    " (jak na zdjęciach). Następnie nie wysuwając łokci w przód, ugnij ramiona do momentu maksymalnego spięcia" +
                    " bicepsów (supinacji). Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien " +
                    "nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. " +
                    "Ćwiczenie to angażuje mięśnie dwugłowe ramion. Najczęstszy błąd to zarzucanie, wymachiwanie.";
            }
            else if (index == 1)
            {
                Description = "Stań wyprostowany, chwyć 2 jednakowe hantle z ciężarem dostosowanym do swoich możliwości " +
                    "podchwytem. Ściągnij łopatki, wypnij klatkę piersiową i zepnij brzuch. Trzymając stopy w delikatnym " +
                    "rozkroku, wyprostuj ramiona, tak aby hantle znajdowały się po bokach ud, lecz nie całkowicie, aby nie" +
                    " puścić napięcia mięśniowego w trakcie ruchu (jak na zdjęciach). Następnie nie wysuwając łokci w przód " +
                    "ugnij ramiona do momentu maksymalnego spięcia bicepsów (supinacji). Pamiętaj o prawidłowym oddychaniu: " +
                    "w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji " +
                    "ćwiczenia. Ćwiczenie to wykonujemy naprzemiennie, tj. jedną ręka naraz, zmieniając je po każdym powtórzeniu." +
                    " Zalecamy wykonanie co najmniej 10 powtórzeń na jedną rękę (20 powtórzeń). Ćwiczenie to angażuje mięśnie " +
                    "dwugłowe ramion. Najczęstszy błąd to zarzucanie, wymachiwanie.";
            }
            else if (index == 2)
            {
                Description = "Ureguluj wysokość siedziska przeznaczonego do wykonywania tego ćwiczenia na tej maszynie. " +
                    "Odpowiednia wysokość to taka, na której twoje ramiona i łokcie swobodnie będą przylegać do oparcia. " +
                    "Następnie usiądź na tym siedzisku i delikatnie oprzyj się o oparcie klatką piersiową. Wyprostuj plecy, " +
                    "złap uchwyty maszyny i stopy mocno oprzyj o podłogę. Ugnij ramiona do momentu maksymalnego spięcia " +
                    "bicepsów (supinacji), nie odrywając ich od oparcia. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej " +
                    "wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie" +
                    " co najmniej 10 powtórzeń. Ćwiczenie to angażuje mięśnie dwugłowe ramion. Najczęstszy błąd to odrywanie rąk od" +
                    " oparcia.";

            }
            else if (index == 3)
            {
                Description = "Stań wyprostowany, chwyć 2 jednakowe hantle z ciężarem dostosowanym do swoich możliwości w sposób, " +
                    "aby palce obu dłoni były skierowane ku sobie (jak na zdjęciach). Ściągnij łopatki, wypnij klatkę piersiową i " +
                    "zepnij brzuch. Trzymając stopy w delikatnym rozkroku, wyprostuj ramiona, tak aby hantle znajdowały się po " +
                    "bokach ud, lecz nie całkowicie, aby nie puścić napięcia mięśniowego w trakcie ruchu. Następnie nie wysuwając" +
                    " łokci w przód, ugnij ramiona do momentu maksymalnego spięcia bicepsów (supinacji). Ćwiczenie to wykonujemy " +
                    "naprzemiennie, tj. jedną ręką naraz, zmieniając ją po każdym powtórzeniu. Pamiętaj o prawidłowym oddychaniu: " +
                    "w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. " +
                    "Zalecamy wykonanie co najmniej 10 powtórzeń na jedną rękę (20 powtórzeń). Ćwiczenie to angażuje mięśnie dwugłowe" +
                    " ramion. Najczęstszy błąd to wymachiwanie hantlami.";
            }
            else if (index == 4)
            {
                Description = "Stań przodem do wyciągu. Ustaw wysokość wyciągu na możliwie najniższe i obciążenie dostosowane do" +
                    " swoich możliwości, oraz zamieść wybrany przez siebie (prosty lub łamany) drążek lub sznurek na końcu linki. " +
                    "Następnie złap uchwyt wąsko, wyprostuj się, ściągnij łopatki i zepnij brzuch. Trzymając stopy w delikatnym " +
                    "rozkroku, wyprostuj ramiona, tak aby drążek bądź sznurek dotykał przodu ud, lecz nie całkowicie, aby nie " +
                    "puścić napięcia mięśniowego w trakcie ruchu (jak na zdjęciach). Następnie nie wysuwając łokci w przód półkolistym" +
                    " ruchem ugnij ramiona do momentu maksymalnego spięcia bicepsów (supinacji). Pamiętaj o prawidłowym oddychaniu: " +
                    "w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia." +
                    " Zalecamy wykonanie co najmniej 12 powtórzeń. Ćwiczenie to angażuje mięśnie dwugłowe ramion. Najczęstszy błąd to " +
                    "bujanie tułowiem.";
            }
            else if (index == 5)
            {
                Description = "Złap za drążek poziomy nachwytem, podnieś stopy nad ziemię i ustabilizuj pozycję. Wytrzymaj w " +
                    "tej pozycji najdłużej jak potrafisz. Im grubszą średnicę będzie miał drążek poziomy, tym cięższy będzie " +
                    "trening. Ćwiczenie to angażuje wszystkie mięśnie przedramienia, zwłaszcza zginacze nadgarstków. Najczęstszy" +
                    " błąd to nie angażowanie kciuków, brak pełnego uchwytu.";
            }
            else if (index == 6)
            {
                Description = "Usiądź na siedzisku ławeczki poziomej. Złap podchwytem 2 jednakowe hantle lub sztangę z ciężarem " +
                    "dostosowanym do własnych możliwości. Oprzyj przedramiona na udach, tak aby na krawędzi kolan znajdowały się " +
                    "nadgarstki. Następnie zacznij uginać nadgarstki pełnym zakresem ruchu od dołu do góry (jak na zdjęciach). " +
                    "Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania" +
                    " się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 15 powtórzeń. Ćwiczenie to angażuje zginacze " +
                    "nadgarstków. Najczęstszy błąd to odrywanie przedramion od nóg.";
            }
            else if (index == 7)
            {
                Description = "Przygotuj sztangę z obciążeniem dostosowanym do swoich możliwości. Można zastosować sztangę łamaną " +
                    "lub prostą. Następnie połóż się na ławce płaskiej, sztangę podnieś i przenieś nad głowę w trakcie kładzenia się," +
                    " lub poproś partnera, aby podał ją w trakcie rozpoczęcia serii. Złap ją na szerokości barków nachwytem, wyprostuj " +
                    "ramiona w łokciach i skieruj je pod kątem 90 stopni równo w górę, przed siebie. Następnie, półkolistym ruchem opuść" +
                    " przedramiona do okolic czoła i powróć. Łokcie kieruj delikatnie na zewnątrz w trakcie ruchu, lecz nie zbyt szeroko" +
                    " i trzymaj je zablokowane ku sufitowi. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien" +
                    " nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. Ćwiczenie to" +
                    " angażuje mięśnie trójgłowe ramienia. Najczęstszy błąd to brak blokady w łokciach i zarzucanie.";
            }
            else if (index == 8)
            {
                Description = "Przygotuj 2 jednakowe hantle z obciążeniem dostosowanym do swoich możliwości. Następnie połóż się na " +
                    "ławce płaskiej, hantle podnieś i przenieś nad głowę w trakcie kładzenia się, lub poproś partnera, aby podał je w" +
                    " trakcie rozpoczęcia serii. Złap je na szerokości barków takim sposobem, by palce skierowane były ku sobie (jak na " +
                    "zdjęciach), wyprostuj ramiona w łokciach i wykieruj je pod kątem 90 stopni równo w górę, przed siebie. Następnie, " +
                    "półkolistym ruchem opuść przedramiona do okolic czoła i powróć. Łokcie kieruj delikatnie na zewnątrz, lecz nie zbyt " +
                    "szeroko i trzymaj je zablokowane ku sufitowi. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech" +
                    " powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. " +
                    "Ćwiczenie to angażuje mięśnie trójgłowe ramienia. Najczęstszy błąd to brak blokady ramion ku górze i zarzucanie.";
            }
            else if (index == 9)
            {
                Description = "Usiądź na siedzisku ławeczki poziomej. Złap hantel z ciężarem dostosowanym do własnych możliwości " +
                    "jedną ręką i przenieś go pionowo nad głowę. Wyprostuj plecy, następnie ruchem półkolistym opuść sztangielkę za " +
                    "głowę, w okolice szyi. Ramię powinno być skierowane do góry, łokieć trzymaj wycelowany w sufit. Następnie wykonaj" +
                    " powrót do momentu wyprostowania ręki w łokciu. Ćwiczenie to wykonujemy zazwyczaj naprzemiennie, tj.jedną ręką " +
                    "naraz, zmieniając ją po każdej serii. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech " +
                    "powinien nastąpić podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonać co najmniej 10 powtórzeń " +
                    "na każdą rękę (20 powtórzeń). Ćwiczenie to angażuje mięśnie trójgłowe ramienia. Najczęstszy błąd to brak blokady " +
                    "ramienia ku górze.";
            }
            else if (index == 10)
            {
                Description = "Stań przodem do wyciągu. Ustaw wysokość wyciągu na możliwie najwyższą i obciążenie dostosowane do " +
                    "swoich możliwości, oraz zamieść wybrany przez siebie (prosty lub łamany) drążek lub na końcu linki. Następnie " +
                    "złap uchwyt na szerokości barków, wyprostuj się, ściągnij łopatki i zepnij brzuch. Trzymając stopy w delikatnym " +
                    "rozkroku, półkolistym ruchem wyprostuj ramiona z pozycji równoległej do podłoża do maksymalnego spięcia w " +
                    "tricepsach (jak na zdjęciach). Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien" +
                    " nastąpić podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonać co najmniej 10 powtórzeń. Ćwiczenie" +
                    " to angażuje mięśnie trójgłowe ramienia. Najczęstszy błąd to bujanie tułowiem.";
            }
            else if (index == 11)
            {
                Description = "Ustaw wysokość wyciągu na możliwie najniższą i obciążenie dostosowane do swoich możliwości, oraz " +
                    "zamieść sznurek na końcu linki. Złap uchwyty i obróć się, tak abyś znajdował się tyłem do wyciągu, a sznurki " +
                    "przenieś i trzymaj za głową. Wyprostuj się, ściągnij łopatki i zepnij brzuch. Następnie wyprostuj ramiona," +
                    " kierując ruch w stronę sufitu i powróć do pozycji początkowej (jak na zdjęciach). Pilnuj, aby nie wykonywać " +
                    "pełnego powrotu w tył, czyli opuszczać ciężar całkowicie na wyciągu i nie puszczać napięcia mięśniowego. " +
                    "Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić podczas zbliżania" +
                    " się do końcowej pozycji ćwiczenia. Zalecamy wykonać co najmniej 10 powtórzeń. Ćwiczenie to angażuje mięśnie " +
                    "trójgłowe ramienia. Najczęstszy błąd to pochylanie tułowia w przód.";
            }
            else if (index == 12)
            {
                Description = "Stań pomiędzy poręczami do wykonywania ćwiczenia i złap je tak, by palce dłoni skierowane były ku" +
                    " sobie. Wyprostuj ramiona i oderwij stopy od podłoża. Aby zachować lepszą równowagę w trakcie ruchu możesz ugiąć" +
                    " je w kolanach. Następnie zacznij opuszczać się do momentu, gdy pomiędzy ramieniem a przedramieniem zrobi się kąt" +
                    " 90 stopni. Następnie powróć do początkowej pozycji. Trzymaj łokcie możliwie najbliżej tułowia. Pamiętaj o prawidłowym" +
                    " oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji " +
                    "ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. Ćwiczenie to angażuje mięśnie trójgłowe ramienia i klatki " +
                    "piersiowej. Najczęstszy błąd to za szeroki rozstaw łokci.";
            }

            return Description;
        }
    }
}
