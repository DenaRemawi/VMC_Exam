using HR.Models;
using HR.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Controllers
{
    public class EmployeeController : Controller
    {
        IConfiguration _iConfiguration;
        IEmployee _Employee;
        Idepartment deptt;
        Icountry Icountri;
        public EmployeeController(IConfiguration configuration , IEmployee employee , Idepartment dept, Icountry icountry)
        {
            _iConfiguration = configuration;
            _Employee = employee;
            deptt = dept;
            Icountri = icountry;
        }
        public IActionResult Index(Vmemployee Vm)
        {
            return View("EmployeeView",Vm);
        }


        public IActionResult savedata(Vmemployee Vm)
        {
            return View("EmployeeView", Vm);
        }
        


    }
}
