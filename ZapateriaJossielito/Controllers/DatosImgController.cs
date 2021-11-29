using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZapateriaJossielito.Models;

namespace ZapateriaJossielito.Controllers
{
    public class DatosImgController : Controller
    {
        // GET: DatosImg

       
        [HttpGet]
        public ActionResult AgregarIMG()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Imagen imagen)
        {
            _ = imagen.file;
            String ruta = Server.MapPath("~/Img/");
            ruta += imagen.file.FileName;
            imagen.file.SaveAs(ruta);
            return View();
        }
        public ActionResult Second()
        {
            return View();
        }
    }
}
