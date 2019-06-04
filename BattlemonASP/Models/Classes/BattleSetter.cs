using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlemonASP.Models.Classes
{
    public class BattleSetter
    {
        Battle battle = new Battle();
        public Battle FillBattle(Battlemon userBattlemon, Battlemon opponentBattlemon, Opponent opponent)
        {
            battle.UserBattlemon = userBattlemon;
            battle.OpponentBattlemon = opponentBattlemon;
            battle.opponent = opponent;

            return battle;
        }
    }
}
