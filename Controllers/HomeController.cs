using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnicamAppelli.Modello;
using UnicamAppelli.Modello.Richieste;
using UnicamAppelli.Servizi;

namespace UnicamAppelli.Controllers
{
    public class HomeController : Controller
    {
        private IServizioCorsi servizioCorsi;
        public HomeController(IServizioCorsi servizioCorsi)
        {
            this.servizioCorsi=servizioCorsi;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Corso> listaCorsi = await servizioCorsi.Elenca();
            return View(listaCorsi);
        }
        [HttpGet]
        public IActionResult Nuovo(){
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Nuovo(CreazioneCorso corso){
            if (ModelState.IsValid){
                Corso nuovo = new Corso(corso.Nome, corso.Docente);
                await servizioCorsi.Crea(nuovo);
            return Redirect("Index");
            }
            return View(corso);
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
