//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsiakastietokantaMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tunnit
    {
        public int TuntiID { get; set; }
        public Nullable<int> ProjektiID { get; set; }
        public Nullable<int> HenkiloID { get; set; }
        public Nullable<System.DateTime> Pvm { get; set; }
        public Nullable<int> Projektitunnit { get; set; }
    
        public virtual Henkilot Henkilot { get; set; }
        public virtual Projektit Projektit { get; set; }
    }
}
