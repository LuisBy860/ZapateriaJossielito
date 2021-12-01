using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaJossielito.Models;

namespace ZapateriaJossielito.Service
{
    interface ICompras
    {
        void Create(Compras c);

        void Update(Compras c);

        void Delete(Compras c);

        List<Compras> ListDataCompras();
    }
}
