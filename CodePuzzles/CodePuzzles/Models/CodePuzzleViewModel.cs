using CodePuzzleBusinessServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CodePuzzles.Models
{
    /// <summary>
    /// Code puzzles view model
    /// </summary>
    public class CodePuzzleViewModel
    {
        [Description("What do you want me to draw?")]
        public string ShapeDescription { get; set; }
        public Shape Shape { get; set; }

    }
}