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
    public partial class FrCalculator : Form
    {
        private bool showTips = false;
        int weight; 
        int height;
        int age;
        public FrCalculator()
        {   
            InitializeComponent();   //ustalanie rozmiaru komponentów z uwzględnieniem rozdzielczości

            double X = Screen.PrimaryScreen.Bounds.Width;
            double Y = Screen.PrimaryScreen.Bounds.Height; 

            btnCalculate.Height = btnSaveResult.Height = btnReturn.Height = Convert.ToInt32(Y / 7);
            btnCalculate.Width = btnSaveResult.Width = btnReturn.Width = (btnCalculate.Height * 2);
            btnHelp.Height = btnHelp.Width = Convert.ToInt32(X / 17.06666666666667);

            btnHelp.Location = new Point(Convert.ToInt32((X / 1.242718446601942)), Convert.ToInt32((Y / 51.2)));
            lbHelp. Location = new Point(Convert.ToInt32((X / 1.5)), Convert.ToInt32((Y / 20)));
            rbtMale.Location = new Point(Convert.ToInt32((X / 6.4)), Convert.ToInt32((Y / 5.688888888888889)));
            rbtFemale.Location = new Point(Convert.ToInt32((X / 3.6)), Convert.ToInt32((Y / 5.688888888888889)));
            lbGender.Location = new Point(Convert.ToInt32((X / 42.66666666666667)), Convert.ToInt32((Y / 5.688888888888889)));
            lbGenderHelp.Location = new Point(Convert.ToInt32((X / 5)), Convert.ToInt32((Y / 4.4)));
            lbActivity.Location = new Point(Convert.ToInt32((X / 280)), Convert.ToInt32((Y / 3.792592592592593)));
            comboActivity.Location = new Point(Convert.ToInt32((X / 6.736842105263158)), Convert.ToInt32((Y / 3.531034482758621)));
            lbActivityHelp.Location = new Point(Convert.ToInt32((X / 6.918918918918919)), Convert.ToInt32((Y / 2.85)));
            lbHeight.Location = new Point(Convert.ToInt32((X / 280)), Convert.ToInt32((Y / 2.409411764705882)));
            TbHeight.Location = new Point(Convert.ToInt32((X / 6.736842105263158)), Convert.ToInt32((Y / 2.409411764705882)));
            lbHeightHelp.Location = new Point(Convert.ToInt32((X / 6.5)), Convert.ToInt32((Y / 2.111340206185567)));
            lbAge.Location = new Point(Convert.ToInt32((X / 280)), Convert.ToInt32((Y / 1.861818181818182)));
            TbAge.Location = new Point(Convert.ToInt32((X / 6.736842105263158)), Convert.ToInt32((Y / 1.861818181818182)));
            lbAgeHelp.Location = new Point(Convert.ToInt32((X / 6.5)), Convert.ToInt32((Y / 1.678688524590164)));
            lbWeight.Location = new Point(Convert.ToInt32((X / 280)), Convert.ToInt32((Y / 1.505882352941176)));
            TbWeight.Location = new Point(Convert.ToInt32((X / 6.736842105263158)), Convert.ToInt32((Y / 1.505882352941176)));
            lbWeightHelp.Location = new Point(Convert.ToInt32((X / 6.5)), Convert.ToInt32((Y / 1.393197278911565)));
            lbGoal.Location = new Point(Convert.ToInt32((X / 280)), Convert.ToInt32((Y / 1.256441717791411)));
            comboGoal.Location = new Point(Convert.ToInt32((X / 6.736842105263158)), Convert.ToInt32((Y / 1.264197530864198)));
            lbGoalHelp.Location = new Point(Convert.ToInt32((X / 7.5)), Convert.ToInt32((Y / 1.163636363636364)));
            btnCalculate.Location = new Point(Convert.ToInt32((X / 2)), Convert.ToInt32((Y / 5.3)));
            lbCalculateHelp.Location = new Point(Convert.ToInt32((X / 1.953424657534247)), Convert.ToInt32((Y / 3)));
            lbAmount.Location = new Point(Convert.ToInt32((X / 2.1)), Convert.ToInt32((Y / 2.5)));
            TbResult.Location = new Point(Convert.ToInt32((X / 1.9)), Convert.ToInt32((Y / 2.1)));
            lbformula.Location = new Point(Convert.ToInt32((X / 2.45)), Convert.ToInt32((Y / 1.85)));
            btnSaveResult.Location = new Point(Convert.ToInt32((X / 2)), Convert.ToInt32((Y / 1.5)));
            lbHelpSaveResult.Location = new Point(Convert.ToInt32((X / 2.05)), Convert.ToInt32((Y / 1.22)));
            btnReturn.Location = new Point(Convert.ToInt32((X / 1.28)), Convert.ToInt32((Y / 1.3)));

            lbHelp.Hide();
            lbActivityHelp.Hide();
            lbWeightHelp.Hide();
            lbHeightHelp.Hide();
            lbAgeHelp.Hide();
            lbGenderHelp.Hide();
            lbGoalHelp.Hide();
            lbCalculateHelp.Hide();
            lbformula.Hide();
            lbHelpSaveResult.Hide();
        }

        private void btnReturn_Click_1(object sender, EventArgs e) //powrot do menu glownego
        {
            FrMainMenu mainMenu = new FrMainMenu();
            mainMenu.Show();
            this.Close();
        }
        private void btnCalculate_Click_1(object sender, EventArgs e) //waliduje i przelicza dane od uzytkownika
        {
            if (string.IsNullOrEmpty(comboActivity.Text) || string.IsNullOrEmpty(comboGoal.Text)
               || string.IsNullOrEmpty(TbWeight.Text) || string.IsNullOrEmpty(TbHeight.Text)
               || string.IsNullOrEmpty(TbAge.Text) || (!rbtFemale.Checked && !rbtMale.Checked))
            {
                MessageBox.Show("Nie podano wszystkich danych!");
                return;
            }
            try
            {
                weight = Convert.ToInt32(TbWeight.Text.Trim());
                height = Convert.ToInt32(TbHeight.Text.Trim());
                age = Convert.ToInt32(TbAge.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Podano niewłaściwe dane!");
                return;
            }

            if (CheckIfInRange(weight, 40, 150))
            {
                MessageBox.Show("Kalkulator nie jest miarodajny przy podanej wartości wagi!");
                return;
            }
            if (CheckIfInRange(height, 110, 240))
            {
                MessageBox.Show("Kalkulator nie jest miarodajny przy podanej wartości wzrostu!");
                return;
            }
            if (CheckIfInRange(age, 12, 80))
            {
                MessageBox.Show("Kalkulator nie jest miarodajny przy podanej wartości wieku!");
                return;
            }

            User.age = age;
            User.weight = weight;
            User.height = height;
            User.gender = rbtMale.Checked ? 0 : 1;
            User.activity = comboActivity.SelectedIndex;
            User.goal = comboGoal.SelectedIndex;

            TbResult.Text = User.Calculate().ToString();

            lbformula.Show();
            return;
        }

        private static bool CheckIfInRange(int value, int beginning, int end)
        {
            return value < beginning || value > end;
        }

        private void btnSaveResult_Click(object sender, EventArgs e) //zapisuje wynik z kalkulatora 
        {
            if (TbResult.Text != "")
            {
                User.Kcal = Convert.ToInt32(TbResult.Text);
                MessageBox.Show("Pomyślnie zapisano wynik");
            }
            else
            {
                MessageBox.Show("Nie ma wyniku do zapisania!");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e) //zdarzenia wyswietlania i chowania wskazowek, triggeruje je bool showTips ktory przestawia button pomocy '?'
        {
            showTips = true;
            lbHelp.Show();
            
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

        private void btnSaveResult_MouseHover(object sender, EventArgs e)
        {
            lbHelpSaveResult.Show();
        }

        private void btnSaveResult_MouseLeave(object sender, EventArgs e)
        {
            lbHelpSaveResult.Hide();
        }

        private void rbtMale_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbGenderHelp.Show();
            }
        }
        private void rbtMale_MouseLeave(object sender, EventArgs e)
        {
            lbGenderHelp.Hide();
        }

        private void rbtFemale_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbGenderHelp.Show();
            }
        }
        private void rbtFemale_MouseLeave(object sender, EventArgs e)
        {
            lbGenderHelp.Hide();
        }

        private void comboActivity_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbActivityHelp.Show();
            }
        }

        private void comboActivity_MouseLeave(object sender, EventArgs e)
        {
            lbActivityHelp.Hide();
        }

        private void TbHeight_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbHeightHelp.Show();
            }
        }

        private void TbHeight_MouseLeave(object sender, EventArgs e)
        {
            lbHeightHelp.Hide();
        }

        private void TbAge_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbAgeHelp.Show();
            }
        }

        private void TbAge_MouseLeave(object sender, EventArgs e)
        {
            lbAgeHelp.Hide();
        }

        private void TbWeight_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbWeightHelp.Show();
            }
        }

        private void TbWeight_MouseLeave(object sender, EventArgs e)
        {
            lbWeightHelp.Hide();
        }

        private void comboGoal_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbGoalHelp.Show();
            }
        }

        private void comboGoal_MouseLeave(object sender, EventArgs e)
        {
            lbGoalHelp.Hide();
        }

    }
}
