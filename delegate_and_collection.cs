using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace dele
{
    internal class Program
    {
        public delegate void dop(int x, int y);
        static void add(int x, int y)
        { 
            Console.WriteLine("add="+(x+y));

        }
        static void sub(int x, int y)
        {
            Console.WriteLine("sub=" + (x - y));

        }
        static void mul(int x, int y)
        {
            Console.WriteLine("mul=" + (x * y));

        }
        static void Main(string[] args)
        {
            //single delegate
            Console.WriteLine("-----------------------------single delegate--------------------");
            dop d = new dop(add);
            d(23, 89);
            

            //multicastdelegate
            Console.WriteLine("-----------------------multicast delegate(-=)------------------------");
            d += new dop(sub);
            d += new dop (mul);
            d(7, 90);
            Console.WriteLine("-----------------------multicast delegate(-=)------------------------");

            d -= new dop(mul);
            d -= new dop(add);
            d(45, 9);
            Console.WriteLine("--------------------------------------COLLECTION ---------------------------------------------");
            Console.WriteLine("                              1.arraylist                                ");
            ArrayList arr = new ArrayList();
            arr.Add("asd");
            arr.Add("yuo");
            arr.Add("aio");
            arr.Add("jk");
            arr.Add(89);
            arr.Add(78);
            arr.Insert(3, "msnfy");
            arr.Remove(78);//this element remove
            arr.RemoveAt(0);// index 0 is remove
            Console.WriteLine("element of an array=" + arr.Count);

            foreach (Object i in arr)
            {
                Console.WriteLine(i);
            }
            ArrayList a = new ArrayList();
            Console.WriteLine(" second arraylist ");
            a.Add("jio");
            a.Add("jio");
            a.Add("jio");
            a.Add("jio");
            //a.Clear();
            //Console.WriteLine("----------add element a--->arr-----------------------");
          // arr.AddRange(a);
            // a.AddRange(arr);
           // Console.WriteLine("----------add element arr--->a-----------------------");

            //a.InsertRange(3, arr);
            Console.WriteLine("element of an array=" + a.Count);

            foreach (Object i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------2.stack----------------------------------");
            Stack s= new Stack();
            s.Push(89);
            s.Push(876);
            s.Push("yyyyy");
            s.Push("mansi");
            s.Push("allen");
            s.Pop();
            //s.Clear();
            Console.WriteLine(s.Contains(876));
            Console.WriteLine("total no of element={0} or top value in stack={1}", s.Count, s.Peek());
            foreach (object i in s) 
            {
                Console.WriteLine(i);  
            }
            Console.WriteLine("-----------------------------3.Queue----------------------------------");
            Queue queue = new Queue();
            queue.Enqueue(67);
            queue.Enqueue(90.90);
            queue.Enqueue("lal");
            queue.Enqueue("viral");
            queue.Enqueue("mansi");
            queue.Enqueue(" ''  ");
            queue.Dequeue();
            Console.WriteLine(queue.Contains(876));
            Console.WriteLine("total no of element={0} or top value in stack={1}", queue.Count, queue.Peek());

            foreach (object i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------------4.Hashtable----------------------------------------");  
            Hashtable ht = new Hashtable();
            Console.Read();
        }
    }
}
