using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Repository;

namespace ZapateriaJossielito.Controllers
{
    public class ZapatoController : Controller
    {

        EstilosRepository estilosRepository = new EstilosRepository();
        Estilos estilos = new Estilos();
        // GET: Zapato
        public ActionResult Index()
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
        public ActionResult Login()
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
        public ActionResult Descripcion()
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
        public ActionResult Registro()
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
        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Estilos estilos)
        {
            estilosRepository.Create(estilos);


            return Redirect ("/Zapato/Index");
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
           
            return View("Combobox");
        }
        public ActionResult Carrito()
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
    }
}