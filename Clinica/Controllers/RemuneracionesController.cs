using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class RemuneracionesController : Controller
    {
        // GET: Remuneraciones
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            Remuneracion remuneracion = new Remuneracion();
            return View(remuneracion);     
        }

        [HttpPost]
        public ActionResult Create(Remuneracion remuneracion)
        {
            if (ModelState.IsValid)
            {
                //Guardo en base de datos
                //O mando Request a REST API
                return RedirectToAction("Index", "Remuneraciones");
            }

            return View(remuneracion);
        }


        public ActionResult View(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Remuneracion remuneracion = new Remuneracion();
            return View(remuneracion);
        }

        [HttpPost]
        public ActionResult Edit(Remuneracion remuneracion)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Edit", "Remuneraciones", new { id = 1 });
            }
            return View(remuneracion);
        }
    }
}