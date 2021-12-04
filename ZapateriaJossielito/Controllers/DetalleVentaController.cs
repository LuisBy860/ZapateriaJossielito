using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Repository;

namespace ZapateriaJossielito.Controllers
{
    public class DetalleVentaController : Controller
    {

        DetallesVentasRepository detallesventasRepository = new DetallesVentasRepository();
        DetallesVentas detallesVentas = new DetallesVentas();
        // GET: DetalleVenta
        public ActionResult Index()
        {
            return View();
        }
        DetallesVentasRepository DetallesVentasRepository = new DetallesVentasRepository();
        DetallesVentas DetallesVentas = new DetallesVentas();

        VentasRepository detallesventaRepository = new VentasRepository();
        Ventas ventas = new Ventas();


        // GET: Venta
     
        public ActionResult ViewDetallesVentas()
        {


            return View(DetallesVentasRepository.ListDataDetallesVentas().AsEnumerable());

        }

        public ActionResult RegistrarDetalles()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarDetalles(DetallesVentas detallesventa)
        {
            try
            {
                DetallesVentas.IdDetalleVenta = 0;
                DetallesVentasRepository.Create(detallesventa);
            }
            catch
            {
                return View("Error");
            }
            return Redirect("ViewDetallesVentas");



        }
        public ActionResult ActualizarDetalles(int id)
        {

            var act = DetallesVentasRepository.ListDataDetallesVentas().OrderBy(s => s.IdDetalleVenta == id).ToList();
            var model = new DetallesVentas();
            foreach (var item in act)
            {


                model = new DetallesVentas
                {

                    IdDetalleVenta = item.IdDetalleVenta,
                    IdProducto_FK = item.IdProducto_FK,



                };

            }
            return View(model);
        }


        [HttpPost]
        public ActionResult ActualizarDetalles(DetallesVentas detallesventa)
        {

            if (ModelState.IsValid)
            {
                DetallesVentasRepository.Update(detallesventa);
                Ventas actualizar = new Ventas();
                return RedirectToAction("ViewDetallesVentas");
            }
            else
            {
                return View("ViewDetallesVentas", detallesventa);
            }
        }
   
        

        [HttpGet]
        public ActionResult DeleteDetallesVenta()
        {
            return View();
        }
        //ServicioDelete
        [HttpPost]
        public ActionResult DeleteDetallesVenta(DetallesVentas detalleventa)
        {
            try
            {

                DetallesVentasRepository.Delete(detalleventa);
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
        public ActionResult BorradoConExito()
        {
            return View();
        }
    }
}