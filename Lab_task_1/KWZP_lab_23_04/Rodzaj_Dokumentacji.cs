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
    
    public partial class Rodzaj_Dokumentacji
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rodzaj_Dokumentacji()
        {
            this.Dokumentacje = new HashSet<Dokumentacje>();
        }
    
        public int ID_Rodzaj { get; set; }
        public string Nazwa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dokumentacje> Dokumentacje { get; set; }
    }
}
