//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Viking_Rejser.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kunder
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
    
        public virtual Tilmelding Tilmelding { get; set; }
    }
}
