using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tortuguita.Models;
using System.Text;
using System.Threading;

namespace tortuguita.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public String iniciar()
        {


            tortuga tortuga_obj = new tortuga(10);
            Thread tortuga1 = new Thread(tortuga_obj.tortugacorriendo);
            tortuga1.Priority = ThreadPriority.Highest;


            liebre liebre_obj = new liebre(10);
            Thread liebre1 = new Thread(liebre_obj.liebrecorriendo);
            liebre1.Priority = ThreadPriority.Highest;

            tortuga1.Start();
            liebre1.Start();
            Console.ReadKey();


            return "funciona";


        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
