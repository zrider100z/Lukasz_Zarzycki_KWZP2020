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
    
    public partial class Zawartosc
    {
        public int ID_Zawartosc { get; set; }
        public string ID_Polka { get; set; }
        public Nullable<int> ID_Element { get; set; }
        public Nullable<int> ID_Dostawy { get; set; }
        public Nullable<int> Ilosc_Paczek { get; set; }
    
        public virtual Elementy Elementy { get; set; }
        public virtual Polki Polki { get; set; }
        public virtual Zamowienia_Dostawy Zamowienia_Dostawy { get; set; }
    }
}
