using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
    interface IDimentions
    {
        public int GameCellsX { get; set; }
        public int GameCellsY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
