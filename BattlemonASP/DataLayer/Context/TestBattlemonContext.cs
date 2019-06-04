using BattlemonASP.DataLayer.Repositories;
using BattlemonASP.DataLayer.Interfaces;
using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlemonASP.DataLayer.Context
{
    public class TestBattlemonContext : IBattlemonInterface
    {
        public void EditBattlemon(Battlemon battlemon)
        {
            throw new NotImplementedException();
        }

        public List<Battlemon> GetAllBattlemon()
        {
            throw new NotImplementedException();
        }

        public Attack GetAttack(int battlemonID)
        {
            throw new NotImplementedException();
        }

        public Attack GetAttackPower(string attackName)
        {
            throw new NotImplementedException();
        }

        public Battlemon GetBattlemonByID(int battlemonID)
        {
            Battlemon battlemon = new Battlemon();
            return battlemon;
        }

        public Battlemon GetBattlemonByName(string battlemonName)
        {
            throw new NotImplementedException();
        }
    }
}
