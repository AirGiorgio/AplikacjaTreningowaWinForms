using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaKSFD.Descriptions;

namespace AplikacjaKSFD
{
  
    public partial class FrTraining : Form
    {
        List<Image> imageList = new List<Image>();

        double X = Screen.PrimaryScreen.Bounds.Width;
        double Y = Screen.PrimaryScreen.Bounds.Height;

        int trainingAmount = 0;
        bool showTips = false;
        int whichTraining = 0;
        int whichPicture = 0;

        List<ListBox> TrainingList;
        List<Label> labels;
        FrError frerror = new FrError(); 
        FrHints Hints = new FrHints(1);
        public FrTraining()
        {
            WindowState = FormWindowState.Maximized;       //ustalanie rozmiaru komponentów z uwzględnieniem rozdzielczości
            InitializeComponent();
                                                    
            BtnHint.Height = btnPrevious.Height = btnNext.Height = btnAdd.Height = btnDescription.Height = btnRemove.Height = btnSave.Height =
                btnReturn.Height = Convert.ToInt32(Y / 10);
            BtnHint.Width = btnPrevious.Width = btnNext.Width = btnAdd.Width = btnDescription.Width = btnRemove.Width = btnSave.Width =
                btnReturn.Width = (BtnHint.Height * 2);
            picbox.Height = Convert.ToInt32(X /2.8); picbox.Width = Convert.ToInt32(X / 3.5);

            btnHelp.Height = btnHelp.Width = Convert.ToInt32(X / 17.06666666666667);
            btnHelp.Location = new Point(Convert.ToInt32((X / 3)), Convert.ToInt32((Y / 25)));
            lbHelp.Location = new Point(Convert.ToInt32((X / 2.5)), Convert.ToInt32((Y / 17)));
            picbox.Location = new Point(Convert.ToInt32((X / 1.5)), Convert.ToInt32((Y / 10)));
            btnNext.Location = new Point(Convert.ToInt32((X / 1.17)), Convert.ToInt32((Y / 1.3)));
            btnPrevious.Location = new Point(Convert.ToInt32((X / 1.53)), Convert.ToInt32((Y / 1.3)));
            lbScrollHelp.Location = new Point(Convert.ToInt32((X / 1.28)), Convert.ToInt32((Y / 1.25)));
            lbGalery.Location = new Point(Convert.ToInt32((X / 1.3)), Convert.ToInt32((Y / 17)));
            lbTrainingAmount.Location = new Point(Convert.ToInt32((X / 4)), Convert.ToInt32((Y / 3.3)));
            comboTrainingAmount.Location = new Point(Convert.ToInt32((X / 4)), Convert.ToInt32((Y / 3)));
            lbTrainingAmountHelp.Location = new Point(Convert.ToInt32((X / 4)), Convert.ToInt32((Y / 2.65)));
            BtnHint.Location = new Point(Convert.ToInt32((X / 15)), Convert.ToInt32((Y / 2.8)));
            btnSave.Location = new Point(Convert.ToInt32((X / 1.9)), Convert.ToInt32((Y / 1.3)));
            btnReturn.Location = new Point(Convert.ToInt32((X / 20)), Convert.ToInt32((Y / 1.3)));
            btnNextList.Location = new Point(Convert.ToInt32((X / 2)), Convert.ToInt32((Y / 1.65)));
            btnPrevList.Location = new Point(Convert.ToInt32((X / 8)), Convert.ToInt32((Y / 1.65)));
            lbSaveHelp.Location = new Point(Convert.ToInt32((X / 2.08)), Convert.ToInt32((Y / 1.14)));
            btnDescription.Location = new Point(Convert.ToInt32((X / 2)), Convert.ToInt32((Y / 2.8)));
            btnAdd.Location = new Point(Convert.ToInt32((X / 2.9)), Convert.ToInt32((Y / 2.8)));
            btnRemove.Location = new Point(Convert.ToInt32((X / 5)), Convert.ToInt32((Y / 2.8)));
            lbDescriptionHelp.Location = new Point(Convert.ToInt32((X / 2.07)), Convert.ToInt32((Y / 2.14)));
            lbBodyPart.Location = new Point(Convert.ToInt32((X / 100)), Convert.ToInt32((Y / 4.8)));
            comboBodyPart.Location = new Point(Convert.ToInt32((X / 100)), Convert.ToInt32((Y / 4.1)));
            lbExercise.Location = new Point(Convert.ToInt32((X / 4.4)), Convert.ToInt32((Y / 4.8)));
            comboExercise.Location = new Point(Convert.ToInt32((X / 4.4)), Convert.ToInt32((Y / 4.1)));
            lbSerie.Location = new Point (Convert.ToInt32((X / 1.82)), Convert.ToInt32((Y / 4.8)));
            comboSerieAmount.Location = new Point(Convert.ToInt32((X / 1.8)), Convert.ToInt32((Y / 4.1)));
            lbBodyPartHelp.Location = new Point(Convert.ToInt32((X / 50)), Convert.ToInt32((Y / 3.5)));
            lbExerciseHelp.Location = new Point(Convert.ToInt32((X / 3.6)), Convert.ToInt32((Y / 3.5)));
            lbSerieAmountHelp.Location = new Point(Convert.ToInt32((X / 1.9)), Convert.ToInt32((Y / 3.5)));

            btnAdd.Font = btnRemove.Font = btnNext.Font = btnPrevious.Font = btnDescription.Font = btnSave.Font = btnReturn.Font =  btnDescription.Font=
                BtnHint.Font = btnHelp.Font = BtnHint.Font  = new Font("MS Sans Serif", Convert.ToInt32(X/130), FontStyle.Bold | FontStyle.Italic);
            lbHelp.Font = lbScrollHelp.Font = lbGalery.Font = lbTrainingAmount.Font = lbTrainingAmountHelp.Font = lbExercise.Font = lbExerciseHelp.Font =
                lbSerie.Font = lbSerieAmountHelp.Font = lbBodyPart.Font = lbBodyPartHelp.Font = lbDescriptionHelp.Font = lbSaveHelp.Font =
                new Font("MS Sans Serif", Convert.ToInt32(X / 130), FontStyle.Bold | FontStyle.Italic) ;

            btnNext.Hide();
            btnPrevious.Hide();
            BtnHint.Hide();
            btnNextList.Hide();
            btnPrevList.Hide();
            lbTrainingAmountHelp.Hide();
            lbBodyPartHelp.Hide();
            lbExerciseHelp.Hide();
            lbSerieAmountHelp.Hide();
            lbSaveHelp.Hide();
            lbBodyPart.Hide();
            lbExercise.Hide();
            lbSerie.Hide();
            lbHelp.Hide();
            lbScrollHelp.Hide();
            comboBodyPart.Hide();
            comboExercise.Hide();
            comboSerieAmount.Hide();
            btnAdd.Hide();
            btnRemove.Hide();
            btnDescription.Hide();
            lbDescriptionHelp.Hide();
            btnSave.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e) //powrot do menu
        {
            if (!Hints.IsDisposed)
            {
                Hints.Close(); 
            }
            FrMainMenu mainMenu = new FrMainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void BtnHint_Click(object sender, EventArgs e) //wyswietl wskazowki
        {
            FrHints Hints = new FrHints(1);
            Hints.Show();
            Hints.Focus();
        }

        private void comboTrainingAmount_SelectedIndexChanged(object sender, EventArgs e) //triggeruje generate list z ilością listboxów jaką wybrał użytkownik
        {
            trainingAmount = comboTrainingAmount.SelectedIndex+1;
            generatelist(trainingAmount);   
        }
        private void generatelist(int training)
        {
            TrainingList = new List<ListBox>(training);

            for (int i = 0; i < training; i++)
            {
                TrainingList.Add(new ListBox());
                TrainingList[i].Width = 600;
                TrainingList[i].Height = 400;
                TrainingList[i].Font = new Font("MS Sans Serif", 16, FontStyle.Bold | FontStyle.Italic);
                TrainingList[i].BorderStyle = BorderStyle.FixedSingle;
                TrainingList[i].Location = new Point(Convert.ToInt32((X / 5)), Convert.ToInt32((Y / 1.9)));
                this.Controls.Add(TrainingList[i]);
                if (i > 0)
                {
                    TrainingList[i].Hide();
                }
            }
             generatelabels(training);
        }
        private void generatelabels(int capturedAmount) //generuje labelki opisowe nad listboxami powiązane z listboxami
        {
            labels = new List<Label>(capturedAmount);
            for (int i = 0; i < capturedAmount; i++)
            {
                labels.Add(new Label());
                labels[i].Width = 300;
                labels[i].Height = 40;
                labels[i].BackColor = Color.Transparent;
                labels[i].ForeColor = Color.FromArgb(230, 63, 6);
                labels[i].Font = new Font("MS Sans Serif", Convert.ToInt32(X / 130), FontStyle.Bold | FontStyle.Italic);
                labels[i].Location = new Point(Convert.ToInt32((X / 5)), Convert.ToInt32((Y / 2.1)));
                labels[i].Text = "Trening " + (i + 1).ToString();
                this.Controls.Add(labels[i]);
                if (i > 0)
                {
                    labels[i].Hide();
                }
            }
            showRest();
        }
        private void showRest() //pokazuje reszte rzeczy 
        {
            btnSave.Show();
            lbTrainingAmount.Hide();
            comboTrainingAmount.Hide();
            lbTrainingAmountHelp.Hide();
            lbBodyPart.Show();
            lbExercise.Show();
            lbSerie.Show();
            comboBodyPart.Show();
            comboExercise.Show();
            comboSerieAmount.Show();
            btnAdd.Show();
            btnRemove.Show();
            btnDescription.Show();
            btnNextList.Show();
            BtnHint.Show();
        }
        private void btnSave_Click(object sender, EventArgs e) //zapisuje liste do pliku
        {  
            foreach (ListBox item in TrainingList)
            {
                if (item.Items.Count == 0)
                {
                    MessageBox.Show("Twój trening jest niekompletny! \nZapełnij wszystkie listy ćwiczeniami."); 
                    return;
                }
            }
            SaveToFile STF = new SaveToFile();
            int SaveIt = 1;
            STF.FileToDesktop(TrainingList.Select(l => l.Items), SaveIt);
        }
       
        private void btnDescription_Click(object sender, EventArgs e) //wybiera opis cwiczenia do wyświetlenia w zaleznosci od wyboru uzytkownika
        {
            FrError fr = new FrError();
            if (string.IsNullOrEmpty(comboExercise.Text))
            {
                MessageBox.Show("Nie wybrano ćwiczenia!"); 
                return;
            }
            if (comboBodyPart.SelectedIndex == 0)
            {
                fr.ShowMessage(DescriptionsShoulders.showDescription(comboExercise.SelectedIndex));
            }
            else if (comboBodyPart.SelectedIndex == 1)
            {
                fr.ShowMessage(DescriptionsArms.showDescription(comboExercise.SelectedIndex));
            }
            else if (comboBodyPart.SelectedIndex == 2)
            {
                fr.ShowMessage(DescriptionsBack.showDescription(comboExercise.SelectedIndex));
            }
            else if (comboBodyPart.SelectedIndex == 3)
            {
                fr.ShowMessage(DescriptionsChest.showDescription(comboExercise.SelectedIndex));
            }
            else if (comboBodyPart.SelectedIndex == 4)
            {
                fr.ShowMessage(DescriptionsAbs.showDescription(comboExercise.SelectedIndex));
            }
            else if (comboBodyPart.SelectedIndex == 5)
            {
                fr.ShowMessage(DescriptionsLegs.showDescription(comboExercise.SelectedIndex));
            }
            fr.Show(); fr.Focus();
        }

        private void comboBodyPart_SelectedIndexChanged(object sender, EventArgs e) //wypełnia combobox itemami w zaleznosci od wybranego indexu innego comboboxa
        {
            comboExercise.DataSource = ComboboxOptions.comboboxData(comboBodyPart.SelectedIndex);
        }
        private void btnNextList_Click(object sender, EventArgs e) //przewin listy do przodu, chowa przycisk 'poprzedni' gdy index =0 a 'następny' gdy dochodzi do końca listy
        {
            btnPrevList.Show();
            labels[whichTraining].Hide();
            TrainingList[whichTraining].Hide();
            whichTraining++;
            TrainingList[whichTraining].Show();
            labels[whichTraining].Show();
            if (whichTraining == TrainingList.Count - 1)
            {
                btnNextList.Hide();
            }
        }

        private void btnPrevList_Click(object sender, EventArgs e) //przewin listy do tylu, chowa przycisk 'poprzedni' gdy index =0 a 'nastepny' gdy dochodzi do konca listy
        {
            btnNextList.Show();
            TrainingList[whichTraining].Hide();
            labels[whichTraining].Hide();
            whichTraining--;
            TrainingList[whichTraining].Show();
            labels[whichTraining].Show();
            if (whichTraining == 0)
            {
                btnPrevList.Hide();
            }
        }
        private void btnNext_Click(object sender, EventArgs e) //tak samo przewija zdjęcia 
        {
            if (string.IsNullOrEmpty(comboExercise.Text))
            {
                MessageBox.Show("Nie wybrano ćwiczenia!");
                return;
            }
            whichPicture++;
            picbox.Image = imageList[whichPicture];
            btnPrevious.Show();
            if (whichPicture == imageList.Count - 1)
            {
                btnNext.Hide();
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e) //tak samo przewija zdjęcia 
        {
            if (string.IsNullOrEmpty(comboExercise.Text))
            {
               MessageBox.Show("Nie wybrano ćwiczenia!");
                return;
            }
            btnNext.Show();
            whichPicture--;
            picbox.Image = imageList[whichPicture];

            if (whichPicture < 1)
            {
                btnPrevious.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) //dodaje cwiczenie do listboxa
        {
            if (string.IsNullOrEmpty(comboExercise.Text) | string.IsNullOrEmpty(comboSerieAmount.Text))
            {
                MessageBox.Show("Nie wybrano ćwiczenia lub ilości serii!");
                return;
            }
            string tolist = comboExercise.Text + "    " + comboSerieAmount.Text + " serii";
            TrainingList[whichTraining].Items.Add(tolist);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            TrainingList[whichTraining].Items.Remove(TrainingList[whichTraining].SelectedItem);
        }
        private void comboExercise_SelectedIndexChanged(object sender, EventArgs e) //wypelnia picturebox listą obrazków gdy uzytkownik wybierze cos z comboboxa
        {
            picbox.Height = Convert.ToInt32(X / 2.8); picbox.Width = Convert.ToInt32(X / 3.5);
            whichPicture = 0;
            btnPrevious.Hide();
            SelectedImages SI = new SelectedImages();
            
            if (comboBodyPart.SelectedIndex == 0)
            {
                imageList = SI.Shoulders(comboExercise.SelectedIndex);
                picbox.Image = imageList[0];
            }
            else if (comboBodyPart.SelectedIndex == 1)
            {
                imageList = SI.Arms(comboExercise.SelectedIndex);
                picbox.Image = imageList[0];
            }
            else if (comboBodyPart.SelectedIndex == 2)
            {
                imageList = SI.Back(comboExercise.SelectedIndex);
                if (imageList[0].Width > 500)
                {
                    picbox.Height = Convert.ToInt32(X / 4); picbox.Width = Convert.ToInt32(X / 3.5);
                }
                picbox.Image = imageList[0];
            }
            else if (comboBodyPart.SelectedIndex == 3)
            {
                imageList = SI.Chest(comboExercise.SelectedIndex);
                picbox.Image = imageList[0];

            }
            else if (comboBodyPart.SelectedIndex == 4)
            {
                imageList = SI.ABS(comboExercise.SelectedIndex);
                if (imageList[0].Width>500)
                {
                    picbox.Height = Convert.ToInt32(X / 4); picbox.Width = Convert.ToInt32(X / 3.5);
                }
                picbox.Image = imageList[0];
            }
            else if (comboBodyPart.SelectedIndex == 5)
            {
                imageList = SI.Legs(comboExercise.SelectedIndex);
                picbox.Image = imageList[0];
            }
            if (imageList.Count != 1)
            {
                btnNext.Show();
            }
            else
            {
                btnNext.Hide();
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

        private void btnPrevious_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbScrollHelp.Show();
            }
        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            lbScrollHelp.Hide();
        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbScrollHelp.Show();
            }
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            lbScrollHelp.Hide();
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

        private void comboBodyPart_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbBodyPartHelp.Show();
            }
        }

        private void comboBodyPart_MouseLeave(object sender, EventArgs e)
        {
            lbBodyPartHelp.Hide();
        }

        private void comboExercise_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbExerciseHelp.Show();
            }
        }

        private void comboExercise_MouseLeave(object sender, EventArgs e)
        {
            lbExerciseHelp.Hide();
        }

        private void comboSerieAmount_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbSerieAmountHelp.Show();
            }
        }

        private void comboSerieAmount_MouseLeave(object sender, EventArgs e)
        {
            lbSerieAmountHelp.Hide();
        }

        private void btnDescription_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbDescriptionHelp.Show();
            }
        }

        private void btnDescription_MouseLeave(object sender, EventArgs e)
        {
            lbDescriptionHelp.Hide();
        }

        private void comboTrainingAmount_MouseHover(object sender, EventArgs e)
        {
            if (showTips == true)
            {
                lbTrainingAmountHelp.Show();
            }
        }

        private void comboTrainingAmount_MouseLeave(object sender, EventArgs e)
        {
            lbTrainingAmountHelp.Hide();
        }

    }
}
