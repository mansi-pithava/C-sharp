using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    internal class Program
    {
        public class sybca
        {
            int size = 10;
            string[] s = new string[10];
            public void display()
            {
                for (int i = 0; i < 10; i++)
                {
                    
                  Console.WriteLine("value of s[{0}]={1}" ,i,s[i]);
                }
            }
            public string this[int i]
            {
                get
                {
                    return s[i];

                }
                set
                { 
                    s[i] = value; 
                }
            }
        } 

        static void Main(string[] args)
        {
            sybca a = new sybca();
            for (int i = 0; i < 10; i++)
            {
                a[i] = "parangat";
            }
            a[2] = "csharp";
            a[3] = "java";
            a[4] = "os";
            a[5] = "seo";
            a.display();
            Console.Read();
        }
    }
}
