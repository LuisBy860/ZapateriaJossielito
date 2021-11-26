﻿using System;
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

        public ActionResult ViewEstilo()
        {


            return View(estilosRepository.ListDataEstilos().AsEnumerable());

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
        public ActionResult ServicioDelete()
        {
            return View();
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

        public ActionResult Actualizar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Actualizar(Estilos estilo)
        {
            if (ModelState.IsValid)
            {
                //estilo.IdEstilo = 0;
                estilosRepository.Update(estilo);
                Estilos actualizar = new Estilos();
                //estilosRepository.Create(estilos);
                return Redirect("Error");
            }
            else { 
            return View("ViewEstilo", estilo);
            }
        }
    }
}
