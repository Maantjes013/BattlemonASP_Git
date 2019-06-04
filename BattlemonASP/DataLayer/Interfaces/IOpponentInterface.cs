using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlemonASP.DataLayer.Interfaces
{
    public interface IOpponentInterface
    {
        Opponent GetOpponentByID(int opponentID);
    }
}
