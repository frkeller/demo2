using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp3
{
    class ConApp3Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConApp3.ConApp3Class1.Main says Hello, world.");
            Console.WriteLine("ConApp3.ConApp3Class1.Main says Press the Enter key: ");
            Console.ReadLine();
            ConApp3Class2.hello2();
            ConApp3Class3.hello3();
        }
    }
}
