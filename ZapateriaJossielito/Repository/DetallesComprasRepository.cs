using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Service;
namespace ZapateriaJossielito.Repository
{
    public class DetallesComprasRepository : IDetallesCompras
    {
        ZapateriaJossielEntities bd = new ZapateriaJossielEntities();
        public void Create(DetallesCompras c)
        {
            bd.DetallesCompras.Add(c);
            bd.SaveChanges();

        }

        public void Delete(DetallesCompras c)
        {
            c = bd.DetallesCompras.Find(c.IdDetalleCompra);
            bd.DetallesCompras.Remove(c);
            bd.SaveChanges();
        }

        public List<DetallesCompras> ListDataDetallesCompras()
        {
            var ListOfDataOfDetalleCompra = bd.DetallesCompras.ToList();

            return ListOfDataOfDetalleCompra;
        }

        public void Update(DetallesCompras c)
        {
            DetallesCompras actualizar = new DetallesCompras();
            actualizar = bd.DetallesCompras.Find(c.IdDetalleCompra);
            //actualizar.IdDetalleCompra = c.IdDetalleCompra;
            
            actualizar.Cantidad = c.Cantidad;
            actualizar.IdProducto_FK = c.IdProducto_FK;
            actualizar.IdCompra_FK = c.IdCompra_FK;
            bd.SaveChanges();
        }
    }
}