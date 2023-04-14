using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Descriptions
{
    static class DescriptionsChest
    {
        static string Description;

        public static string showDescription(int index) //opisy cwiczen w zależności od rodzaju ćwiczenia w comboboxie w klasie FrTraining
        {
            if (index == 0)
            {
                Description = "Ustaw sztangę z dostosowanym do własnych możliwości obciążeniem na odpowiedniej wysokości, takiej," +
                    " na której będziesz w stanie zdjąć sztangę z wyprostowanymi rękami w trakcie leżenia na plecach oraz odstawienia" +
                    " jej po zakończonej serii. Następnie, połóż się na ławce płaskiej na plecach. Twoje czoło powinno być dokładnie pod" +
                    " sztangą, nie kładź się zbyt głęboko, aby nie zawadzić o stojaki w trakcie ruchu. Rozstaw nogi na boki ławki i " +
                    "stopy mocno oprzyj o podłogę (jak na zdjęciu). Ściągnij łopatki, wypnij klatkę piersiową i zepnij brzuch. Chwyć " +
                    "sztangę na szerokości barków lub trochę szerzej i wyjmij ja ze stojaka. Przenieś ją, aby była równo nad klatką" +
                    " piersiową. Następnie opuść sztangę do klatki piersiowej i wypchnij z powrotem do momentu wyprostowania ramion. " +
                    "Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania " +
                    "się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. Ćwiczenie to angażuje mięśnie " +
                    "klatki piersiowej oraz tricepsy. Najczęstszy błąd to kierowanie łokci na zewnątrz.";
            }
            else if (index == 1)
            {
                Description = "Ustaw sztangę z dostosowanym do własnych możliwości obciążeniem na odpowiedniej wysokości, takiej, " +
                    "na której będziesz w stanie zdjąć sztangę z wyprostowanymi rękami w trakcie leżenia na plecach oraz odstawienia " +
                    "jej po zakończonej serii. Twoje czoło powinno być dokładnie pod sztangą, nie kładź się zbyt głęboko, aby nie " +
                    "zawadzić o stojaki w trakcie ruchu. Następnie, połóż się na ławce skośnej na plecach. Rozstaw nogi na boki ławki" +
                    " i stopy mocno oprzyj o podłogę (jak na zdjęciu). Ściągnij łopatki, wypnij klatkę piersiową i zepnij brzuch. Chwyć" +
                    " sztangę na szerokości barków lub trochę szerzej i wyjmij ja ze stojaka. Przenieś ją, aby była równo nad klatką " +
                    "piersiową. Następnie opuść sztangę do klatki piersiowej i wypchnij z powrotem do momentu wyprostowania ramion. " +
                    "Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania" +
                    " się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. Ćwiczenie to angażuje mięśnie " +
                    "klatki piersiowej, szczególnie jej górne aktony oraz tricepsy. Najczęstszy błąd to kierowanie łokci na zewnątrz.";
            }
            else if (index == 2)
            {
                Description = "Chwyć 2 jednakowe hantle z ciężarem dostosowanym do swoich możliwości. Połóż się na plecach na ławce" +
                    " płaskiej. Stopy oprzyj o podłogę, ramiona delikatnie ugnij w łokciach i ułóż przed sobą ze sztangielkami, palce" +
                    " kierując ku sobie (jak na zdjęciach). Wypnij klatkę piersiową i ściągnij łopatki, zepnij brzuch. Następnie rozłóż" +
                    " delikatnie ugięte ramiona z pozycji prostopadłej do podłoża do pozycji równoległej, czyli około 90 stopni, hamując" +
                    " ruch oraz powróć do początkowej pozycji. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech" +
                    " powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń." +
                    " Ćwiczenie to angażuje mięśnie klatki piersiowej. Najczęstszy błąd to przeprosty w ramionach i zbytnie rozciągnięcie klatki.";
            }
            else if (index == 3)
            {
                Description = "Ustaw odpowiednie dla siebie jednakowe obciążenie po obu stronach wyciągu, na którym będziesz wykonywał " +
                    "ćwiczenie. Stań na środku bramy, nogi ustaw w niewielkim rozkroku, wyprostuj plecy i pochyl się delkatnie do przodu. " +
                    "Złap uchwyty po obu stronach bramy, trzymając delikatnie ugięte ramiona w łokciach. Następnie przeciągnij uchwyty " +
                    "wyciągu od boku przed siebie. Istnieją różne kąty, pod którymi można wykonywać to ćwiczenie. Kąty te definiuje " +
                    "wysokość wyciągów, które można sobie ustawić na bramie. Najpopularniejsze to pozycja dolna, środkowa i górna " +
                    "(jak na zdjęciach), ale kąt ten możesz dobierać indywidualnie na własne potrzeby. Pamiętaj o prawidłowym oddychaniu:" +
                    " w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. " +
                    "Zalecamy wykonanie co najmniej 10 powtórzeń. Ćwiczenie to angażuje mięśnie klatki piersiowej. Najczęstszy błąd to " +
                    "zbytnie i dynamiczne rozciąganie klatki.";

            }
            else if (index == 4)
            {
                Description = "Chwyć 2 jednakowe hantle z ciężarem dostosowanym do swoich możliwości. Połóż się na plecach na ławce" +
                    " płaskiej. Stopy oprzyj o podłogę, wyprostuj ramiona i ułóż hantle przed sobą na szerokości barków, kierując " +
                    "kciuki ku sobie (jak na zdjęciach). Następnie opuść sztangielki do momentu, gdy ich krążki będą na poziomie klatki" +
                    " piersiowej i wypchnij do góry. Trajektoria ruchu powinna być zbliżona do trójkąta. Oznacza to, że w górnej pozycji" +
                    " hantle powinny być blisko siebie, a w dolnej po bokach klatki piersiowej, szeroko. Pamiętaj o prawidłowym " +
                    "oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji" +
                    " ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. Ćwiczenie to angażuje mięśnie klatki piersiowej oraz " +
                    "tricepsy. Najczęstszy błąd to kierowanie łokci na zewnątrz.";
            }
            else if (index == 5)
            {
                Description = "Ustaw kąt ławkeczki na około 45 stopni. Chwyć 2 jednakowe hantle z ciężarem dostosowanym do swoich " +
                    "możliwości i połóż się na ławeczce na plecach. Stopy oprzyj o podłogę, wyprostuj ramiona i ułóż hantle przed " +
                    "sobą na szerokości barków, kierując kciuki ku sobie (jak na zdjęciach). Następnie opuść sztangielki do momentu," +
                    " gdy ich krążki będą na poziomie klatki piersiowej i wypchnij do góry. Trajektoria ruchu powinna być zbliżona do" +
                    " trójkąta. Oznacza to, że w górnej pozycji hantle powinny być blisko siebie, a w dolnej po bokach klatki piersiowej," +
                    " szeroko. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas " +
                    "zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. Ćwiczenie to angażuje " +
                    "mięśnie klatki piersiowej, szczególnie jej górne aktony oraz tricepsy. Najczęstszy błąd to kierowanie łokci na zewnątrz.";
            }
            else if (index == 6)
            {
                Description = "Złącz dłonie razem na kształt trójkąta, chwyć hantel z ciężarem dostosowanym do swoich możliwości oburącz," +
                    " tak aby krążek obiążenia sztangielki opierał się o wewnętrzną część dłoni (jak na zdjęciu). Połóż się na plecach " +
                    "na ławce płaskiej. Stopy oprzyj o podłogę, zepnij brzuch.Sztangielkę trzymaj przed sobą, nad klatką piersiową na " +
                    "lekko ugiętych ramionach. Następnie półkolistym ruchem przenieś ją za głowę do momentu gdy ręce będą równoległe " +
                    "do podłoża i powróć. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w " +
                    "podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 10 powtórzeń. Ćwiczenie to " +
                    "angażuje mięśnie klatki piersiowej. Najczęstszy błąd to unoszenie stóp nad podłogę.";
            }

            return Description;
        }
    }
}
