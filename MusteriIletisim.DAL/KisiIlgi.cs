//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusteriIletisim.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class KisiIlgi
    {
        public int KisiIlgiID { get; set; }
        public int KisiID { get; set; }
        public int IlgiAlaniID { get; set; }
    
        public virtual IlgiAlanlari IlgiAlanlari { get; set; }
        public virtual Kisi Kisi { get; set; }
    }
}
