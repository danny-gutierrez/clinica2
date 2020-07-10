﻿using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class PacientesController : Controller
    {
        private ClinicaContext _db;
       
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Paciente> pacientes = null;
            using (_db =new ClinicaContext())
            {
                pacientes = _db.Pacientes.ToList();
            }
            return View(pacientes);
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
                return RedirectToAction("Index", "Pacientes", new { id = 1 });
            }
            return View(paciente);
        }

        public ActionResult View(int id)
        {
            Paciente p = null;
            using (_db =new ClinicaContext())
            {
                p = _db.Pacientes.Find(id);
            }
            return View(p);
        }
       

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Paciente p = null;
            using (_db = new ClinicaContext())
            {
                p = _db.Pacientes.Find(id);
            }
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Pacientes", new { id = 1 });
            }
            return View(paciente);
        }
    }
}