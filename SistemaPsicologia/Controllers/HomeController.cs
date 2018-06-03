using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaPsicologia.Models;

namespace SistemaPsicologia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Acerca()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        
        public IActionResult FormatoParejas()
        {
            ViewData["Message"] = "Formato de parejas";

            return View("~/Views/Formatos/FormatoParejas/FormatoParejas.cshtml");
        }

        public IActionResult RegistroPacientes()
        {
            ViewData["Message"] = "RegistroPacientes";

            return View("~/Views/Pacientes/RegistroPacientes.cshtml");
        }
        public IActionResult Hoja1()
        {
            ViewData["Message"] = "Hoja1";

            return View("~/Views/Formatos/FormatoParejas/Hoja1.cshtml");
        }

        public IActionResult Hoja2()
        {
            ViewData["Message"] = "Hoja2";

            return View("~/Views/Formatos/FormatoParejas/Hoja2.cshtml");
        }

        public IActionResult Familiar()
        {
            ViewData["Message"] = "FormatoFamiliar";

            return View("~/Views/Formatos/Familiar/TerapiaFamiliar.cshtml");
        }


        public IActionResult RegistroPsicologo()
        {
            ViewData["Message"] = "RegistroPsicologo";

            return View("~/Views/Account/Register.cshtml");
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
