using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ejercicioASP.Models;

namespace ejercicioASP.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            Persona persona = new Persona();
            persona.Nombre = "Julio";
            persona.Id = 123;
            persona.Edad = 27;
            persona.Genero = 'H';

            return View(persona);
        }
    }
}