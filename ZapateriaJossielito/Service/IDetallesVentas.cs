using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaJossielito.Models;

namespace ZapateriaJossielito.Service
{
    interface IDetallesVentas
    {
        void Create(DetallesVentas c);

        void Update(DetallesVentas c);

        void Delete(DetallesVentas c);

        List<DetallesVentas> ListDataDetallesVentas();
    }
}
