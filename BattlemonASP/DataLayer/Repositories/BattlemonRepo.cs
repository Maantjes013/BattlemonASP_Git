using BattlemonASP.DataLayer.Interfaces;
using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlemonASP.DataLayer.Repositories
{
    public class BattlemonRepo
    {
        IBattlemonInterface context;
        public double damage { get; set; }
        Random randomDamage = new Random();
        Random randomCrit = new Random();

        public BattlemonRepo(IBattlemonInterface context)
        {
            this.context = context;
        }

        public List<Battlemon> GetAllBattlemon()
        {
            return context.GetAllBattlemon();
        }

        public Battlemon GetBattlemonByName(string battlemonName)
        {
            return context.GetBattlemonByName(battlemonName);
        }

        public Attack GetAttack(int battlemonID)
        {
            return context.GetAttack(battlemonID);
        }

        public Attack GetAttackPower(string attackName)
        {
            return context.GetAttackPower(attackName);
        }

        public Battlemon GetBattlemonByID(int battlemonID)
        {
            return context.GetBattlemonByID(battlemonID);
        }

        public void EditBattlemon(Battlemon battlemon)
        {
            context.EditBattlemon(battlemon);
        }

        public bool StabChecker(Battlemon userBattlemon, Attack userAttack)
        {
            if (userBattlemon.Type.Contains("Steel"))
            {
                return true;
            }

            else return false;
        }

        public void UserDamage(Battlemon userBattlemon, Battlemon opponentBattlemon)
        {
            if (opponentBattlemon.HealthPoints > 0)
            {
                int a = randomDamage.Next(85, 101);
                damage = ((((2 * 30 / 5 + 2) * opponentBattlemon.Attack * 60 / userBattlemon.Defence) / 50) + 2) * 1.5 * 1 / 1 * a / 100;

                if (a == 88)
                {
                    damage = damage * 1.5;
                }
                userBattlemon.HealthPoints = userBattlemon.HealthPoints - Convert.ToInt32(damage);

                if (userBattlemon.HealthPoints <= 0)
                {
                    userBattlemon.HealthPoints = 0;
                }
            }
        }

        public void OpponentDamage(Battlemon userBattlemon, Battlemon opponentBattlemon)
        {
            if (userBattlemon.HealthPoints > 0)
            {
                int a = randomDamage.Next(85, 101);
                damage = ((((2 * 30 / 5 + 2) * userBattlemon.Attack * 60 / opponentBattlemon.Defence) / 50) + 2) * 1.5 * 1 / 1 * a / 100;

                if (a == 88)
                {
                    damage = damage * 1.5;
                }
                opponentBattlemon.HealthPoints = opponentBattlemon.HealthPoints - Convert.ToInt32(damage);

                if (opponentBattlemon.HealthPoints <= 0)
                {
                    opponentBattlemon.HealthPoints = 0;
                }
            }
        }
    }
}
