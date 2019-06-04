using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace BattlemonASP.Controllers
{
    public class AuthDemoController: Controller
    {
        [Authorize(Roles = "Green")]
        public IActionResult MemberOnly()
        {
            return View();
        }

        [Authorize(Roles = "Bronze")]
        public IActionResult AdminOnly()
        {
            return View();
        }

        [Authorize]
        public IActionResult AuthenticatedOnly()
        {
            return View();
        }
    }
}
