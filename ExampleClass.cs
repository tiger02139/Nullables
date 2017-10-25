using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    public static class ExampleClass
    {
        public static void Display(Nullable<int> x)
        {
            Console.WriteLine($"HasValue: {x.HasValue}");
            if (x.HasValue)
            {
                Console.WriteLine($"Value: {x.Value}");
                Console.WriteLine($"Explicit conversion: {(int)x}");
            }
            Console.WriteLine($"GetValueOrDefault(): {x.GetValueOrDefault()}");
            Console.WriteLine($"GetValueOrDefault(10): {x.GetValueOrDefault(10)}");
            Console.WriteLine($"ToString(): \"{x.ToString()}\"");
            Console.WriteLine($"GetHashCode(): {x.GetHashCode()}");
            Console.WriteLine();
        }


    }
}
