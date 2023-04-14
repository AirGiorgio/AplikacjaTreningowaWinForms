using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD
{
    internal class SelectedImages: PictureList
    {
        List<Image> SplittedList = new List<Image>(); //pobiera obrazki z jednej wielkiej listy z resourców do mniejszej pokazującej konkretne ćwiczneie i zwraca do pictureboxa
        
        public List<Image> Shoulders(int index)
        {

            if (index == 0)
            {
                SplittedList = list().Skip(1).Take(2).ToList();
            }
            else if (index == 1)
            {
                SplittedList = list().Skip(3).Take(2).ToList(); 
            }
            else if (index == 2)
            {
                SplittedList = list().Skip(5).Take(4).ToList();  
            }
            else if (index == 3)
            {
                SplittedList = list().Skip(9).Take(2).ToList();  
            }
            else if (index == 4)
            {
                SplittedList = list().Skip(11).Take(3).ToList();  
            }
            else if (index == 5)
            {
                SplittedList = list().Skip(14).Take(4).ToList(); 
            }
            else if (index == 6)
            {
                SplittedList = list().Skip(18).Take(4).ToList();  
            }
            return SplittedList;
        }
        public List<Image> Legs(int index)
        {
 
            if (index == 0)
            {
                SplittedList = list().Skip(69).Take(4).ToList();
            }
            else if (index == 1)
            {
                SplittedList = list().Skip(73).Take(6).ToList();
            }
            else if (index == 2)
            {
                SplittedList = list().Skip(79).Take(3).ToList();
            }
            else if (index == 3)
            {
                SplittedList = list().Skip(82).Take(2).ToList();
            }
            else if (index == 4)
            {
                SplittedList = list().Skip(84).Take(4).ToList();
            }
            else if (index == 5)
            {
                SplittedList = list().Skip(88).Take(2).ToList();
            }
            else if (index == 6)
            {
                SplittedList = list().Skip(90).Take(4).ToList();
            }
            else if (index == 7)
            {
                SplittedList = list().Skip(94).Take(3).ToList();
            }
            else if (index == 8)
            {
                SplittedList = list().Skip(97).Take(3).ToList();
            }
            else if (index == 9)
            {
                SplittedList = list().Skip(100).Take(2).ToList();
            }

            return SplittedList;
        }
        public List<Image> Arms(int index)
        {   
            if (index == 0)
            {
                SplittedList = list().Skip(132).Take(2).ToList();
            }
            else if (index == 1)
            {
                SplittedList = list().Skip(134).Take(4).ToList();
            }
            else if (index == 2)
            {
                SplittedList = list().Skip(138).Take(2).ToList();
            }
            else if (index == 3)
            {
                SplittedList = list().Skip(140).Take(3).ToList();
            }
            else if (index == 4)
            {
                SplittedList = list().Skip(143).Take(3).ToList();
            }
            else if (index == 5)
            {
                SplittedList = list().Skip(146).Take(2).ToList();
            }
            else if (index == 6)
            {
                SplittedList = list().Skip(148).Take(2).ToList();
            }
            else if (index == 7)
            {
                SplittedList = list().Skip(150).Take(1).ToList();
            }
            else if (index == 8)
            {
                SplittedList = list().Skip(151).Take(4).ToList();
            }
            else if (index == 9)
            {
                SplittedList = list().Skip(155).Take(4).ToList();
            }
            else if (index == 10)
            {
                SplittedList = list().Skip(159).Take(2).ToList();
            }
            else if (index == 11)
            {
                SplittedList = list().Skip(161).Take(2).ToList();
            }
            else if (index == 12)
            {
                SplittedList = list().Skip(163).Take(4).ToList();
            }
            return SplittedList;

        }
        public List<Image> ABS(int index) 
        {
            if (index == 0)
            {
                SplittedList = list().Skip(22).Take(2).ToList();
            }
            else if (index == 1)
            {
                SplittedList = list().Skip(24).Take(3).ToList();
            }
            else if (index == 2)
            {
                SplittedList = list().Skip(27).Take(3).ToList();
            }
            else if (index == 3)
            {
                SplittedList = list().Skip(30).Take(2).ToList();
            }
            else if (index == 4)
            {
                SplittedList = list().Skip(32).Take(3).ToList();
            }
            else if (index == 5)
            {
                SplittedList = list().Skip(35).Take(2).ToList();
            }
            else if (index == 6)
            {
                SplittedList = list().Skip(37).Take(3).ToList();
            }
            else if (index == 7)
            {
                SplittedList = list().Skip(40).Take(2).ToList();
            }
            return SplittedList;
        }

        public List<Image> Back(int index)
        {
            if (index == 0)
            {
                SplittedList = list().Skip(102).Take(4).ToList();
            }
            else if (index == 1)
            {
                SplittedList = list().Skip(106).Take(4).ToList();
            }
            else if (index == 2)
            {
                SplittedList = list().Skip(110).Take(4).ToList();
            }
            else if (index == 3)
            {
                SplittedList = list().Skip(114).Take(4).ToList();
            }
            else if (index == 4)
            {
                SplittedList = list().Skip(120).Take(6).ToList();
            }
            else if (index == 5)
            {
                SplittedList = list().Skip(126).Take(4).ToList();
            }
            else if (index == 6)
            {
                SplittedList = list().Skip(130).Take(2).ToList();
            }
            return SplittedList;    
        }

        public List<Image> Chest(int index)
        {
            if (index == 0)
            {
                SplittedList = list().Skip(42).Take(4).ToList();
            }
            else if (index == 1)
            {
                SplittedList = list().Skip(46).Take(4).ToList();
            }
            else if (index == 2)
            {
                SplittedList = list().Skip(50).Take(4).ToList();
            }
            else if (index == 3)
            {
                SplittedList = list().Skip(54).Take(2).ToList();
            }
            else if (index == 4)
            {
                SplittedList = list().Skip(56).Take(2).ToList();
            }
            else if (index == 5)
            {
                SplittedList = list().Skip(58).Take(6).ToList();
            }
            else if (index == 6)
            {
                SplittedList = list().Skip(64).Take(3).ToList();
            }
            return SplittedList;
        }

    }
}
