using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var produtos = new Produtos();
            return View(produtos);
        }
        [HttpPost]
        public ActionResult Index(Produtos produtos)
        {
            if(ModelState.IsValid)
            {
                return View("Resultado", produtos);
            }
            return View(produtos);
        }

        public ActionResult Resultado(Produtos produtos)
        {
            return View(produtos);
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
    }
}