using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattlemonASP.Models.Classes;

namespace BattlemonASP.DataLayer.Interfaces
{
    public interface IUserInterface
    {
        User Login(string username, string password);
        User Register(User user);
    }
}
