using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnicamAppelli.Modello;
using UnicamAppelli.Servizi;

namespace UnicamAppelli.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using(Database db = new Database()){
            List<Corso> listaCorsi = await db.Corsi.Include(corso => corso.Appelli).ToListAsync();
            return View(listaCorsi);
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
