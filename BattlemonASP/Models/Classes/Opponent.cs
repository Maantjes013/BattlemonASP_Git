using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlemonASP.Models.Classes
{
    public class Opponent
    {
        public string Name { get; private set; }
        public string trainerClass { get; private set; }

        public Opponent(string Name, string trainerClass)
        {
            this.Name = Name;
            this.trainerClass = trainerClass;
        }
        public Opponent()
        {

        }
    }
}
