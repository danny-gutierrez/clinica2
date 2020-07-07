using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class CitasController : Controller
    {
        // GET: Citas
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            Cita cita = new Cita();
            return View(cita);
        }

        [HttpPost]
        public ActionResult Create(Cita cita)
        {
            if (ModelState.IsValid)
            {
                //Guardo en base de datos
                //O mando Request a REST API
                return RedirectToAction("Index", "Citas", new { id = 1 });
            }

            return View(cita);
        }
        public ActionResult View(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            Cita cita = new Cita();
            return View(cita);
        }

        [HttpPost]
        public ActionResult Edit(Cita cita)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Edit", "Citas", new { id = 1 });
            }
            return View(cita);
        }


    }
}