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
    
    public partial class voltage
    {
        public string stationid { get; set; }
        public System.DateTime datatime { get; set; }
        public Nullable<decimal> data { get; set; }
        public string transtype { get; set; }
        public string messagetype { get; set; }
        public Nullable<System.DateTime> recvdatatime { get; set; }
        public Nullable<int> state { get; set; }
    
        public virtual hydlstation hydlstation { get; set; }
    }
}