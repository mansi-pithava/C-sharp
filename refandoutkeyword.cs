using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_and_outkeyword
{
    internal class Program
    {
        /*static void modify(ref int x)
        {
            x = x * 2;
        }*/
        static void getdata(out int a,out int b)
        {
            a=8; b=90;
        }
        static void Main()
        {
            /*int number = 5;
            modify(ref number);
            Console.WriteLine(number); // Outputs 10
            */
            int x ,y ;
            getdata(out x ,out y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.Read();

        }
    }
    
}
/* above example comment are contain the ref keyword program*/ 
