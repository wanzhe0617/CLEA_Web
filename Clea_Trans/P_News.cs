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
    
    public partial class P_News
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public P_News()
        {
            this.P_NewsReadLog = new HashSet<P_NewsReadLog>();
        }
    
        public System.Guid News_ID { get; set; }
        public string N_Type { get; set; }
        public string N_Title { get; set; }
        public int N_Class { get; set; }
        public System.DateTime N_StartDate { get; set; }
        public Nullable<System.DateTime> N_EndDate { get; set; }
        public bool N_IsTop { get; set; }
        public bool N_IsShow { get; set; }
        public bool N_Status { get; set; }
        public string N_Content { get; set; }
        public Nullable<bool> N_Role { get; set; }
        public string R_ID { get; set; }
        public System.Guid CREUSER { get; set; }
        public System.DateTime CREDATE { get; set; }
        public Nullable<System.Guid> UPDUSER { get; set; }
        public Nullable<System.DateTime> UPDDATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_NewsReadLog> P_NewsReadLog { get; set; }
    }
}
