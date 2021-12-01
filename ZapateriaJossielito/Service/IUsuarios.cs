using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaJossielito.Models;

namespace ZapateriaJossielito.Service
{
    interface IUsuarios
    {
        void Create(Usuarios c);

        void Update(Usuarios c);

        List<Usuarios> ListDataUsuarios();
    }
}
