using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class TratamientosController : Controller
    {
        // GET: Pacientes
        public ActionResult Index()
        {
            return View();
        }

        //#######################################

        [HttpGet]
        public ActionResult Create()

        {
            Tratamiento tratamiento = new Tratamiento();

            return View(tratamiento);
        }

        [HttpPost]
        public ActionResult Create(Tratamiento tratamiento)
        {
            if (ModelState.IsValid)
            {
                //guarda en bd
                return RedirectToAction("Index", "Tratamientos", new { id = 1 });
            }

            return View(tratamiento);
        }


        //########################################################




        public ActionResult View(int id)
        {
            return View();
        }


        //###################################################

        [HttpGet]
        public ActionResult Edit(int id)
        {

            TratamientoEditar tratamientoeditar = new TratamientoEditar();
            return View(tratamientoeditar);
        }

        [HttpPost]
        public ActionResult Edit(TratamientoEditar tratamientoeditar)
        {
            if (ModelState.IsValid)
            {
                //guarda en bd
                return RedirectToAction("View", "Tratamientos", new { id = 1 });
            }

            return View(tratamientoeditar);
        }
    }
}