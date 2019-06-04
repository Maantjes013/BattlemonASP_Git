using BattlemonASP.DataLayer.Context;
using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattlemonASP.DataLayer.Interfaces;

namespace BattlemonASP.DataLayer.Repositories
{ 
    public class UserTeamRepo
    {
        IUserTeamInterface context;

        public UserTeamRepo(IUserTeamInterface context)
        {
            this.context = context;
        }

        public UserTeamRepo()
        {
            context = new UserTeamContext();
        }

        public List<UserTeam> GetUserTeam()
        {
            return this.context.GetUserTeam();
        }

        public UserTeam NewUserTeam(UserTeam userteam)
        {
            return this.context.NewUserTeam(userteam);
        }
    }
}
