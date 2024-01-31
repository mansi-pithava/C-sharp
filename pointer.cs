using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        struct student
        {
            int a,b;
            public void setdata(int a,int b)
            { 
                this.a = a;
                this.b = b; 
            }
            public void print()
            {
                Console.WriteLine("a="+a+",b= "+b);
            }
        }
        unsafe static void Main(string[] args)
        {
           //pointer with structure

            student s = new student();
            student *str = &s;
            str->setdata(10, 90);
            str->print();

           /* int i=90;
            int* b=&i;
            Console.WriteLine("value of i="+i);
            Console.WriteLine("add="+(*b));
            Console.WriteLine("address=" + (int)&i);
            Console.WriteLine("address=" + (int)b);
           */
           //------------------------------------------------------------------
           

            Console.Read();

        }
    }
}
