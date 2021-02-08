using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
    public class Dimentions : IDimentions
    {
        [Display(Name = "X Cells")]
        [Required(ErrorMessage = "Please Enter number of columns")]
        public int GameCellsX { get; set; } = 25;

        [Display(Name = "Y Cells")]
        [Required(ErrorMessage = "Please Enter number of rows")]
        public int GameCellsY { get; set; } = 25;

        [Display(Name = "Width px")]
        public int Width { get; set; } = 600;

        [Display(Name = "Height px")]
        public int Height { get; set; } = 600;
    }
}
