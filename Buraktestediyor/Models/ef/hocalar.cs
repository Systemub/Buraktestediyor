//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buraktestediyor.Models.ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class hocalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hocalar()
        {
            this.dersler = new HashSet<dersler>();
            this.ogrenci = new HashSet<ogrenci>();
        }
    
        public byte h_ID { get; set; }
        public string h_adi { get; set; }
        public string h_soyadi { get; set; }
        public Nullable<byte> unvani { get; set; }
        public Nullable<byte> top_ders_saati { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dersler> dersler { get; set; }
        public virtual unvanlar unvanlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ogrenci> ogrenci { get; set; }
    }
}
