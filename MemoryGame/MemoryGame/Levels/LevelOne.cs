using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Levels
{
    public class LevelOne:BaseLevel
    {
        public LevelOne()
        {
            LevelDesign = new string[4, 4]
            {
                {"00","01","02","03"},
                {"10","11","12","13"},
                {"20","21","22","23"},
                {"30","31","32","33"},
            };

            btnSize = 110;

            PosX = 140;
            PosY = 100;
        }
    }
}
