//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaberG.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ilceler
    {
        public int ilceId { get; set; }
        public string ilceIsim { get; set; }
        public int ilceSehirId { get; set; }
    
        public virtual Sehirler Sehirler { get; set; }
    }
}
