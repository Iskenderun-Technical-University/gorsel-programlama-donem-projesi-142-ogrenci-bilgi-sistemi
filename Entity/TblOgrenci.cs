//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login_Ekranı.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblOgrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblOgrenci()
        {
            this.TblNotlar = new HashSet<TblNotlar>();
        }
    
        public int OgrID { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public string OgrSifre { get; set; }
        public string OgrNumara { get; set; }
        public Nullable<int> OgrSinif { get; set; }
        public Nullable<bool> OgrDurum { get; set; }
        public Nullable<int> OgrDevamsizlik { get; set; }
        public Nullable<int> OgrOrtalama { get; set; }
        public Nullable<int> Ort9 { get; set; }
        public Nullable<int> Ort10 { get; set; }
        public Nullable<int> Ort11 { get; set; }
        public Nullable<int> Ort12 { get; set; }
        public Nullable<int> Ort13 { get; set; }
        public Nullable<int> OgrDevam { get; set; }
    
        public virtual TblSinif TblSinif { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblNotlar> TblNotlar { get; set; }
    }
}
