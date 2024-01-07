using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{


    internal class Program
    {
        class bas
        {
            public int a, b;
            public bas()
            {
                Console.WriteLine("enter value of a=");
                a=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter value of b=");
                b=Convert.ToInt32(Console.ReadLine());
            }
            public bas(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public void dp()
            {
                Console.WriteLine("sum({0},{1})={2}",a,b,a+b);

            }
        }
        class der : bas
        {
            private int c;
            public der()
            { 
                 Console.WriteLine("enter value of c=");
                 c=Convert.ToInt32(Console.ReadLine());
            }
            public der(int c)
            {
                Console.WriteLine("c=" + c);
            } 
            public void display()
            {
                
               Console.WriteLine("addition of [{0},{1},{2}]=({3})",a,b,c,a+b+c);
            }

        }


        static void Main(string[] args)
        {
            der b = new der();
            //der b1 = new der(211);
            b.display();
            b.dp();

            Console.Read();
        }
     
    }
}
