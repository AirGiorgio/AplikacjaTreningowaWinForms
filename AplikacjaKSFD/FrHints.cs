using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaKSFD
{
    public partial class FrHints : Form
    {
        public FrHints(int i)
        {
            InitializeComponent();
            if (i==0)
            {
                this.RtbHints.Text = "1. Wczytaj wynik z kalkulatora zapotrzebowania kalorycznego i wybierz, ile posiłków chcesz mieć w diecie." + '\n'+
                                     "2. Wybierz kategorię produktu z listy rozwijanej, następnie produkt z kolejnej takiej listy." + '\n' +
                                     "3. Wpisz ilość produktu w gramach lub mililitrach i naciśnij przycisk 'Przelicz'." + '\n' +
                                     "4. Uzyskany wynik kalorii oraz produkt możesz dodawać do list, które przewija się przyciskami strzałek" + '\n' +
                                     "5. Aby dodać produkt naciśnij przycisk 'dodaj do listy', a żeby usuwać przycisk 'usuń z listy' po zaznaczeniu produktu na liście" + '\n' +
                                     "6. Aby zapisać dietę do pliku naciśnij przycisk 'Zapisz do pliku' (dieta musi być kompletna)";
            } 
            else if (i==1)
            {
                this.RtbHints.Text = "1. Wybierz jakim rodzajem treningu będziesz ćwiczyć z listy rozwijanej oznaczonej 'rodzaj treningu'" + '\n' +
                                     "2. Wybierz partię ciała, którą zamierzasz trenować oraz ćwiczenie na daną partię ciała z kolejnych list rozwijanych " + '\n' +
                                     "3. Po lewej stronie uzyskasz podgląd ćwiczenia na zdjęciach, które możesz przewijać przyciskami 'następne zdjęcie' i 'poprzednie zdjęcie'." + '\n' +
                                     "4. Wybierz ilość serii danego ćwiczenia, jeśli zdecydujesz się na dodanie go do listy." + '\n' +
                                     "5. Aby dodać ćwiczenie do listy, naciśnij 'dodaj do listy'. Listy można przewijać przyciskami ze strzałkami (ilość list zależy od wybranego rodzaju treningu'." + '\n' +
                                     "6. Aby usunąć ćwiczenie z listy, naciśnij 'usuń z listy' po zaznaczeniu pozycji na liście." + '\n' +
                                     "7. Aby zapisać trening do pliku, naciśnij przycisk 'Zapisz do pliku' (trening musi być kompletny).";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
