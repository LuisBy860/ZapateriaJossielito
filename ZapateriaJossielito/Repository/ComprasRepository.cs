using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Service;

namespace ZapateriaJossielito.Repository
{
    public class ComprasRepository : ICompras
    {
        ZapateriaJossielEntities bd = new ZapateriaJossielEntities();
        public void Create(Compras c)
        {
            bd.Compras.Add(c);
            bd.SaveChanges();
            
        }

        public void Delete(Compras c)
        {
            c = bd.Compras.Find(c.IdCompra);
            bd.Compras.Remove(c);
            bd.SaveChanges();
           
        }

        public List<Compras> ListDataCompras()
        {
            var ListOfDataOfCompras = bd.Compras.ToList();

            return ListOfDataOfCompras;
          
        }

        public void Update(Compras c)
        {
            Compras actualizar = new Compras();
            actualizar = bd.Compras.Find(c.IdCompra);
            //actualizar.IdCompra = c.IdCompra;
            
            actualizar.Fecha = c.Fecha;
            actualizar.DetallesCompras = c.DetallesCompras;
            bd.SaveChanges();
         
        }
    }
}