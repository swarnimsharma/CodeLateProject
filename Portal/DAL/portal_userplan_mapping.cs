//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class portal_userplan_mapping
    {
        public int userplan_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> plan_id { get; set; }
        public Nullable<System.DateTime> plan_time { get; set; }
        public Nullable<bool> is_active { get; set; }
    
        public virtual portal_user portal_user { get; set; }
        public virtual portal_vendor_plan portal_vendor_plan { get; set; }
    }
}
