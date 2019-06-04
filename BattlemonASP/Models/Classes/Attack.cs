using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlemonASP.Models.Classes
{
    public class Attack
    {
        public string BattlemonName { get; set; }
        public string attack1Name { get; set; }
        public string attack2Name { get; set; }
        public string attack3Name { get; set; }
        public string attack4Name { get; set; }
        public int power { get; set; }

        public Attack(string battlemonName, string attack1Name, string attack2Name, string attack3Name, string attack4Name)
        {
            this.BattlemonName = battlemonName;
            this.attack1Name = attack1Name;
            this.attack2Name = attack2Name;
            this.attack3Name = attack3Name;
            this.attack4Name = attack4Name;
        }

        public Attack(int power)
        {
            this.power = power;
        }

        public Attack()
        {

        }
    }
}
