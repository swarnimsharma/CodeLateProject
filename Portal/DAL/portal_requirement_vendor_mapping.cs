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
    
    public partial class portal_requirement_vendor_mapping
    {
        public int pk_post_requirement_vendor_mapping { get; set; }
        public Nullable<int> fk_post_id { get; set; }
        public Nullable<int> fk_vendor_id { get; set; }
        public System.DateTime map_date { get; set; }
    }
}
