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
    public class PrivacyController : Controller
    {
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
