using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
    public class Dimentions : IDimentions
    {
        [Display(Name = "Number of cells in X dimention")]
        [Required(ErrorMessage = "Please Enter number of columns")]
        public int GameCellsX { get; set; } = 25;

        [Display(Name = "Number of cells in Y dimention")]
        [Required(ErrorMessage = "Please Enter number of rows")]
        public int GameCellsY { get; set; } = 25;

        [Display(Name = "Width of canvas in pixels")]
        public int Width { get; set; } = 600;

        [Display(Name = "Height of canvas in pixels")]
        public int Height { get; set; } = 600;
    }
}
