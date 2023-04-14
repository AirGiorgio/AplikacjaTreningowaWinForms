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
    public partial class FrMainMenu : Form
    {
        private bool showTips = false;
        public FrMainMenu()
        {        
            InitializeComponent(); //ustalanie rozmiaru komponentów z uwzględnieniem rozdzielczości

            lbHelp.Hide();
            lbCalculatorHelp.Hide();
            lbDietHelp.Hide();
            lbExitHelp.Hide();
            lbSupportHelp.Hide();
            lbTrainingHelp.Hide();

            double X = Screen.PrimaryScreen.Bounds.Width;
            double Y = Screen.PrimaryScreen.Bounds.Height;

            btnCalculator.Height = btnDiet.Height = btnTraining.Height = btnSupport.Height = btnExit.Height = Convert.ToInt32(Y / 7);
            btnCalculator.Width = btnDiet.Width = btnTraining.Width = btnSupport.Width = btnExit.Width = (btnCalculator.Height * 2);
            btnHelp.Height = btnHelp.Width = Convert.ToInt32(X / 17.06666666666667);

            btnCalculator.Location = new Point(Convert.ToInt32((X/ 6.095238095238095)), Convert.ToInt32((Y/ 5.5)));
            btnDiet.Location = new Point(Convert.ToInt32((X / 1.662337662337662)), Convert.ToInt32((Y / 3)));
            btnTraining.Location = new Point(Convert.ToInt32((X / 6.095238095238095)), Convert.ToInt32((Y / 2.2)));
            btnSupport.Location = new Point(Convert.ToInt32((X / 1.662337662337662)), Convert.ToInt32((Y / 1.65)));
            btnExit.Location = new Point(Convert.ToInt32((X / 6.095238095238095)), Convert.ToInt32((Y / 1.37)));
            btnHelp.Location = new Point(Convert.ToInt32((X / 1.196261682242991)), Convert.ToInt32((Y / 32)));

            lbCalculatorHelp.Location = new Point(Convert.ToInt32((X / 5.9)), Convert.ToInt32((Y / 3)));
            lbDietHelp.Location = new Point(Convert.ToInt32((X / 1.662337662337662)), Convert.ToInt32((Y / 2.05)));
            lbTrainingHelp.Location = new Point(Convert.ToInt32((X / 5.8)), Convert.ToInt32((Y / 1.62)));
            lbSupportHelp.Location = new Point(Convert.ToInt32((X / 1.63)), Convert.ToInt32((Y / 1.32)));
            lbExitHelp.Location = new Point(Convert.ToInt32((X / 5.1)), Convert.ToInt32((Y / 1.125)));
            lbHelp.Location = new Point(Convert.ToInt32((X / 1.65)), Convert.ToInt32((Y / 16)));
            lbCopyright.Location = new Point(Convert.ToInt32((X / 2.6)), Convert.ToInt32((Y / 1.13)));
        }

        private void btnExit_Click_1(object sender, EventArgs e) //przekierowania do konkrentych modułów
        {
            Application.Exit();
        }

        private void btnCalculator_Click(object sender, EventArgs e) 
        {
            FrCalculator frCalculator = new FrCalculator();
            frCalculator.Show();
            this.Close();
        }

        private void btnDiet_Click(object sender, EventArgs e)
        {
            FrDiet frDiet = new FrDiet();
            frDiet.Show();
            this.Close();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            FrTraining frTraining = new FrTraining();
            frTraining.Show();
            this.Close();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu było kiedyś przekierowanie do zewnętrznej witryny.\r\nW przyszłości być może zrobię moduł nadzorujący progres ");

        }

        private void btnHelp_Click(object sender, EventArgs e) //zdarzenia wyswietlania i chowania wskazowek, triggeruje je bool showTips ktory przestawia button pomocy '?'
        {
            showTips = true;
            lbHelp.Show();
        }

        private void btnHelp_MouseHover(object sender, EventArgs e)
        {
            if (showTips==true)
            {
                lbHelp.Show();
            }
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            lbHelp.Hide();
        }

        private void btnCalculator_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbCalculatorHelp.Show();
            }
        }

        private void btnCalculator_MouseLeave(object sender, EventArgs e)
        {
            lbCalculatorHelp.Hide();
        }

        private void btnDiet_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbDietHelp.Show();
            }
        }

        private void btnDiet_MouseLeave(object sender, EventArgs e)
        {
            lbDietHelp.Hide();
        }

        private void btnTraining_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbTrainingHelp.Show();
            }
        }

        private void btnTraining_MouseLeave(object sender, EventArgs e)
        {
            lbTrainingHelp.Hide();
        }

        private void btnSupport_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbSupportHelp.Show();
            }
        }

        private void btnSupport_MouseLeave(object sender, EventArgs e)
        {
            lbSupportHelp.Hide();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbExitHelp.Show();
            }
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            lbExitHelp.Hide();
        }
    }
}
