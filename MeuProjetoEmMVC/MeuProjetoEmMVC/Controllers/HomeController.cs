using MeuProjetoEmMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuProjetoEmMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Mariana Albano";
            home.Email = "marianatalbano@gmail.com";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contatos1()
        {
            ContatosModel contatos = new ContatosModel();

            contatos.Github = "https://github.com/mariialbano";
            contatos.Linkedin = "https://www.linkedin.com/in/mariana-albano-6a3051269/";

            return View(contatos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
