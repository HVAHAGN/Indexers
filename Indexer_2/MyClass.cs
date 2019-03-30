using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_2
{
    class MyClass
    {
        private string[] arr = new string[5];
        //Indexers
        public string this[int index]
        {
            get //Accessor
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index];
                else
                    return "This index out of your array range";
            }
            set //Mutator
            {
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
                else
                    Console.WriteLine("This index out of your array range");

            }
        }
 
    }
}
