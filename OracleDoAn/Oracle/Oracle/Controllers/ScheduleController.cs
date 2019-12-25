using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Oracle.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult ScheduleManagement()
        {
            return View();
        }
        public IActionResult AddNew()
        {
            return View();
        }
    }
}