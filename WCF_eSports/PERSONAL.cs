//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_eSports
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSONAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONAL()
        {
            this.DETALLE_PERSONAL = new HashSet<DETALLE_PERSONAL>();
        }
    
        public int IdPersonal { get; set; }
        public string ApePersonal { get; set; }
        public string NomPersonal { get; set; }
        public string PaisPersonal { get; set; }
        public string CargoPersonal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_PERSONAL> DETALLE_PERSONAL { get; set; }
    }
}
