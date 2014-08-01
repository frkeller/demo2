using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp3
{
    class ConApp3Class1
    {
        private static string sReply = "noreply";
        private static int n1 = 123;
        private static Int16 n2 = 456;

        static void Main(string[] args)
        {
            Console.WriteLine("ConApp3.ConApp3Class1.Main says Hello, world.");

            Point pt1 = new Point();
            Point pt2 = new Point(123, 456);

            // Display results:
            Console.Write("pt1: ");
            Console.WriteLine("x = {0}, y = {1}", pt1.x, pt1.y);
            Console.Write("pt2: ");
            Console.WriteLine("x = {0}, y = {1}", pt2.x, pt2.y);
            Console.WriteLine(pt1.GetType());
            Console.WriteLine(sReply.GetType());
            Console.WriteLine(n1.GetType());
            Console.WriteLine(n2.GetType());
            Console.WriteLine(n2.GetTypeCode());

            string s1 = "\u0068ello ";
            string s2 = "world";
            char c0 = s1[0]; // should be "h"
            char c1 = s1[1]; // should be "e"
            Console.WriteLine(s1 + s2);
            Console.WriteLine(s1 + s2 == "hello world");
            Console.WriteLine(c0);
            Console.WriteLine(c1);
                        
            do
            {
                Console.Write("Enter c to continue or q to quit: ");
                sReply = Console.ReadLine();
                if (sReply.StartsWith("q"))
                    Environment.Exit(0);
            } while ( ! sReply.StartsWith("c") );
            
            //ConApp3Class2.hello2();
            //ConApp3Class3.hello3();
            EmployeeMainClass.EmployeeMain();
            Console.Write("ConApp3.ConApp3Class1.Main says Press the Enter key: ");
            Console.ReadLine();
        }

        public struct Point 
        {
           public int x, y;

           public Point(int p1, int p2) 
           {
              this.x = p1;
              this.y = p2;    
           }
        }

    }
}
