using System;
using CalculatorSan;
using CalculatorApp_02.Memory;

namespace CalculatorApp_02
{
    class Program
    {
        static void Main()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            MemoryTT memory = new MemoryTT(); 

            calculator.Add(11);
            calculator.Subtract(5);

            memory.Store(calculator.Result);
            Console.WriteLine($"Stored Result: {memory.Recall(0)}");

            calculator.Add(20);
            memory.Store(calculator.Result);
            Console.WriteLine($"Stored Result: {memory.Recall(1)}");

            memory.Clear();
            Console.WriteLine("Memory Cleared.");
        }
    }
}