//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Meow
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mesaj
    {
        public int MesajId { get; set; }
        public string Mesaj1 { get; set; }
        public Nullable<int> UyeId { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string FotografYol { get; set; }
        public Nullable<int> Begen { get; set; }
    
        public virtual Uye Uye { get; set; }
    }
}
