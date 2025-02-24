using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp_02.Memory
{
    public class MemoryItem
    {
        public double Value { get; set; }

        public MemoryItem(int value)
        {
            Value = value;
        }
    }
}
