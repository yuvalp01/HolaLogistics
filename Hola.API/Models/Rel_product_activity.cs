//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HolaAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rel_product_activity
    {
        public int ID { get; set; }
        public int product_fk { get; set; }
        public int activity_fk { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Product Product { get; set; }
    }
}