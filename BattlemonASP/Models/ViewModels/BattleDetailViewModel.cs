using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlemonASP.Models.ViewModels
{
    public class BattleDetailViewModel
    {
        public Battlemon UserBattlemon { get; set; }

        public Battlemon OpponentBattlemon { get; set; }
        public Opponent opponent { get; set; }
        public int userTurn { get; set; }
    }
}
