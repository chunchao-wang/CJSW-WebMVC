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
    
    public partial class soildata
    {
        public string StationID { get; set; }
        public System.DateTime DataTime { get; set; }
        public Nullable<decimal> Voltage { get; set; }
        public Nullable<decimal> Voltage10 { get; set; }
        public Nullable<decimal> Moisture10 { get; set; }
        public Nullable<decimal> Voltage20 { get; set; }
        public Nullable<decimal> Moisture20 { get; set; }
        public Nullable<decimal> Voltage30 { get; set; }
        public Nullable<decimal> Moistrue30 { get; set; }
        public Nullable<decimal> Voltage40 { get; set; }
        public Nullable<decimal> Moistrue40 { get; set; }
        public Nullable<decimal> Voltage60 { get; set; }
        public Nullable<decimal> Moistrue60 { get; set; }
        public string TransType { get; set; }
        public string MessageType { get; set; }
        public Nullable<System.DateTime> recvdatatime { get; set; }
        public Nullable<int> state { get; set; }
    
        public virtual soilstation soilstation { get; set; }
    }
}
