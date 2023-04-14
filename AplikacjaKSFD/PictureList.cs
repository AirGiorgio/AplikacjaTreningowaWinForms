using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD
{
    public class PictureList
    {

        List<Image> ImageList; //pobranie z resourców obrazków i przekształcenie ich w słownik uporządkowany wg nazwy, a następnie przekonwertowanie do listy
        protected void listofImages()
        {

            Dictionary<string, Image> pictureList = new Dictionary<string, Image>();

            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
        
            foreach (DictionaryEntry item in resourceSet)
	        {
                if (item.Value is Bitmap)
                {
                    pictureList.Add(item.Key as string, item.Value as Image);
                }
            }

            Dictionary<string, Image> Selectpictures  = new Dictionary<string, Image>();
            Selectpictures = pictureList.OrderBy(x => x.Key).ToDictionary(x => x.Key, o => o.Value);

            ImageList = new List<Image>();
            ImageList = Selectpictures.Values.ToList();
        }

        public List<Image> list()
        {
            listofImages();
            return ImageList;
        }
   
    }

}

