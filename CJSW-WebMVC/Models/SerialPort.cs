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
    
    public partial class SerialPort
    {
        public int PortNumber { get; set; }
        public string TransType { get; set; }
        public Nullable<int> Baudrate { get; set; }
        public Nullable<int> Databit { get; set; }
        public Nullable<int> Stopbit { get; set; }
        public string Parity { get; set; }
        public Nullable<int> Stream { get; set; }
        public Nullable<bool> Break { get; set; }
        public Nullable<bool> Open { get; set; }
        public string dataprotocol { get; set; }
    }
}
