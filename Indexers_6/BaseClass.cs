using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_6
{
    class BaseClass
    {
        private string[] baseArray = null;
        public BaseClass()
        {
            baseArray = new string[3];
            baseArray[0] = "Zro";
            baseArray[1] = "Mek";
            baseArray[2] = "Erku";
        }

        //Virtual Indexer wich mind that indexer can be overridden
       public virtual string this[int index]
        {
            get { return baseArray[index]; }
        }
    }
}
