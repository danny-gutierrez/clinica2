using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class PacientesController : Controller
    {
        // GET: Pacientes
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            Paciente paciente = new Paciente();
            return View(paciente);
        }

        [HttpPost]
        public ActionResult Create(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Pacientes", new { id = 1 });
            }
            return View(paciente);
        }

        public ActionResult View(int id)
        {
            return View();
        }
       

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Paciente paciente = new Paciente();
            return View(paciente);
        }

        [HttpPost]
        public ActionResult Edit(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Edit", "Pacientes", new { id = 1 });
            }
            return View(paciente);
        }
    }
}