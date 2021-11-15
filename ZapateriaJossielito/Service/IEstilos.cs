using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaJossielito.Models;

namespace ZapateriaJossielito.Service
{
    interface IEstilos
    {


        void Create(Estilos c);

        void Update(Estilos c);

        void Delete(Estilos c);

        List<Estilos> ListDataEstilos();
    }
}
