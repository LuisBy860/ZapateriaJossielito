using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Service;
namespace ZapateriaJossielito.Repository
{
    public class DetallesVentasRepository : IDetallesVentas
    {
        ZapateriaJossielEntities bd = new ZapateriaJossielEntities();
        public void Create(DetallesVentas c)
        {
            bd.DetallesVentas.Add(c);
            bd.SaveChanges();
        }

        public void Delete(DetallesVentas c)
        {
            c = bd.DetallesVentas.Find(c.IdDetalleVenta);
            bd.DetallesVentas.Remove(c);
            bd.SaveChanges();
        }

        public List<DetallesVentas> ListDataDetallesVentas()
        {
            var ListOfDataOfDetallesVentas = bd.DetallesVentas.ToList();

            return ListOfDataOfDetallesVentas;
        }

        public void Update(DetallesVentas c)
        {
            DetallesVentas actualizar = new DetallesVentas();
            actualizar = bd.DetallesVentas.Find(c.IdDetalleVenta);
            //actualizar.IdDetalleCompra = c.IdDetalleCompra;
            actualizar.IdDetalleVenta = c.IdDetalleVenta;
            actualizar.Cantidad = c.Cantidad;
            actualizar.IdProducto_FK = c.IdProducto_FK;
            actualizar.IdVenta_FK = c.IdVenta_FK;
            actualizar.Productos = c.Productos;
            actualizar.Ventas = c.Ventas;
            bd.SaveChanges();
        }
    }
}