using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class C1
    {
        public static int no;
        public static string nm;
        public static void display()
        {
            Console.WriteLine("  no=" + no + "   name=" + nm);
        }
    }
    class student
    {
        int rno;
        //string nm;
        public int rollno
        {
            get
            {

                return rno;
            }
            set
            {
                rno = value ;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            C1.no = 890;
            C1.nm = "C U shah college";
            //static member function
            Console.WriteLine("----------static member function-----------");
            C1.display();
            //indexer
            Console.WriteLine("------------------ indexer-----------------");
            String[] s= new String[10];
            for (int i = 0; i < 10; i++) 
            {
               //s[i]= Console.WriteLine(Console.ReadLine());
                s[i] = "parangat college";
                s[2] = "india";
                s[5] = "bharat";
                s[8] = "hindustan";
                Console.WriteLine("s[{0}]={1}", i, s[i]);
                
            }
            Console.WriteLine("---------------------property---------------------");
            student st = new student();
            st.rollno = 87;
            Console.WriteLine("Rollno =" + st.rollno);

            Console.Read();
        }
    }
}
