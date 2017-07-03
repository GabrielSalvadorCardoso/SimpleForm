using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleForm.Models;

namespace SimpleForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Lista()
        {
            ICollection<Comentario> lista = new List<Comentario>();

            using(SimpleFormContext context = new SimpleFormContext())
            {
                foreach(Comentario c in context.Comentarios)
                {
                    lista.Add(c);
                }
            }

            return View(lista);
        }

        public ActionResult Persistir(Comentario c)
        {
            using (SimpleFormContext context = new SimpleFormContext())
            {
                context.Comentarios.Add(c);
                context.SaveChanges();
            }
            return RedirectToAction("Lista", "Home");
        }
    }
}