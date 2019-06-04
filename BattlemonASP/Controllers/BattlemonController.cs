using Battlemon_ASP.Converters;
using BattlemonASP.DataLayer.Context;
using BattlemonASP.DataLayer.Repositories;
using BattlemonASP.Models.ViewModels;
using BattlemonASP.Models.Classes;
using BattlemonASP.Converters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattlemonASP.DataLayer.Interfaces;

namespace BattlemonASP.Controllers
{
    public class BattlemonController : Controller
    {
        IBattlemonInterface context;
        BattlemonRepo battlemonRepo;
        BattlemonViewModelConverter bvmc = new BattlemonViewModelConverter();
        AttackViewModelConverter avmc = new AttackViewModelConverter();
        public double damage { get; set; }

        //public BattlemonController(IBattlemonInterface context)
        //{
        //  this.context = context;
        //battlemonRepo = new BattlemonRepo(context);
        //}
        public BattlemonController()
        {
            this.context = new BattlemonContext();
            battlemonRepo = new BattlemonRepo(context);
        }

        public IActionResult Index()
        {
            List<Battlemon> monList = battlemonRepo.GetAllBattlemon();
            BattlemonViewModel vm = new BattlemonViewModel()
            {
                BvmList = new List<BattlemonDetailViewModel>()
            };


            foreach (Battlemon c in monList)
            {
                vm.BvmList.Add(bvmc.ViewModelFromBattlemon(c));
            }

            return View(vm);
        }

        public IActionResult BattlemonInfo(int id)
        {
            BattlemonDetailViewModel vm = bvmc.ViewModelFromBattlemon(battlemonRepo.GetBattlemonByID(id));
            return View(vm);
        }

        public IActionResult GetAttack(int id)
        {
            AttackDetailViewModel vm = avmc.ViewModelFromAttack(battlemonRepo.GetAttack(id));
            return View("AttackPartial", vm);
        }

        [HttpGet]
        public IActionResult EditBattlemon(int id)
        {
            Battlemon battlemon = battlemonRepo.GetBattlemonByID(id);
            BattlemonDetailViewModel vm = bvmc.ViewModelFromBattlemon(battlemon);
            return View(vm);
        }

        [HttpPost]
        public IActionResult EditBattlemon(BattlemonDetailViewModel vm)
        {
            Battlemon battlemon = bvmc.ViewModelToBattlemon(vm);
            battlemonRepo.EditBattlemon(battlemon);
            return RedirectToAction("BattlemonInfo", new { id = battlemon.BattlemonID });
        }
    }
}

