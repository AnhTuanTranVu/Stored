using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Oracle.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult AddNew()
        {
            return View();
        }
    }
}