using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioWebCandidatos.Models;

namespace EjercicioWebCandidatos.Controllers
{
    public class CandidatosController : Controller
    {
        // GET: Candidatos
        public ActionResult Index()
        {
            return View(GetCandidatos());
        }

        public List<Candidatos> GetCandidatos()
        {
            return new List<Candidatos>
            {
                new Candidatos{Id = 1, Nombre = "El Bronco", Edad=54, Genero='H', Partido="Independiente"},
                new Candidatos{Id = 2, Nombre = "Anaya", Edad=35, Genero='H', Partido="PAN"},
                new Candidatos{Id = 3, Nombre = "Meade", Edad=45, Genero='H', Partido="PRI"},
                new Candidatos{Id = 4, Nombre = "AMLO", Edad=57, Genero='H', Partido="Morena"},
            };
        }

        public ActionResult Propuesta(int Id)
        {
            Candidatos PropuestaCandidato = null;

            foreach(var candidato in GetCandidatos())
            {
                if (candidato.Id == Id)
                {
                    PropuestaCandidato = candidato;
                }
            }

            if (PropuestaCandidato == null)
                return HttpNotFound();

            return View(PropuestaCandidato);
        }
    }
}