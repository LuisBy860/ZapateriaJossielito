using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Service;

namespace ZapateriaJossielito.Repository
{
    public class VentasRepository : IVentas
    {
        ZapateriaJossielEntities bd = new ZapateriaJossielEntities();
        public void Create(Ventas c)
        {
            bd.Ventas.Add(c);
            bd.SaveChanges();
        }

        public void Delete(Ventas c)
        {
            c = bd.Ventas.Find(c.IdVenta);
            bd.Ventas.Remove(c);
            bd.SaveChanges();
        }

        public List<Ventas> ListDataVentas()
        {
            var ListOfDataOfVentas= bd.Ventas.ToList();

            return ListOfDataOfVentas;
        }

        public void Update(Ventas c)
        {
            Ventas actualizar = new Ventas();
            actualizar = bd.Ventas.Find(c.IdVenta);
            actualizar.Fecha = c.Fecha;
            actualizar.IdUsuario_FK = c.IdUsuario_FK;         
            bd.SaveChanges();
        }
    }
}