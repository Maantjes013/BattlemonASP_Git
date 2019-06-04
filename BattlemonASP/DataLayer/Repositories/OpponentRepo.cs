using BattlemonASP.DataLayer.Interfaces;
using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlemonASP.DataLayer.Repositories
{
    public class OpponentRepo
    {
        IOpponentInterface context;

        public OpponentRepo(IOpponentInterface context)
        {
            this.context = context;
        }

        public Opponent GetOpponentByID(int opponentID)
        {
            return context.GetOpponentByID(opponentID);
        }
    }
}

