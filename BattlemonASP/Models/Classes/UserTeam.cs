using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlemonASP.Models.Classes
{
    public class UserTeam
    {
        public int userID { get; set; }
        public string battlemon1 { get; set; }
        public string battlemon2 { get; set; }
        public string battlemon3 { get; set; }
        public string battlemon4 { get; set; }
        public string battlemon5 { get; set; }
        public string battlemon6 { get; set; }
        public int xp { get; set; }
        public int level { get; set; }


        public UserTeam(int userID, string battlemon1, string battlemon2, string battlemon3, string battlemon4, string battlemon5, string battlemon6, int xp, int level)
        {
            this.userID = userID;
            this.battlemon1 = battlemon1;
            this.battlemon2 = battlemon2;
            this.battlemon3 = battlemon3;
            this.battlemon4 = battlemon4;
            this.battlemon5 = battlemon5;
            this.battlemon6 = battlemon6;
            this.level = level;
            this.xp = xp;
        }
    }
}
