using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlemonASP.Models.Classes
{
    public class Battlemon
    {
        public int BattlemonID { get; set; }
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string ImageBack { get; set; }

        public Battlemon(int BattlemonID, string Name, int HealthPoints, int Attack, int Defence, int Speed, string Type, string Image, string ImageBack)
        {
            this.BattlemonID = BattlemonID;
            this.Name = Name;
            this.HealthPoints = HealthPoints;
            this.Attack = Attack;
            this.Defence = Defence;
            this.Speed = Speed;
            this.Type = Type;
            this.Image = Image;
            this.ImageBack = ImageBack;
        }

        public Battlemon()
        {

        }
    }

}
