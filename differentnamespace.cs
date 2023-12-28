using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    namespace n1
    {
        class C1
        {
            readonly int a = 123;
            readonly int b;
           
            public C1()
            {
                Console.WriteLine("namespace n1\n");
                b = 50;
            }
            public C1(int x)
            {
                b = x;
            }
            public void PRINT()
            {
                Console.WriteLine("a={0} and b ={1}", a, b);
            }
        }
    }
    namespace n2
    {
        class C1
        {
            readonly int a = 787878;
            readonly int b;
            public C1()
            {
                Console.WriteLine("namespace n2\n");
                b = 500;
            }
            public C1(int x)
            {
                b = x;
            }
            public void PRINT()
            {
                Console.WriteLine("a={0} and b ={1}", a, b);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            n1.C1 c=new n1.C1();
            n1.C1 c2 = new n1.C1(892);
            c.PRINT();
            c2.PRINT();
            n2.C1 H = new n2.C1();
            n2.C1 I = new n2.C1(657);
            H.PRINT();
            I.PRINT();

            Console.Read();
        }
    }
}
