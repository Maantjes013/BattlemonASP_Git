using BattlemonASP.DataLayer.Context;
using BattlemonASP.DataLayer.Repositories;
using BattlemonASP.Converters;
using BattlemonASP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattlemonASP.DataLayer.Interfaces;

namespace BattlemonASP.Controllers
{
    public class OpponentController : Controller
    {
        IOpponentInterface context;
        OpponentRepo opponentRepo;
        OpponentViewModelConverter bvmc = new OpponentViewModelConverter();
        Random randomOpponent = new Random();
        int a;
        public OpponentController()
        {
            this.context = new OpponentContext();
            opponentRepo = new OpponentRepo(context);
        }

        public IActionResult GetOpponentByID(int id)
        {
            a = randomOpponent.Next(1, 7);
            id = a;
            OpponentDetailViewModel vm = bvmc.ViewModelFromOpponent(opponentRepo.GetOpponentByID(id));
            return View(vm);
        }
    }
}
