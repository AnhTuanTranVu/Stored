﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Oracle.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserManagement()
        {
            return View();
        }
        public IActionResult AddNew()
        {
            return View();
        }
        public IActionResult EditUser()
        {
            return View();
        }
    }
}