using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Levels
{
    public class LevelThree : BaseLevel
    {
        public LevelThree()
        {
            LevelDesign = new string[6, 6]
            {
                { "00", "01", "02", "03", "04", "05" },
                { "10", "11", "12", "13", "14", "15" },
                { "20", "21", "22", "23", "24", "25" },
                { "30", "31", "32", "33", "34", "35" },
                { "40", "41", "42", "43", "44", "45" },
                { "50", "51", "52", "53", "54", "55" }
            };

            btnSize = 75;

            PosX = 140;
            PosY = 100;
        }
    }
}
