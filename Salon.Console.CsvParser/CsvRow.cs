using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Console.CsvParser
{
    public class CsvRow: List<string>
    {
        public string LineText { get; set; }
    }
}
