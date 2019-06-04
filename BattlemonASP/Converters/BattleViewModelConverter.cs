using BattlemonASP.Models.Classes;
using BattlemonASP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlemonASP.Converters
{
    public class BattleViewModelConverter
    {
        public BattleDetailViewModel ViewModelFromBattle(Battle battle)
        {
            BattleDetailViewModel vm = new BattleDetailViewModel()
            {
                UserBattlemon = battle.UserBattlemon,
                OpponentBattlemon = battle.OpponentBattlemon,
                opponent = battle.opponent  
            };
            return vm;
        }

        public Battle ViewModelToBattle(BattleDetailViewModel vm)
        {
            Battle battle = new Battle()
            {
                UserBattlemon = vm.UserBattlemon,
                OpponentBattlemon = vm.OpponentBattlemon,
                opponent = vm.opponent
            };
            return battle;
        }
    }
}
