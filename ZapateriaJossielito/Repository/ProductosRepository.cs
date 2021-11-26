using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Service;

namespace ZapateriaJossielito.Repository
{
    public class ProductosRepository:IProductos
    {
        ZapateriaJossielEntities bd = new ZapateriaJossielEntities();
        public void Create(Productos c)
        {
            bd.Productos.Add(c);
            bd.SaveChanges();
        }

        public void Delete(Productos c)
        {
            throw new NotImplementedException();
        }

        public List<Productos> ListDataProductos()
        {
            var ListOfDataOfProductos = bd.Productos.ToList();

            return ListOfDataOfProductos;
        }

        public void Update(Productos c)
        {
            throw new NotImplementedException();
        }
    }
    
 }
