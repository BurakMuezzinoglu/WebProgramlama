//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Profil
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Profil()
        {
            this.Tbl_GorselOneri = new HashSet<Tbl_GorselOneri>();
        }
    
        public short Profilid { get; set; }
        public string ProfilAd { get; set; }
        public string ProfilNickname { get; set; }
        public string ProfilEmail { get; set; }
        public Nullable<short> ProfilGorselid { get; set; }
    
        public virtual Tbl_Giris Tbl_Giris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_GorselOneri> Tbl_GorselOneri { get; set; }
    }
}
