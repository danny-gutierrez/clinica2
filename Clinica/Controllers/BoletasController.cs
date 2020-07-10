using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class BoletasController : Controller
    {
        // GET: boletas
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            Boleta boleta = new Boleta();
            return View(boleta);
        }

        [HttpPost]
        public ActionResult Create(Boleta boleta)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Boletas", new { id = 1 });
            }
            return View(boleta);
        }
        public ActionResult View(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Boleta boleta = new Boleta();
            return View(boleta);
        }

        [HttpPost]
        public ActionResult Edit(Boleta boleta)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Boletas", new { id = 1 });
            }
            return View(boleta);
        }
    }
}