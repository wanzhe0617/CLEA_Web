//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clea_Trans
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_Role()
        {
            this.SYS_Power = new HashSet<SYS_Power>();
            this.SYS_User = new HashSet<SYS_User>();
        }
    
        public System.Guid R_UID { get; set; }
        public string R_ID { get; set; }
        public bool R_BackEnd { get; set; }
        public string R_Name { get; set; }
        public byte R_Order { get; set; }
        public bool R_Status { get; set; }
        public System.Guid CREUSER { get; set; }
        public System.DateTime CREDATE { get; set; }
        public Nullable<System.Guid> UPDUSER { get; set; }
        public Nullable<System.DateTime> UPDDATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Power> SYS_Power { get; set; }
        public virtual SYS_Role SYS_Role1 { get; set; }
        public virtual SYS_Role SYS_Role2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_User> SYS_User { get; set; }
    }
}
