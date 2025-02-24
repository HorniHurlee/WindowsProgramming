using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSan
{
    public class SimpleCalculator : CalculatorBase, CalculatorInterface
    {
        /// <summary>
        /// Гарсан хариун дээр тоог нэмээд харуулах. Анхны утга 0 байна.
        /// </summary>
        /// <param name="number"></param>
        public void Add(int number)
        {
            Result += number;
            Console.WriteLine($"Added {number}, Result: {Result}");
        }

        /// <summary>
        /// Гарсан хариунаас тоог хасаад харуулах. Анхны утга 0 байна.
        /// </summary>
        /// <param name="number"></param>
        public void Subtract(int number)
        {
            Result -= number;
            Console.WriteLine($"Subtracted {number}, Result: {Result}");
        }
    }
}