﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Controllers
{
    public class DepartmentController : Controller
    {

        
        public IActionResult Index()
        {
            return View();
        }
    }
}
