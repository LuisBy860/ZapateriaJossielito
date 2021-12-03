using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Repository;

namespace ZapateriaJossielito.Controllers
{
    public class CompraController : Controller
    {
        ProductosRepository productosRepository = new ProductosRepository();
        Productos productos = new Productos();

        EstilosRepository estilosRepository = new EstilosRepository();
        Estilos estilos = new Estilos();

        ComprasRepository ComprasRepository = new ComprasRepository();
        Compras Compras = new Compras();

        // GET: Venta
        public ActionResult Index()
        {
            return View();
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

        [HttpGet]
        public ActionResult Registrar()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Estilos estilos)
        {
            estilosRepository.Create(estilos);

            return Redirect("ViewEstilo");
        }


        public ActionResult RegistradoExito()
        {

            return View();
        }

        [HttpGet]
        public ActionResult ServicioDelete(int id)
        {
            var act = estilosRepository.ListDataEstilos().OrderBy(s => s.IdEstilo == id).ToList();
            var model = new Estilos();
            foreach (var item in act)
            {


                model = new Estilos
                {

                    IdEstilo = item.IdEstilo,
                    Nombre = item.Nombre



                };

            }
            return View(model);
        }
        //ServicioDelete
        [HttpPost]
        public ActionResult ServicioDelete(Estilos estilo)
        {
            try
            {
                estilos.IdEstilo = 0;
                estilosRepository.Delete(estilo);
            }
            catch
            {
                return Redirect("Error");
            }
            return View("BorradoConExito");
        }




        public ActionResult BorradoConExito()
        {

            return View();
        }

        public ActionResult Error()
        {
            return View();
        }






    }
}