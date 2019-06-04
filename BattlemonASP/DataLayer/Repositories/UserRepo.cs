//using Battlemon_ASP.DataLayer.Context;
//using Battlemon_ASP.DataLayer.Interfaces;
//using Battlemon_ASP.NET.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Battlemon_ASP.DataLayer.Repositories
//{
//    class UserRepo
//    {
//        IUserInterface context;

//        public UserRepo(IUserInterface context)
//        {
//            this.context = context;
//        }

//        public UserRepo()
//        {
//            context = new UserContext();
//        }

//        public User Login(string username, string password)
//        {
//            return this.context.Login(username, password);
//        }

//        public User Register(User account)
//        {
//            return context.Register(account);
//        }
//    }
//}
