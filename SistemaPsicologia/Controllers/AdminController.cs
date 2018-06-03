using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SistemaPsicologia.Controllers
{

    public class AdminController : Controller
    {
        [Authorize(Roles = "Admin")]

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistroPsicologos()
        {
            

            return View("~/Views/RegistrarPsicologo/Create.cshtml");
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
        public IActionResult Familiar()
        {
            ViewData["Message"] = "FormatoFamiliar";

            return View("~/Views/Formatos/Familiar/TerapiaFamiliar.cshtml");
        }
        public IActionResult hojaEvolucion()
        {
            ViewData["Message"] = "hojaEvolucion";
            return View("~/Views/Formatos/hojaEvolucion.cshtml");

        }

        public IActionResult entrevistaParaAdultos()
        {
            ViewData["Message"] = "entrevistaParaAdultos";
            return View("~/Views/Formatos/entrevistaParaAdultos.cshtml");
        }

        public IActionResult datosPersonales()
        {
            ViewData["Message"] = "datosPersonales";
            return View("~/Views/Formatos/datosPersonales.cshtml");
        }
    }
}