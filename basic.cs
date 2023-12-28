using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEM 4");
            Console.WriteLine("------------------------------");
            Console.WriteLine("c#");
            Console.WriteLine("seo");
            Console.WriteLine("java");
            Console.WriteLine("unix/linux");
            Console.WriteLine();
            Console.WriteLine("       arithmatic operation      ");
            int a;
            int b;
            Console.Write("enter the value of a="); 
            a=Convert.ToInt32( Console.ReadLine());
            Console.Write("enter the value of b=");
            b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("addition=" + (a + b));
            Console.WriteLine("substraction="+(a-b));
            Console.WriteLine("multiuplication="+(a*b));
            Console.WriteLine("division=" + (a / b));
            Console.WriteLine("reminder="+(a%b));

            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~table~~~~~~~~~~~~~");
            int no;
            int i;
            Console.Write("enter the value of no=");
            
            no = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <=10; i++) 
            {
                Console.WriteLine("{0} * {1} = {2}", no, i, no * i);
            }
            Console.WriteLine("~~~~~~~~~~~ 1 to 10table  ~~~~~~~~~~~~~");
            Console.WriteLine();
            for (i = 1; i <= 10; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                   
                    Console.Write("{0} * {1} = {2}\t", j, i, j * i);
                }
                Console.WriteLine();
                
            }
            Console.WriteLine("       odd even no     ");
            int n;
            Console.Write("enter the value of no=");
            n= Convert.ToInt32(Console.ReadLine());
            if(n%2 == 0)
            {
                Console.WriteLine("no is even");
            }
            else
            {
                Console.WriteLine("====> no is odd");
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" find max or min number out of three no ");
            Console.WriteLine();
            int o, p, q;
            Console.Write("enter the value of o=");
            o = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the value of p=");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the value of q=");
            q = Convert.ToInt32(Console.ReadLine());

            if (o>p && o>q)
            {
                Console.WriteLine("--->o is max");

            }
            else if(p>o && p>q)
            {
                Console.WriteLine("----> p is max");

            }
            else if(q>o && q>p) 
            {
                Console.WriteLine("---->q is max");
            }
            else

            {
                if (o == p && o == q) 
                {
                    Console.WriteLine();
                Console.WriteLine("--->three are equals");
                }
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("   exception  ");
            try
            { 
                int[] myNumbers = { 1,9,8,78,7,56,4,3,2,2 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            Console.Read();

        }
    }
}
