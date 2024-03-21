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
    public class Contatos1Controller : Controller
    {
        public IActionResult Contatos1()
        {
            ContatosModel contatos = new ContatosModel();

            contatos.Github = "https://github.com/mariialbano";
            contatos.Linkedin = "https://www.linkedin.com/in/mariana-albano-6a3051269/";

            return View(contatos);
        }
    }
}
