//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CJSW_WebMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class soilstation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public soilstation()
        {
            this.soildata = new HashSet<soildata>();
        }
    
        public string stationid { get; set; }
        public int subcenterid { get; set; }
        public string cname { get; set; }
        public string ctype { get; set; }
        public Nullable<decimal> A10 { get; set; }
        public Nullable<decimal> B10 { get; set; }
        public Nullable<decimal> C10 { get; set; }
        public Nullable<decimal> D10 { get; set; }
        public Nullable<decimal> M10 { get; set; }
        public Nullable<decimal> N10 { get; set; }
        public Nullable<decimal> A20 { get; set; }
        public Nullable<decimal> B20 { get; set; }
        public Nullable<decimal> C20 { get; set; }
        public Nullable<decimal> D20 { get; set; }
        public Nullable<decimal> M20 { get; set; }
        public Nullable<decimal> N20 { get; set; }
        public Nullable<decimal> A30 { get; set; }
        public Nullable<decimal> B30 { get; set; }
        public Nullable<decimal> C30 { get; set; }
        public Nullable<decimal> D30 { get; set; }
        public Nullable<decimal> M30 { get; set; }
        public Nullable<decimal> N30 { get; set; }
        public Nullable<decimal> A40 { get; set; }
        public Nullable<decimal> B40 { get; set; }
        public Nullable<decimal> C40 { get; set; }
        public Nullable<decimal> D40 { get; set; }
        public Nullable<decimal> M40 { get; set; }
        public Nullable<decimal> N40 { get; set; }
        public Nullable<decimal> A60 { get; set; }
        public Nullable<decimal> B60 { get; set; }
        public Nullable<decimal> C60 { get; set; }
        public Nullable<decimal> D60 { get; set; }
        public Nullable<decimal> M60 { get; set; }
        public Nullable<decimal> N60 { get; set; }
        public Nullable<decimal> voltagemin { get; set; }
        public string gsm { get; set; }
        public string gprs { get; set; }
        public string bdsatellite { get; set; }
        public string bdmember { get; set; }
        public string maintran { get; set; }
        public string subtran { get; set; }
        public string dataprotocol { get; set; }
        public string reportinterval { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<soildata> soildata { get; set; }
        public virtual SubCenter SubCenter { get; set; }
    }
}
