using BattlemonASP.Models.ViewModels;
using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battlemon_ASP.Converters
{
    public class BattlemonViewModelConverter
    {
        public BattlemonDetailViewModel ViewModelFromBattlemon(Battlemon battlemon)
        {
            BattlemonDetailViewModel vm = new BattlemonDetailViewModel()
            {
                BattlemonID = battlemon.BattlemonID,
                Name = battlemon.Name,
                HealthPoints = battlemon.HealthPoints,
                Attack = battlemon.Attack,
                Defence = battlemon.Defence,
                Speed = battlemon.Speed,
                Type = battlemon.Type,
                Image = battlemon.Image,
                ImageBack = battlemon.ImageBack
            };
            return vm;
        }

        public Battlemon ViewModelToBattlemon(BattlemonDetailViewModel vm)
        {
            Battlemon battlemon = new Battlemon()
            {
                BattlemonID = vm.BattlemonID,
                Name = vm.Name,
                HealthPoints = vm.HealthPoints,
                Attack = vm.Attack,
                Defence = vm.Defence,
                Speed = vm.Speed,
                Type = vm.Type,
                Image = vm.Image,
                ImageBack = vm.ImageBack
            };
            return battlemon;
        }
    }
}

