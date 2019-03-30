using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            BaseClass instacne1 = instance;  //upcast
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(instance[i]);
            }
            Console.ReadLine();
        }
    }
}
