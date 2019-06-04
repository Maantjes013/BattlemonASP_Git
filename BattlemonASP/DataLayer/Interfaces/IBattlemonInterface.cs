using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlemonASP.DataLayer.Interfaces
{
    public interface IBattlemonInterface
    {
        List<Battlemon> GetAllBattlemon();
        Battlemon GetBattlemonByName(string battlemonName);
        Attack GetAttack(int battlemonID);
        Attack GetAttackPower(string attackName);
        Battlemon GetBattlemonByID(int battlemonID);
        void EditBattlemon(Battlemon battlemon);
    }
}
