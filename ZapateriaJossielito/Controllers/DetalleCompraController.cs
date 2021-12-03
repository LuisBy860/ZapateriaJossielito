using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Repository;

namespace ZapateriaJossielito.Controllers
{
    public class DetalleCompraController : Controller
    {
        
        ComprasRepository comprasRepository = new ComprasRepository();
        Compras compras = new Compras();

        DetallesComprasRepository DetallesComprasRepository = new DetallesComprasRepository();
        DetallesCompras DetallesCompras = new DetallesCompras();

        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewDetalleCompra()
        {


            return View(DetallesComprasRepository.ListDataDetallesCompras().AsEnumerable());

        }


        [HttpGet]
        public ActionResult Registrar()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Registrar(DetallesCompras DetallesCompras)
        {
            DetallesComprasRepository.Create(DetallesCompras);

            return Redirect("ViewDetalleCompra");
        }


        public ActionResult RegistradoExito()
        {

            return View();
        }

        [HttpGet]
        public ActionResult ServicioDelete(int id)
        {
            var act = DetallesComprasRepository.ListDataDetallesCompras().OrderBy(s => s.IdDetalleCompra == id).ToList();
            var model = new DetallesCompras();
            foreach (var item in act)
            {

                model = new DetallesCompras
                {

                    IdDetalleCompra = item.IdDetalleCompra,
                    Cantidad = item.Cantidad,
                    IdProducto_FK = item.IdProducto_FK,
                    IdCompra_FK = item.IdCompra_FK



                };

            }
            return View(model);
        }
        //ServicioDelete
        [HttpPost]
        public ActionResult ServicioDelete(DetallesCompras IdDetalleCompra)
        {
            try
            {
                IdDetalleCompra.IdDetalleCompra = 0;
                DetallesComprasRepository.Delete(IdDetalleCompra);
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