//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeLife.Datos
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    public partial class Plan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plan()
        {
            this.Contrato = new HashSet<Contrato>();
        }
    
        public string IdPlan { get; set; }
        public string Nombre { get; set; }

        public IEnumerable ReadAllEstado()
        {
            throw new NotImplementedException();
        }

        public double PrimaBase { get; set; }
        public string PolizaActual { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
    }
}
