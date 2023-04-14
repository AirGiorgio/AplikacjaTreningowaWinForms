using AplikacjaKSFD.Food;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaKSFD
{
    public partial class FrDiet : Form
    {
        double X = Screen.PrimaryScreen.Bounds.Width;
        double Y = Screen.PrimaryScreen.Bounds.Height;

        bool showTips = false;

        int Mealnumber = 0;
        int CapturedAmount = 0;
        int KcalLeft =  0;
        string tolist;

        List<ListBox> MealAmount;
        List<Label> labels;
        FrHints Hints = new FrHints(0);
 
        public FrDiet()
        {
            InitializeComponent();   //ustalanie rozmiaru komponentów z uwzględnieniem rozdzielczości

            BtnHint.Height = btnLoad.Height = btnReturn.Height = Convert.ToInt32(Y / 7); 
            BtnHint.Width = btnLoad.Width = btnReturn.Width = (BtnHint.Height * 2);
            btnHelp.Height = btnHelp.Width = Convert.ToInt32(X / 17.06666666666667);
            btnCalculate.Height = btnSave.Height = btnReturn.Height = Convert.ToInt32(Y / 8); ;
            btnCalculate.Width = btnSave.Width = btnReturn.Width = (btnCalculate.Height * 2);

            btnLoad.Location = new Point(Convert.ToInt32((X / 2.42)), Convert.ToInt32((Y / 3.938461538461538)));
            TbLoad.Location = new Point(Convert.ToInt32((X / 2.169491525423729)), Convert.ToInt32((Y / 2.2)));
            lbQuestion.Location = new Point(Convert.ToInt32((X / 3.5)), Convert.ToInt32((Y / 1.7)));
            comboAmount.Location = new Point(Convert.ToInt32((X / 2.169491525423729)), Convert.ToInt32((Y / 1.5)));
            lbState.Location = new Point(Convert.ToInt32((X / 3.047619047619048)), Convert.ToInt32((Y / 34)));
            btnHelp.Location = new Point(Convert.ToInt32((X / 1.1)), Convert.ToInt32((Y / 20.48)));
            lbCategory.Location = new Point(Convert.ToInt32((X / 128)), Convert.ToInt32((Y / 2.9))); 
            comboCategory.Location = new Point(Convert.ToInt32((X / 8)), Convert.ToInt32((Y / 2.9)));
            lbProduct.Location = new Point(Convert.ToInt32((X / 128)), Convert.ToInt32((Y / 2.1)));
            comboProduct.Location = new Point(Convert.ToInt32((X / 8)), Convert.ToInt32((Y / 2.1)));
            lbAmount.Location = new Point(Convert.ToInt32((X / 128)), Convert.ToInt32((Y / 1.65)));
            TbAmount.Location = new Point(Convert.ToInt32((X / 8)), Convert.ToInt32((Y / 1.65)));
            lbResultAmount.Location = new Point(Convert.ToInt32((X / 4.3)), Convert.ToInt32((Y / 1.26)));
            tbResult.Location = new Point(Convert.ToInt32((X / 3)), Convert.ToInt32((Y / 1.27)));
            btnCalculate.Location = new Point(Convert.ToInt32((X / 18)), Convert.ToInt32((Y / 1.35)));
            lbCalculateHelp.Location = new Point(Convert.ToInt32((X / 15)), Convert.ToInt32((Y / 1.15)));
            lbCategoryHelp.Location = new Point(Convert.ToInt32((X / 6.5)), Convert.ToInt32((Y / 2.5)));
            lbProductHelp.Location = new Point(Convert.ToInt32((X / 7.2)), Convert.ToInt32((Y / 1.9)));
            lbAmountHelp.Location = new Point(Convert.ToInt32((X / 10)), Convert.ToInt32((Y / 1.5)));
            lbResultHelp.Location = new Point(Convert.ToInt32((X / 4)), Convert.ToInt32((Y / 1.18))); ;
            btnNext.Location = new Point(Convert.ToInt32((X / 1.2)), Convert.ToInt32((Y / 2)));
            btnPrevious.Location = new Point(Convert.ToInt32((X / 2)), Convert.ToInt32((Y / 2)));
            btnSave.Location = new Point(Convert.ToInt32((X / 1.65)), Convert.ToInt32((Y / 1.35)));
            lbSaveHelp.Location = new Point(Convert.ToInt32((X / 1.63)), Convert.ToInt32((Y / 1.14)));
            btnReturn.Location = new Point(Convert.ToInt32((X / 1.3)), Convert.ToInt32((Y / 1.35)));
            btnAdd.Location = new Point(Convert.ToInt32((X / 1.75)), Convert.ToInt32((Y / 1.57)));
            btnRemove.Location = new Point(Convert.ToInt32((X / 1.3)), Convert.ToInt32((Y / 1.57)));
            btnAdd.Location = new Point(Convert.ToInt32((X / 2.2)), Convert.ToInt32((Y / 1.5)));
            btnRemove.Location = new Point(Convert.ToInt32((X / 2.2)), Convert.ToInt32((Y / 1.3)));

            lbProduct.Hide();
            lbCategory.Hide();
            lbAmount.Hide(); 
            lbResultAmount.Hide();
            lbProductHelp.Hide();
            lbCategoryHelp.Hide();
            lbCategoryHelp.Hide();
            lbAmountHelp.Hide();
            lbCalculateHelp.Hide();
            lbResultHelp.Hide();
            lbSaveHelp.Hide();
            lbHelp.Hide();

            comboCategory.Hide();
            comboProduct.Hide();
            tbResult.Hide();
            TbAmount.Hide();

            btnCalculate.Hide();
            btnSave.Hide();
            btnAdd.Hide();
            btnRemove.Hide();
            btnNext.Hide();
            btnPrevious.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e) //pobierz wynik z klasy statycznej user, domyślnie 0, chyba ze user skorzysta z kalkulatora kalorii i zapisze
        {
            if (User.Kcal==0)
            {
                MessageBox.Show("Nie ma wyniku do wczytania!"); 
                return;
            }
            KcalLeft = User.Kcal; 
            TbLoad.Text = KcalLeft.ToString();

            if (!string.IsNullOrEmpty(comboAmount.Text))
            {
                generatelist();
            }
        }

        private void comboAmount_SelectedIndexChanged(object sender, EventArgs e) //triggeruje ilosc listboxów z posiłkami na podstawie indexu comboboxa
        {
            if (!string.IsNullOrEmpty(TbLoad.Text))
            {
                generatelist();
            }     
        }
        private void generatelist()
        {
            CapturedAmount = comboAmount.SelectedIndex + 3;    
            MealAmount = new List<ListBox>(CapturedAmount);

            for (int i = 0; i < CapturedAmount; i++)
            {
                MealAmount.Add(new ListBox());
                MealAmount[i].Width = 400;
                MealAmount[i].Height = 350;
                MealAmount[i].Font = new Font("MS Sans Serif", 16, FontStyle.Bold | FontStyle.Italic);
                MealAmount[i].BorderStyle = BorderStyle.FixedSingle;
                MealAmount[i].Location = new Point(Convert.ToInt32((X / 1.68)), Convert.ToInt32((Y / 2.75)));
                this.Controls.Add(MealAmount[i]);
                if (i > 0)
                {
                    MealAmount[i].Hide();
                }    
            }
            generatelabels(CapturedAmount);
        }

        private void generatelabels(int capturedAmount) //automatycznie dodaje taka samą ilość labelek opisowych co listoxów
        {
            TbLoad.Location = new Point(Convert.ToInt32((X / 1.65)), Convert.ToInt32((Y / 4.6)));
            this.Controls.Add(new Label
            {
                Width = 600,
                Height = 40,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(230, 63, 6),
                Font = new Font("MS Sans Serif", 16, FontStyle.Bold | FontStyle.Italic),
                Location = new Point(Convert.ToInt32((X / 3)), Convert.ToInt32((Y / 4.5))),
                Text = "Kalorie pozostałe do rozdysponowania:"
            });
            labels = new List<Label>(capturedAmount);
            for (int i = 0; i < capturedAmount; i++)
            {
                labels.Add(new Label());
                labels[i].Width = 300;
                labels[i].Height = 40;
                labels[i].BackColor = Color.Transparent;
                labels[i].ForeColor = Color.FromArgb(230, 63, 6);
                labels[i].Font = new Font("MS Sans Serif", 16, FontStyle.Bold | FontStyle.Italic);
                labels[i].Location = new Point(Convert.ToInt32((X / 1.6)), Convert.ToInt32((Y / 3)));
                labels[i].Text = "Posiłek " + (i+1).ToString();
                this.Controls.Add(labels[i]);
                if (i > 0)
                {
                    labels[i].Hide();
                }
            }
            showRest();
        }
        private void showRest() //pokazuje reszte rzeczy które mają się wtedy pokazać
        {
            lbProduct.Show();
            lbCategory.Show();
            lbAmount.Show();
            lbResultAmount.Show();
            lbAmountHelp.Show();
            comboCategory.Show();
            comboProduct.Show();

            tbResult.Show();
            TbAmount.Show();

            btnRemove.Show();
            btnNext.Show();
            btnSave.Show();
            btnAdd.Show();
            btnCalculate.Show();

            comboAmount.Hide();
            lbQuestion.Hide();
            btnLoad.Hide();
        }

        private void BtnHint_Click(object sender, EventArgs e) //okienko ze wskazówkami
        { 
            if (!Hints.IsDisposed)
            {
                Hints.Show();
                Hints.Focus();
                return;
            }
            else
            {
                Hints = new FrHints(0);
                Hints.Show();
                Hints.Focus();
            }
        }
        private void btnReturn_Click(object sender, EventArgs e) //powrót do menu
        {  
            if (!Hints.IsDisposed)
            {
                Hints.Close();
            }
            FrMainMenu mainMenu = new FrMainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e) //przewin do przodu listboxy z posiłkami, chowa przycisk 'poprzedni' gdy index =0, albo 'następny' gdy dojdzie do ostatniego elementu listy
        {
            btnPrevious.Show();
            labels[Mealnumber].Hide();
            MealAmount[Mealnumber].Hide();
            Mealnumber++;
            MealAmount[Mealnumber].Show();
            labels[Mealnumber].Show();
            if (Mealnumber == MealAmount.Count-1)
            {
                btnNext.Hide();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e) //przewin do tylu listboxy z posiłkami, chowa przycisk 'poprzedni' gdy index =0, albo 'następny' gdy dojdzie do ostatniego elementu listy
        {
            btnNext.Show();
            MealAmount[Mealnumber].Hide();
            labels[Mealnumber].Hide();
            Mealnumber--;
            MealAmount[Mealnumber].Show();
            labels[Mealnumber].Show();
            if (Mealnumber == 0)
            {    
                btnPrevious.Hide();
            }
        }
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e) //wypelnia combobox itemami w zaleznosci od indexu wybranego w innym comboboxie
        {
            comboProduct.DisplayMember = "Description";
            comboProduct.ValueMember = "Value";

            if (comboCategory.SelectedIndex == 0)
            {
                comboProduct.DataSource = combosource(typeof(Cereals.Products));
            }
            else if (comboCategory.SelectedIndex == 1)
            {
                comboProduct.DataSource = combosource(typeof(Dairy.Products));
            }
            else if (comboCategory.SelectedIndex == 2)
            {
                comboProduct.DataSource = combosource(typeof(Fats.Products));
            }
            else if (comboCategory.SelectedIndex == 3)
            {
                comboProduct.DataSource = combosource(typeof(Fish.Products));
            }
            else if (comboCategory.SelectedIndex == 4)
            {
                comboProduct.DataSource = combosource(typeof(Fruits.Products));
            }
            else if (comboCategory.SelectedIndex == 5)
            {
                comboProduct.DataSource = combosource(typeof(ProteinMeat.Products));
            }
            else if (comboCategory.SelectedIndex == 6)
            {
                comboProduct.DataSource = combosource(typeof(Supplements.Products));
            }
            else if (comboCategory.SelectedIndex == 7)
            {
                comboProduct.DataSource = combosource(typeof(Vegetables.Products)); 
            }
        }
        private object combosource(Type type) //wypelnia comboboxy enumami
        {
             return Enum.GetValues(type).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute))
                      as DescriptionAttribute).Description, value
            }).OrderBy(item => item.value).ToList();
        }
    
        private void btnCalculate_Click(object sender, EventArgs e) //oblicza zawartość kcal w produkcie w zależności od wprowadzonej ilości
        {
             try
            {
                int.Parse(TbAmount.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowe dane!");  
                return;
            }
            if (string.IsNullOrEmpty(comboProduct.Text) || string.IsNullOrEmpty (TbAmount.Text))
            {
                MessageBox.Show("Nie wprowadzono potrzebnych danych!"); 
                return;
            }
            else if (Convert.ToInt32(TbAmount.Text.Trim())==0)
            {
                MessageBox.Show("Niepoprawne dane!"); 
            }
            if (comboCategory.SelectedIndex == 0)
            {
                tbResult.Text = Math.Round(Cereals.Calculate(comboProduct.SelectedIndex, Convert.ToInt32(TbAmount.Text.Trim()))).ToString();
            }
            else if (comboCategory.SelectedIndex == 1)
            {
                tbResult.Text = Math.Round(Dairy.Calculate(comboProduct.SelectedIndex, Convert.ToInt32(TbAmount.Text.Trim()))).ToString();
            }
            else if (comboCategory.SelectedIndex == 2)
            {
                tbResult.Text = Math.Round(Fats.Calculate(comboProduct.SelectedIndex, Convert.ToInt32(TbAmount.Text.Trim()))).ToString();
            }
            else if (comboCategory.SelectedIndex == 3)
            {
                tbResult.Text = Math.Round(Fish.Calculate(comboProduct.SelectedIndex, Convert.ToInt32(TbAmount.Text.Trim()))).ToString();
            }
            else if (comboCategory.SelectedIndex == 4)
            {
                tbResult.Text = Math.Round(Fruits.Calculate(comboProduct.SelectedIndex, Convert.ToInt32(TbAmount.Text.Trim()))).ToString();
            }
            else if (comboCategory.SelectedIndex == 5)
            {
                tbResult.Text = Math.Round(ProteinMeat.Calculate(comboProduct.SelectedIndex, Convert.ToInt32(TbAmount.Text.Trim()))).ToString();
            }
            else if (comboCategory.SelectedIndex == 6)
            {
                tbResult.Text = Math.Round(Supplements.Calculate(comboProduct.SelectedIndex, Convert.ToInt32(TbAmount.Text.Trim()))).ToString();
            }
            else if (comboCategory.SelectedIndex == 7)
            {
                tbResult.Text = Math.Round(Vegetables.Calculate(comboProduct.SelectedIndex, Convert.ToInt32(TbAmount.Text.Trim()))).ToString();
            }
            tolist = comboProduct.Text + " " + tbResult.Text + " Kcal";
        }
        private void btnAdd_Click(object sender, EventArgs e) //dodaje do listboxa przeliczony produkt i odejmuje pozostałe kalorie
        {
            if (string.IsNullOrEmpty(tbResult.Text))
            {
                return;
            }
            MealAmount[Mealnumber].Items.Add(tolist);
            TbLoad.Text = (KcalLeft -= Convert.ToInt32(tbResult.Text)).ToString();
        }
        private void btnRemove_Click(object sender, EventArgs e) //usuwa z lisboxa przeliczony produkt i dodaje regexem kalorie
        {
            try
            {
                int subtract = Convert.ToInt32(Regex.Match(MealAmount[Mealnumber].GetItemText(MealAmount[Mealnumber].SelectedItem), @"\d+").Value);
                TbLoad.Text = (KcalLeft += subtract).ToString();
            }
            catch { }
            MealAmount[Mealnumber].Items.Remove(MealAmount[Mealnumber].SelectedItem); 
        }

        private void btnSave_Click(object sender, EventArgs e) //zapisuje diete do pliku
        {
            foreach (ListBox item in MealAmount)
            {
                if (item.Items.Count == 0)
                {
                    MessageBox.Show("Twoja dieta jest niekompletna! \nZapełnij wszystkie listy produktami.");
                    return;
                }
            }
            if (KcalLeft > 50 | KcalLeft < -50)
            {
                DialogResult DR = MessageBox.Show("Czy na pewno chcesz zapisać dietę o ilości kalorii różnej od Twojego zapotrzebowania?",
                   "Zapisywanie do pliku", MessageBoxButtons.YesNo);
                if (DR == DialogResult.No)
                {
                    return;
                }
            }
            int SaveIt = 0;
            SaveToFile STF = new SaveToFile();     
            STF.FileToDesktop(MealAmount.Select(l=>l.Items), SaveIt); 
        }


        private void btnHelp_Click(object sender, EventArgs e) //zdarzenia wyswietlania i chowania wskazowek, triggeruje je bool showTips ktory przestawia button pomocy '?'
        {
            showTips = true;
            lbHelp.Show();
        }

        private void comboCategory_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbCategoryHelp.Show();
            }
        }

        private void comboCategory_MouseLeave(object sender, EventArgs e)
        {
            lbCategoryHelp.Hide();
        }

        private void comboProduct_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbProductHelp.Show();
            }
        }

        private void comboProduct_MouseLeave(object sender, EventArgs e)
        {
            lbProductHelp.Hide();
        }

        private void btnCalculate_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbCalculateHelp.Show();
            }
        }

        private void btnCalculate_MouseLeave(object sender, EventArgs e)
        {
            lbCalculateHelp.Hide();
        }

        private void tbResult_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbResultHelp.Show();
            }
        }

        private void tbResult_MouseLeave(object sender, EventArgs e)
        {
            lbResultHelp.Hide();
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbSaveHelp.Show();
            }  
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            lbSaveHelp.Hide();
        }

        private void btnHelp_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbHelp.Show();
            }
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            lbHelp.Hide();
        }
    }
}
