using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Repository;

namespace ZapateriaJossielito.Controllers
{
    public class VentaController : Controller
    {
        VentasRepository ventasRepository = new VentasRepository();
        Productos productos = new Productos();

        VentasRepository ventaRepository = new VentasRepository();
        Ventas ventas = new Ventas();

        ComprasRepository ComprasRepository = new ComprasRepository();
        Compras Compras = new Compras();
        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Carrito()
        {
            return View();
        }

        public ActionResult ViewVentas()
        {


            return View(ventasRepository.ListDataVentas().AsEnumerable());

        }

       public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Ventas venta)
        {
            try
            {
                venta.IdVenta = 0;
                ventasRepository.Create(venta);
            }
            catch
            {
                return View("Error");
            }
            return Redirect("ViewVentas");


          
        }
        public ActionResult Actualizar(int id)
        {

            var act = ventaRepository.ListDataVentas().OrderBy(s => s.IdVenta == id).ToList();
            var model = new Ventas();
            foreach (var item in act)
            {


                model = new Ventas
                {

                    IdVenta = item.IdVenta,
                    IdUsuario_FK = item.IdUsuario_FK,
                 


                };

            }
            return View(model);
        }


        [HttpPost]
        public ActionResult Actualizar(Ventas venta)
        {

            if (ModelState.IsValid)
            {
                ventasRepository.Update(venta);
                Ventas actualizar = new Ventas();
                return RedirectToAction("ViewVentas");
            }
            else
            {
                return View("ViewVentas", venta);
            }
        }


        [HttpGet]
        public ActionResult DeleteVenta()
        {
            return View();
        }
        //ServicioDelete
        [HttpPost]
        public ActionResult DeleteVenta(Ventas venta)
        {
            try
            {

                ventasRepository.Delete(venta);
            }
            catch
            {
                return View("Error");
            }
            return View("BorradoConExito");
        }


        public ActionResult Error()
        {
            return View();
        }


    }
}