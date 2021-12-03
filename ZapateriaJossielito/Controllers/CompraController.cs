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

        ComprasRepository comprasRepository = new ComprasRepository();
        Compras compras = new Compras();

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
        public ActionResult ViewCompra()
        {


            return View(comprasRepository.ListDataCompras().AsEnumerable());

        }

        [HttpGet]
        public ActionResult Registrar()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Compras compras)
        {
            comprasRepository.Create(compras);

            return Redirect("ViewCompra");
        }


        public ActionResult RegistradoExito()
        {

            return View();
        }

        [HttpGet]
        public ActionResult ServicioDelete(int id)
        {
            var act = comprasRepository.ListDataCompras().OrderBy(s => s.IdCompra == id).ToList();
            var model = new Compras();
            foreach (var item in act)
            {


                model = new Compras
                {

                    IdCompra = item.IdCompra,
                    Fecha = item.Fecha



                };

            }
            return View(model);
        }
        //ServicioDelete
        [HttpPost]
        public ActionResult ServicioDelete(Compras compras)
        {
            try
            {
                compras.IdCompra = 0;
                comprasRepository.Delete(compras);
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