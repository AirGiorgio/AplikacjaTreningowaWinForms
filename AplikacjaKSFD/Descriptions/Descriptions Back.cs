using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD.Descriptions
{
    static class DescriptionsBack
    {
        static string Description;

        public static string showDescription(int index) //opisy cwiczen w zależności od rodzaju ćwiczenia w comboboxie w klasie FrTraining
        {
            if (index == 0)
            {
                Description = "Usiądź na siedzisku przeznaczonym do wykonywania ćwiczenia na maszynie przodem do wyciągu. Ustaw " +
                    "ciężar na wyciągu dostosowany do swoich możliwości. Kolana zablokuj o wałki, które zabezpieczają przed oderwaniem" +
                    " się od siedziska w trakcie ruchu. Chwyć drążek nachwytem szeroko, na końcowych jego wygięciach. Wyprostuj " +
                    "ramiona i wypnij klatkę piersiową i ściągnij łopatki. Przyciągnij drążek możliwie najbliżej klatki piersiowej," +
                    " odchylając się delikatnie do tyłu w trakcie przyciągania, a pochylając w trakcie odwodzenia. Pamiętaj o " +
                    "prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do " +
                    "końcowej pozycji ćwiczenia. Zalecamy wykonanie conajmniej 10 powtórzeń.Ćwiczenie to angażuje szczególnie mięśnie" +
                    " najszersze grzbietu oraz mięśnie równoległoboczne - środek pleców. Najczętszy błąd to nadmierne kołysanie tułowiem.";
            }
            else if (index == 1)
            {
                Description = "Istnieją różne warianty tego ćwiczenia w zależności od rodzaju chwytu. Wariant pierwszy to ten z " +
                    "nachwytem, a drugi - podchwyt. W różnym stopniu angażują mięśnie ramion oraz pleców. Nachwyt szczególnie angażuje" +
                    " środek pleców (mięśnie równoległoboczne) oraz mięśnie najszersze grzbietu, a podchwyt - bicepsy oraz najszersze" +
                    " grzbietu. Chwyć drążek poziomy - szerzej niż szerokość barków, jeśli zdecydowałeś się na nachwyt, lub na " +
                    "szerokości barków, jeżeli zdecydowałeś się na podchwyt. Następnie podnieś stopy nad ziemię i ustabilizuj pozycję," +
                    " wyprostuj ramiona, wypnij klatkę piersiową. Nie krzyżuj nóg, lecz możesz je ugiąć, by uniknąć bujania się w " +
                    "trakcie ruchu. Ściągnij łopatki w dół i podciągnij się do góry do momentu, gdy broda znajdzie się nad drążkiem. " +
                    "Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić podczas zbliżania się " +
                    "do końcowej pozycji ćwiczenia. Postaraj się wykonać tyle powtórzeń, ile zdołasz. Najczęstszy błąd to zarzucanie tułowia," +
                    " machanie nogami.";
            }
            else if (index == 2)
            {
                Description = "Ustaw oparcie ławeczki poziomo, równolegle do podłoża. Kolano oraz dłoń po przeciwnej stronie niż ta," +
                    " w której trzymany będzie hantel, oprzyj o oparcie. Kolano ugnij pod kątem 90 stopni, tak jak na zdjęciu. " +
                    "Wyprostuj plecy, aby ich płaszczyzna była równoległa do oparcia ławki oraz podłoża, wypnij klatkę piersiową i" +
                    " cofnij brodę, żeby głowa zachowała neutralną pozycję. Chwyć hantel z dostosowanym do swoich możliwości ciężarem." +
                    " Ramię, w którym trzymany będzie hantel należy skierować pionowo w dół, delikatnie wysuwając łopatkę do przodu." +
                    " Następnie przyciągnij sztangielkę w stronę biodra, spinając łopatkę. Ćwiczenie to wykonujemy zazwyczaj " +
                    "naprzemiennie, tj. jedną ręką naraz, zmieniając je po każdej serii. Pamiętaj o prawidłowym oddychaniu: w " +
                    "pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. " +
                    "Zalecamy wykonanie conajmniej 10 powtórzeń na każdą rękę (20 powtórzeń). Ćwiczenie to angażuje najbardziej " +
                    "mięśnie najszersze grzbietu oraz mięśnie równoległoboczne - środek pleców. Najczęstszy błąd to garbienie się i" +
                    " zbytnie angażowanie ramion zamiast pleców.";
            }
            else if (index == 3)
            {
                Description = "Istnieją różne warianty tego ćwiczenia w zależności do rodzaju chwytu. Pierwszy wariant to nachwyt," +
                    " a drugi -podchwyt. Różnią się zaangażowaniem mięśni ramion oraz pleców. Nachwyt szczególnie angażuje środek " +
                    "pleców (mięśnie równoległoboczne) oraz mięśnie kapturowe (czworoboczne). Podchwyt jest pomocny w rozwinięciu " +
                    "zwłaszcza mięśni najszerszych grzbietu. Chwyć sztangę z dostosowanym do swoich możliwości obciążeniem wybranym" +
                    " przez siebie sposobem, nogi rozstaw na szerokość barków. Wyprostuj plecy, wypnij klatkę piersiową, zepnij brzuch." +
                    " Ugnij nogi lekko w kolanach, pochyl tułów pod kątem około 60 stopni względem pionu. Utrzymując tą pozycję, " +
                    "wykonaj przyciągnięcie sztangi do klatki piersiowej, jeśli zdecydowałeś się na nachwyt, albo do pępka, jeżeli " +
                    "wybrałeś podchwyt. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić" +
                    " podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie conajmniej 10 powórzeń. Najczętszy błąd " +
                    "to zarzucanie sztangi, garbienie się.";
            }
            else if (index == 4)
            {
                Description = "Usiądź na siedzisku przeznaczonym do wykonywania ćwiczenia na maszynie przodem do wyciągu, a bokiem" +
                    " do obciążenia. Ustaw ciężar na wyciągu dostosowany do swoich możliwości. Oprzyj nogi na specjalnie do tego " +
                    "wyznaczonym panelu, złap obiema rękoma uchwyt zamontowany na wyciągu. Ściągnij łopatki, wypnij klatkę piersiową," +
                    " cofnij brodę tak aby głowa zachowała neutralną pozycję. Nogi powinny być delikatnie ugięte w kolanach, co " +
                    "definiuje odległość siedzenia od wyciągu (jak na zdjęciach). Następnie przyciągnij uchwyt do brzucha w okolicach" +
                    " pępka, spinając przy tym łopatki. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech " +
                    "powinien nastąpić w podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 12 " +
                    "powtórzeń. Ćwiczenie to angażuje szczególnie mięśnie najszersze grzbietu oraz mięśnie równoległoboczne - środek" +
                    " pleców. Najczęstszy błąd to nadmierne bujanie tułowiem.";
            }
            else if (index == 5)
            {
                Description = "Stań wyprostowany, nogi ustaw na szerokość barków, ściągnij łopatki, cofnij brodę tak aby głowa" +
                    " zachowała neutralną pozycję. Złap dwa jednakowe hantle dostosowane do własnych możliwości, wyprostuj ramiona" +
                    " i ułóż je wzdłuż ciała, by hantle znajdowały się po bokach (jak na zdjęciach). Następnie unieś hantle, unosząc" +
                    " jedynie obręcz barkową do góry, spinając przy tym mięśnie czworoboczne (kapturowe). Nie wychylaj głowy w przód" +
                    " w trakcie ruchu. Pamiętaj o prawidłowym oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić" +
                    " podczas zbliżania się do końcowej pozycji ćwiczenia. Zalecamy wykonanie co najmniej 12 powtórzeń. Ćwiczenie " +
                    "to angażuje najbardziej mięśnie czworoboczne grzbietu (tzw. kaptury). Najczęstszy błąd to dodatkowe uginanie ramion" +
                    " z obciążeniem.";
            }
            else if (index == 6)
            {
                Description = "Stań jak najbliżej sztangi z dostosowanym do swoich możliwości obciążeniem, tak aby patrząc od góry " +
                    "znajdowała się ona nad stopami. Przyjmij odpowiednią pozycję. Przykucnij i chwyć sztangę trochę szerzej niż " +
                    "szerokość barków, tak aby podnosząc ją nie ocierać dłońmi o nogi. Stopy rozstaw na szerokość barków, wyprostuj" +
                    " plecy, wypnij klatkę piersiową i zepnij brzuch (jak na zdjęciach). W trakcie podnoszenia ciężaru utrzymuj " +
                    "delikatny przeprost pleców poprzez wypięcie pośladków. Unieś sztangę, trzymając ją jak najbliżej ciała, niemalże" +
                    " o nie ocierając, do momentu wyprostowania nóg i pleców w całości oraz spięcia łopatek. Pamiętaj o prawidłowym " +
                    "oddychaniu: w pozycji początkowej wdech, a wydech powinien nastąpić w podczas zbliżania się do końcowej pozycji " +
                    "ćwiczenia. Ćwiczenie to angażuje bardzo wiele mięśni (najwięcej ze wszystkich), najbardziej mięśnie nóg oraz pleców" +
                    " - zwłaszcza odcinka lędźwiowego i jest niekiedy uważane za wyznacznik ogólny siły. Zalecamy wykonanie co najmniej" +
                    " 10 powtórzeń. Najczęściej popełnianie błędy to garbienie się, rozluźnienie mięśni postawy.";
            }

            return Description;
        }
    }
}
