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
    
    public partial class Tilmelding
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tilmelding()
        {
            this.Rejsearrangement = new HashSet<Rejsearrangement>();
        }
    
        public string id { get; set; }
    
        public virtual Kunder Kunder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rejsearrangement> Rejsearrangement { get; set; }
    }
}
