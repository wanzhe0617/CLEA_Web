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
    
    public partial class E_EvaluateDetail
    {
        public System.Guid ED_ID { get; set; }
        public System.Guid E_ID { get; set; }
        public System.Guid ES_ID { get; set; }
        public Nullable<System.Guid> Evaluate { get; set; }
        public Nullable<int> E_ScoreA { get; set; }
        public Nullable<int> E_ScoreB { get; set; }
        public Nullable<int> E_ScoreC { get; set; }
        public Nullable<int> E_ScoreD { get; set; }
        public Nullable<int> E_ScoreE { get; set; }
        public string E_Remark { get; set; }
        public string E_TeachSyllabus { get; set; }
        public string E_TeachObject { get; set; }
        public string E_TeachAbstract { get; set; }
        public Nullable<System.DateTime> E_FirstScoreDate { get; set; }
        public bool IsMail { get; set; }
        public int Status { get; set; }
        public bool IsClose { get; set; }
        public System.Guid CREUSER { get; set; }
        public System.DateTime CREDATE { get; set; }
        public Nullable<System.Guid> UPDUSER { get; set; }
        public Nullable<System.DateTime> UPDDATE { get; set; }
    }
}
