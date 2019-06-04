using Battlemon_ASP.Converters;
using BattlemonASP.DataLayer.Context;
using BattlemonASP.DataLayer.Repositories;
using BattlemonASP.Models.Classes;
using BattlemonASP.Converters;
using BattlemonASP.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattlemonASP.DataLayer.Interfaces;

namespace BattlemonASP.Controllers
{
    public class BattleController : Controller
    {
        IBattlemonInterface context;
        BattlemonRepo battlemonRepo;
        OpponentRepo opponentRepo;
        BattleDetailViewModel vm = new BattleDetailViewModel();
        BattleViewModelConverter bvmc = new BattleViewModelConverter();
        BattleSetter battleSetter = new BattleSetter();
        public double damage { get; set; }
        Random randomDamage = new Random();
        Random randomCrit = new Random();
        Random UserBattlemon;
        Random OpponentBattlemon;
        Random Opponent;

        public BattleController()
        {
            this.context = new BattlemonContext();
            battlemonRepo = new BattlemonRepo(context);
        }

        public IActionResult Battle()
        {
            Battlemon userBattlemon = new Battlemon();
            Battlemon opponentBattlemon = new Battlemon();

            if (HttpContext.Session.GetInt32("StartOfGame") == 0 || HttpContext.Session.GetInt32("StartOfGame") == null)
            {
                UserBattlemon = new Random();
                OpponentBattlemon = new Random();
                Opponent = new Random();
                int userBattlemonID = UserBattlemon.Next(1, 10);
                int opponentBattlemonID = OpponentBattlemon.Next(1, 10);
                int opponentID = Opponent.Next(1, 7);
                HttpContext.Session.SetString("UserBattlemon", JsonConvert.SerializeObject(battlemonRepo.GetBattlemonByID(userBattlemonID)));
                HttpContext.Session.SetString("OpponentBattlemon", JsonConvert.SerializeObject(battlemonRepo.GetBattlemonByID(opponentBattlemonID)));
                //HttpContext.Session.SetString("Opponent", JsonConvert.SerializeObject(opponentRepo.GetOpponentByID(opponentID)));

                HttpContext.Session.SetInt32("StartOfGame", 1);
            }

            userBattlemon = JsonConvert.DeserializeObject<Battlemon>(HttpContext.Session.GetString("UserBattlemon"));
            opponentBattlemon = JsonConvert.DeserializeObject<Battlemon>(HttpContext.Session.GetString("OpponentBattlemon"));
            Battle battle = battleSetter.FillBattle(userBattlemon, opponentBattlemon);
            vm = bvmc.ViewModelFromBattle(battle);
            HttpContext.Session.SetString("UserBattlemon", JsonConvert.SerializeObject(battle.UserBattlemon));
            HttpContext.Session.SetString("OpponentBattlemon", JsonConvert.SerializeObject(battle.OpponentBattlemon));

            if (HttpContext.Session.GetInt32("UserTurn") == 1)
            {
                OpponentDamage();
                HttpContext.Session.SetInt32("UserTurn", 2);
            }

            if (HttpContext.Session.GetInt32("UserTurn") == 2)
            {
                UserDamage();
                HttpContext.Session.SetInt32("UserTurn", 1);
            }
            return View(vm);
        }

        public IActionResult OpponentDamage()
        {
            Battlemon userBattlemon = JsonConvert.DeserializeObject<Battlemon>(HttpContext.Session.GetString("UserBattlemon"));
            Battlemon opponentBattlemon = JsonConvert.DeserializeObject<Battlemon>(HttpContext.Session.GetString("OpponentBattlemon"));
            battlemonRepo.OpponentDamage(userBattlemon, opponentBattlemon);
            HttpContext.Session.SetString("UserBattlemon", JsonConvert.SerializeObject(userBattlemon));
            HttpContext.Session.SetString("OpponentBattlemon", JsonConvert.SerializeObject(opponentBattlemon));
            return RedirectToAction("Battle", new { });
        }

        public IActionResult UserDamage()
        {
            Battlemon userBattlemon = JsonConvert.DeserializeObject<Battlemon>(HttpContext.Session.GetString("UserBattlemon"));
            Battlemon opponentBattlemon = JsonConvert.DeserializeObject<Battlemon>(HttpContext.Session.GetString("OpponentBattlemon"));
            battlemonRepo.UserDamage(userBattlemon, opponentBattlemon);
            HttpContext.Session.SetString("UserBattlemon", JsonConvert.SerializeObject(userBattlemon));
            HttpContext.Session.SetString("OpponentBattlemon", JsonConvert.SerializeObject(opponentBattlemon));
            return RedirectToAction("Battle", new { });
        }
    }
}
