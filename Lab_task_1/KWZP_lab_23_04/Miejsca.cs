//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP_lab_23_04
{
    using System;
    using System.Collections.Generic;
    
    public partial class Miejsca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Miejsca()
        {
            this.Dostarczenia_Wewn = new HashSet<Dostarczenia_Wewn>();
            this.Dostarczenia_Zewn = new HashSet<Dostarczenia_Zewn>();
        }
    
        public string ID_Miejsca { get; set; }
        public string Nazwa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostarczenia_Wewn> Dostarczenia_Wewn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostarczenia_Zewn> Dostarczenia_Zewn { get; set; }
    }
}
