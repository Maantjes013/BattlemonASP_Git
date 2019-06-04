using BattlemonASP.Models.Classes;
using BattlemonASP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlemonASP.Converters
{
    public class OpponentViewModelConverter
    {
        public OpponentDetailViewModel ViewModelFromOpponent(Opponent opponent)
        {
            OpponentDetailViewModel vm = new OpponentDetailViewModel()
            {
                Name = opponent.Name,
                trainerClass = opponent.trainerClass,

            };
            return vm;
        }
    }
}
