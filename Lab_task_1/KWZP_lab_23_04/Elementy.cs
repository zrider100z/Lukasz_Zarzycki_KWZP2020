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
    
    public partial class Elementy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Elementy()
        {
            this.Czesci_Obsluga = new HashSet<Czesci_Obsluga>();
            this.Dostawy_Zawartosc = new HashSet<Dostawy_Zawartosc>();
            this.Elementy_Proces = new HashSet<Elementy_Proces>();
            this.Elementy_Cechy = new HashSet<Elementy_Cechy>();
            this.Koszt_Jednostkowy = new HashSet<Koszt_Jednostkowy>();
            this.Material_Na_Produkcji = new HashSet<Material_Na_Produkcji>();
            this.Oferta = new HashSet<Oferta>();
            this.Zapotrzebowanie_Opakowan = new HashSet<Zapotrzebowanie_Opakowan>();
            this.Zawartosc = new HashSet<Zawartosc>();
        }
    
        public int ID_Element { get; set; }
        public Nullable<int> ID_Element_Typ { get; set; }
        public string Element_Nazwa { get; set; }
        public Nullable<int> Okres_Przydatnosci_Miesiace { get; set; }
        public Nullable<float> Element_Ilosc_W_Paczce { get; set; }
        public Nullable<int> ID_Jednostka { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Czesci_Obsluga> Czesci_Obsluga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostawy_Zawartosc> Dostawy_Zawartosc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Elementy_Proces> Elementy_Proces { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Elementy_Cechy> Elementy_Cechy { get; set; }
        public virtual Elementy_Typy Elementy_Typy { get; set; }
        public virtual Elementy_Jednostki Elementy_Jednostki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Koszt_Jednostkowy> Koszt_Jednostkowy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_Na_Produkcji> Material_Na_Produkcji { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oferta> Oferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zapotrzebowanie_Opakowan> Zapotrzebowanie_Opakowan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zawartosc> Zawartosc { get; set; }
    }
}
