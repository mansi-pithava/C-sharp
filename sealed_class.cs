using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
   
        sealed class SealedClass
        {
            public void DisplayMessage()
            {
                Console.WriteLine("This is a sealed class.");
            }
        }
       class Program
    {
        static void Main()
        {
            // Creating an instance of the sealed class
            SealedClass sealedInstance = new SealedClass();

            // Calling a method of the sealed class
            sealedInstance.DisplayMessage();

            Console.ReadLine();
        }
    }

    }

