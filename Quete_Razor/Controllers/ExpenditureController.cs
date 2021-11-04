using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quete_Razor.Models;

namespace Quete_Razor.Controllers
{
    public class ExpenditureController : Controller
    {
        public IActionResult Index()
        {
            List<Expenditure> expendlist = new List<Expenditure>
            {
                new Expenditure ("Iphone", new DateTime(2017,02,08), 890.90),
                new Expenditure ("Samsung", new DateTime(2018,05,10), 799.90),
                new Expenditure ("Xiaomi", new DateTime(2019,06,12), 570.50)
            };
            return View(expendlist);
        }
    }
}
