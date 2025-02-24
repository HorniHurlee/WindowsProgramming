using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace CalculatorApp_02.Memory // Changed namespace to "Memory"
{
    public class MemoryTT // Class remains "MemoryTT"
    {
        private List<MemoryItem> memoryItems = new List<MemoryItem>();

        public void Store(int value)
        {
            memoryItems.Add(new MemoryItem(value));
        }

        public double Recall(int index)
        {
            return (index >= 0 && index < memoryItems.Count) ? memoryItems[index].Value : 0;
        }

        public void Clear()
        {
            memoryItems.Clear();
        }
    }
}