using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_4
{
    class MyClass
    {
        private int[,] arr = new int[3, 3];
        
        //Indexers
        public int this[int index1, int index2]
        {
            get //Accessor
            {
                return arr[index1, index2];
            }
            set //Mutator
            {
                arr[index1, index2] = value;

            }
        }
 
    }
}
