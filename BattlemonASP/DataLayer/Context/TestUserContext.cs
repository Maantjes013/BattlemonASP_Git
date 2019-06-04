using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BattlemonASP.Models.Classes;
using BattlemonASP.DataLayer;
using System.Data;
using Microsoft.AspNetCore.Authentication;

namespace BattlemonASP.DataLayer.Context
{
    public class TestUserContext : BaseMSSQL
    {
        public bool Login(User user)
        {
            if (user.email == "Iets@iets.com" && user.password == "Iets.1")
            {
                return true;
            }
            else return false;
        }
    }
}
