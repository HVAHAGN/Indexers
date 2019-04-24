using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_7
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        Person [] data;
        public Person()
        {
             data = new Person[5];
        }
        //indexer
        public Person this[int index]
        {
            get
            {
                if(index >= 0 && index < data.Length)

                    return data[index];
                else
                {
                    return null;
                }
                

            }
            set
            {
                if(index>=0 && index<data.Length)
                 data[index] = value;
                else
                    Console.WriteLine($"This {index} index out of your array range");
            }
        }
        //overload indexer by changing count, type or sequence of parameters

        public Person this[string name]
        {
            get
            {
                Person person = null;
                foreach(var p in data)
                {
                    if(p.Name==name)
                    {
                        person = p;
                        break;
                    }
                }
                return person;
            }
        }

    }
}
