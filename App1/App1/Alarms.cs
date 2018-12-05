using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Alarms
    {
        public TimeSpan Time { get; set; }
        public string Name { get; set; }

        public override string ToString() { return String.Format("{0}", String.IsNullOrWhiteSpace(Name) ? "???" : Name); }
    }
}
