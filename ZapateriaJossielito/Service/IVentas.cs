using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaJossielito.Models;

namespace ZapateriaJossielito.Service
{
    interface IVentas
    {
        void Create(Ventas c);

        void Update(Ventas c);

        void Delete(Ventas c);

        List<Ventas>ListDataVentas();

    }
}
