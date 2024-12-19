using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Levels
{
    public class LevelTwo : BaseLevel
    {
        public LevelTwo()
        {
            LevelDesign = new string[5, 5]
            {
                {"00","01","02","03","04"},
                {"10","11","12","13","14"},
                {"20","21","22","23","24"},
                {"30","31","32","33","34"},
                {"40","41","42","43","44"}
            };

            btnSize = 90;

            PosX = 140;
            PosY = 100;
        }
    }
}
