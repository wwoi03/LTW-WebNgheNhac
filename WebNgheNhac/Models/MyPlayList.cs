//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebNgheNhac.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MyPlayList
    {
        public int IdBaiHat { get; set; }
        public int IdPlayList { get; set; }
        public string hihi { get; set; }
    
        public virtual BaiHat BaiHat { get; set; }
        public virtual PlayList PlayList { get; set; }
    }
}
