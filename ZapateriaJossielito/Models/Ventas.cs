//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZapateriaJossielito.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ventas()
        {
            this.DetallesVentas = new HashSet<DetallesVentas>();
        }
    
        public int IdVenta { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public int IdUsuario_FK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesVentas> DetallesVentas { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}