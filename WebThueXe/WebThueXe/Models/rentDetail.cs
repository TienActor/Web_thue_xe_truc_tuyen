//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebThueXe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class rentDetail
    {
        public int id { get; set; }
        public int id_rent { get; set; }
        public Nullable<int> id_cars { get; set; }
        public Nullable<int> amount { get; set; }
        public string maKH { get; set; }
    
        public virtual car car { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual rent rent { get; set; }
    }
}
