using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZapateriaJossielito.Models;
using ZapateriaJossielito.Service;

namespace ZapateriaJossielito.Repository
{
    public class UsuariosRepository : IUsuarios
    {
        ZapateriaJossielEntities bd = new ZapateriaJossielEntities();
        public void Create(Usuarios c)
        {
            bd.Usuarios.Add(c);
            bd.SaveChanges();
        }

        public List<Usuarios> ListDataUsuarios()
        {
            var ListOfDataOfUsuarios = bd.Usuarios.ToList();

            return ListOfDataOfUsuarios;
        }

        public void Update(Usuarios c)
        {
            Usuarios actualizar = new Usuarios();
            actualizar = bd.Usuarios.Find(c.IdUsuario);
            
            actualizar.Usuario = c.Usuario;
            actualizar.Contrasena = c.Contrasena;
            actualizar.Nombre = c.Nombre;
            actualizar.Apellido = c.Apellido;
            actualizar.Dui = c.Dui;
            actualizar.Direccion = c.Direccion;
            actualizar.Telefono = c.Telefono;
            actualizar.Email = c.Email;
            actualizar.IdRol_FK = c.IdRol_FK;
            bd.SaveChanges();
        }
    }
}