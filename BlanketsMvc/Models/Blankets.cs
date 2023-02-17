using System;
using System.ComponentModel.DataAnnotations;

namespace BlanketsMvc.Models
{
    public class Blankets
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Pattern { get; set; }
        public string Weight { get; set; }
        public string Material { get; set; }
    }
}
