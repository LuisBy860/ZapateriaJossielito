using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Repository;

namespace ZapateriaJossielito.Controllers
{
    public class EstiloController : Controller
    {
        EstilosRepository estilosRepository = new EstilosRepository();
        Estilos estilos = new Estilos();



        // GET: Estilo
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Estilos estilos)
        {
            estilosRepository.Create(estilos);
           
            return View("Index.cshtml");
        }

        public ActionResult RegistradoExito()
        {

            return View();
        }



        public ActionResult Combobox()
        {
            var informationEstilo = estilosRepository.ListDataEstilos();

            List<SelectListItem> ComboboxOfEstilos = new List<SelectListItem>();

            foreach (var iteracion in informationEstilo)
            {


                ComboboxOfEstilos.Add(new SelectListItem


                {
                    Text = iteracion.Nombre,
                    Value = Convert.ToString(iteracion.IdEstilo)
                }
      );
                ViewBag.listofestilocombobox = ComboboxOfEstilos;
            }
            return View();
        }

        [HttpPost]
        public ActionResult getcombo(Estilos e)
        {
            _ = e;
            return View("Combobox");
        }
    }
}
