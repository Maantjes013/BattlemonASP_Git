using BattlemonASP.Models.Classes;
using BattlemonASP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlemonASP.Converters
{
    public class AttackViewModelConverter
    {
        public AttackDetailViewModel ViewModelFromAttack(Attack attack)
        {
            AttackDetailViewModel vm = new AttackDetailViewModel()
            {
                name = attack.BattlemonName,
                attack1 = attack.attack1Name,
                attack2 = attack.attack2Name,
                attack3 = attack.attack3Name,
                attack4 = attack.attack4Name

            };
            return vm;
        }
    }
}
