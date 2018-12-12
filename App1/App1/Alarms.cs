using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Alarms
    {
        public string Name { get; set; }
        public TimeSpan Time { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", String.IsNullOrWhiteSpace(Name) ? "???" : Name);
        }
    }
}
