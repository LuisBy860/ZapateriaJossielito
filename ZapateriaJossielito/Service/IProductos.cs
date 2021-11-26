using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaJossielito.Models;

namespace ZapateriaJossielito.Service
{
    interface IProductos
    {
        void Create(Productos c);

        void Update(Productos c);

        void Delete(Productos c);

        List<Productos> ListDataProductos();
    }
}
