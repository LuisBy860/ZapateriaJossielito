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
        public ActionResult Registrar(Productos producto)
        {
            try
            {
                estilos.IdEstilo = 0;
                productosRepository.Create(producto);
            }
            catch
            {
                return View("Error");
            }
            return Redirect("ViewProductos");


            //if (ModelState.IsValid /*&& productos.IdEstilo_FK == 0*/)
            //{
            //    estilos.IdEstilo = 0;
            //    productosRepository.Create(productos);
            //    return View("ViewProductos");
            //}
            //else
            //{
            //    return View("Error");
            //}
        }


      
        public ActionResult Actualizar(int id)
        {

            var act = productosRepository.ListDataProductos().OrderBy(s => s.IdProducto == id).ToList();
            var model = new Productos();
            foreach (var item in act)
            {


                model = new Productos
                {

                    IdProducto = item.IdProducto,
                    Nombre = item.Nombre,
                    Descripcion = item.Descripcion,
                    Precio = item.Precio,
                    Talla = item.Talla,
                    Color = item.Color,
                    Existencias = item.Existencias,
                   IdEstilo_FK = item.IdEstilo_FK



                };

            }
            return View(model);
        }


        [HttpPost]
        public ActionResult Actualizar(Productos producto)
        {

            if (ModelState.IsValid)
            {
                productosRepository.Update(producto);
                Productos actualizar = new Productos();
                return RedirectToAction("ViewProductos");
            }
            else
            {
                return View("ViewProductos", producto);
            }
        }



        //if (ModelState.IsValid)
        //{
        //    productosRepository.Update(producto);
        //    Productos actualizar = new Productos();
        //    return Redirect("Error");
        //}
        //else
        //{
        //    return View("ViewEstilo", producto);
        //}


        [HttpGet]
        public ActionResult ServicioDelete()
        {
            return View();
        }
        //ServicioDelete
        [HttpPost]
        public ActionResult ServicioDelete(Productos producto)
        {
            try
            {

               productosRepository.Delete(producto);
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

        public ActionResult RegistradoExito()
        {

            return View();
        }
    }
}