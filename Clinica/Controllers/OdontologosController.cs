using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinica.Models;

namespace Clinica.Controllers
{
    public class OdontologosController : Controller
    {
        // GET: Odontologos

        public ActionResult Index()
        {
            return View();
        }

        //########################################################

        [HttpGet]
        public ActionResult Create()
        {
            Odontologo odontologo = new Odontologo();

            return View(odontologo);


        }



        [HttpPost]
        public ActionResult Create(Odontologo odontologo)
        {
            if (ModelState.IsValid)
            {
                //guarda en bd
                return RedirectToAction("Index", "Odontologos", new { id = 1 });
            }

            return View(odontologo);
        }

        //#####################################################



        public ActionResult View(int id)
        {
            return View();
        }





        [HttpGet]
        public ActionResult Edit(int id)
        {
            OdontologoEditar odontologoeditar = new OdontologoEditar();
            return View(odontologoeditar);
        }

        [HttpPost]
        public ActionResult Edit(OdontologoEditar odontologoeditar)
        {

            if (ModelState.IsValid)
            {
                //guarda en bd
                return RedirectToAction("View", "Odontologos", new { id = 1 });
            }

            return View(odontologoeditar);


        }
    }
}