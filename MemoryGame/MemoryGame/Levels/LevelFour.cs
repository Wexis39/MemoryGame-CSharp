using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Levels
{
    public class LevelFour : BaseLevel
    {
        public LevelFour()
        {
            LevelDesign = new string[7, 7]
            {
                { "00", "01", "02", "03", "04", "05" , "06"},
                { "10", "11", "12", "13", "14", "15" , "16"},
                { "20", "21", "22", "23", "24", "25" , "26"},
                { "30", "31", "32", "33", "34", "35" , "36"},
                { "40", "41", "42", "43", "44", "45" , "46"},
                { "50", "51", "52", "53", "54", "55" , "56"},
                { "60", "61", "62", "63", "64", "65" , "66"}
            };

            btnSize = 65;

            PosX = 140;
            PosY = 100;
        }
    }
}
