using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlemonASP.Models.Classes
{
    public class Battle
    {
        public Battlemon UserBattlemon { get; set; }
        public Battlemon OpponentBattlemon { get; set; }
        public Opponent opponent { get; set; }
    }
}
