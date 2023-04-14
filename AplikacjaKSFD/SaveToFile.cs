using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AplikacjaKSFD
{
    internal class SaveToFile
    {
        public void FileToDesktop(IEnumerable<ListBox.ObjectCollection> list, int SaveIt) //uniwersalny zapis do pliku wywoływany z klas Frtraining i Frdiet, zapisuje diete i trening
        {
            string DietOrTraining = "Trening";
            string MealOrExercise = "Trening";

            if (SaveIt == 0)
            {
                DietOrTraining = "Dieta";
                MealOrExercise = "Posiłek";
            }

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\"+ DietOrTraining + " KSFD.txt";
            StreamWriter SW = new StreamWriter(filePath);

            try
            {
                int i = 1;
                foreach (var item in list)
                {            
                    SW.WriteLine(MealOrExercise +" "+ (i).ToString());
                    
                    foreach (var element in item)
                    {
                        SW.WriteLine(element);
                    }
                    i++;
                }
            }
            catch (IOException)
            {
                throw new Exception("Wystąpił błąd przy zapisie do pliku!");
            }
            finally
            {
                SW.Close();
            }
            MessageBox.Show("Zapisano na pulpicie pod nazwą " + DietOrTraining + " KSFD!");
        }
    }
}
