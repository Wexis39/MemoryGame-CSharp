using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Levels
{
    public class BaseLevel
    {
        public string[,] LevelDesign { get; set; }
        public int btnSize { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
    }
}
