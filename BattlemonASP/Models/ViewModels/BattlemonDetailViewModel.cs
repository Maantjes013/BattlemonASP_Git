using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlemonASP.Models.ViewModels
{
    public class BattlemonDetailViewModel
    {
        public int BattlemonID { get; set; }
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string ImageBack { get; set; }
    }
}
