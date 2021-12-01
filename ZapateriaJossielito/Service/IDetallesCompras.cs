using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaJossielito.Models;

namespace ZapateriaJossielito.Service
{
    interface IDetallesCompras
    {

        void Create(DetallesCompras c);

        void Update(DetallesCompras c);

        void Delete(DetallesCompras c);

        List<DetallesCompras> ListDataDetallesCompras();
    }
}
