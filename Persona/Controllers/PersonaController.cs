using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persona.Models;

namespace Persona.Controllers
{
    public class PersonaController: Controller
    {
        private PersonaContext _context;

        public PersonaController(PersonaContext context)
        {
            _context = context;

        }

        [HttpGet]
        public ActionResult Cuenta()
        {
            var persons = _context.Person.ToList();
            return View("Cuenta",persons);
        }

        [HttpGet]
        public ActionResult Registro()
        {
            return View("Registro", new Person());
        }

        [HttpPost]
        public ActionResult Registro(Person persons) // POST
        {


            if (ModelState.IsValid)
            {
                _context.Person.Add(persons);
                _context.SaveChanges();
                return RedirectToAction("Registro");
            }

            return View("Registro", persons);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Types = new List<string> { "Nombre", "Apellido", "Fecha", "DNI", "Sexo", "Ciuidad", "Direccion", "Correo", "Username", "Contraseña" };
            var persons = _context.Person.Where(o => o.Id == id).FirstOrDefault(); 

            return View("Edit", persons);
        }

        [HttpPost]
        public ActionResult Edit(Person persons)
        {
            
            if (ModelState.IsValid)
            {
                _context.Person.Update(persons);
                _context.SaveChanges();
                return RedirectToAction("Registro");
            }
            ViewBag.Person = persons;
            return View("edit");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var persons = _context.Person.Where(o => o.Id == id).FirstOrDefault();
            _context.Person.Remove(persons);
            _context.SaveChanges();
            return RedirectToAction("Registro");
        }
    }
}
