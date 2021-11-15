using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Service;

namespace ZapateriaJossielito.Repository
{
    public class EstilosRepository : IEstilos
    {
        ZapateriaJossielEntities bd = new ZapateriaJossielEntities();
        public void Create(Estilos c)
        {
            bd.Estilos.Add(c);
            bd.SaveChanges();
        }

        public void Delete(Estilos c)
        {
            c = bd.Estilos.Find(c.IdEstilo);
            _ = c;
            bd.Estilos.Remove(c);
            bd.SaveChanges();
        }

        public List<Estilos> ListDataEstilos()
        {
            var ListOfDataOfEstilo = bd.Estilos.ToList();

            return ListOfDataOfEstilo;
        }

        public void Update(Estilos c)
        {
            Estilos actualizar = new Estilos();
            actualizar = bd.Estilos.Find(c.IdEstilo);
            actualizar.Nombre = c.Nombre;
            bd.SaveChanges();
        }

        internal static object ListOfDataOfEstilo()
        {
            throw new NotImplementedException();
        }
    } 
}