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
            c = bd.Productos.Find(c.IdProducto);
            bd.Productos.Remove(c);
            bd.SaveChanges();
        }

        public List<Productos> ListDataProductos()
        {
            var ListOfDataOfProductos = bd.Productos.ToList();

            return ListOfDataOfProductos;
        }

        public void Update(Productos c)
        {
            Productos actualizar = new Productos();
            actualizar = bd.Productos.Find(c.IdProducto);
            actualizar.Nombre = c.Nombre;
            actualizar.Descripcion = c.Descripcion;
            actualizar.Precio = c.Precio;
            actualizar.Talla = c.Talla;
            actualizar.Color = c.Color;
            actualizar.Existencias = c.Existencias;
            actualizar.IdEstilo_FK = c.IdEstilo_FK;
            bd.SaveChanges();
        }
    }
    
 }
