using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ControlLog
    {
        public string Hostname { get; set; }
        public string NetAddress { get; set; }
        public string NetLibrary { get; set; }
        public string ProgramName { get; set; }
        public string Loginame { get; set; }
        public string Cmd { get; set; }
        public string TableName { get; set; }
    }
}
