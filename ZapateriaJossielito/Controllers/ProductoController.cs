using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Repository;

namespace ZapateriaJossielito.Controllers
{
    public class ProductoController : Controller
    {
        ProductosRepository productosRepository = new ProductosRepository();
        Productos productos = new Productos();

        EstilosRepository estilosRepository = new EstilosRepository();
        Estilos estilos = new Estilos();
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewProductos()
        {


            return View(productosRepository.ListDataProductos().AsEnumerable());

        }


        [HttpGet]
        public ActionResult Registrar()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Productos productos)
        {
            if (ModelState.IsValid /*&& productos.IdEstilo_FK == 0*/)
            {
                productosRepository.Create(productos);

                return Redirect("ViewProductos");
            }
            else
            {
                return View("Error");
                
            }
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult RegistradoExito()
        {

            return View();
        }
    }
}