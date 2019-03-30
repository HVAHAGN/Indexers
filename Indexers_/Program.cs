using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_
{
    /*Indexers allow instances of a class or struct to be indexed just like arrays.
     * The indexed value can be set or retrieved without explicitly specifying a 
     * type or instance member. Indexers resemble properties except that their 
     * accessors take parameters.*/
    class MyClass
    {
        private int[] array = new int[5];

        //Indexer
        public int this[int index]
        {
            get //Accessor
            {
                return array[index];
            }
            set //Mutator
            {
                if(value!=3)
                array[index] = value;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my[0] = 1;
            my[1] = 2;
            my[2] = 3;
            my[3] = 4;
            my[4] = 5;

            Console.WriteLine(my[0]);
            Console.WriteLine(my[1]);
            Console.WriteLine(my[2]);
            Console.WriteLine(my[3]);
            Console.WriteLine(my[4]);

            Console.ReadLine();
        }
    }
}
