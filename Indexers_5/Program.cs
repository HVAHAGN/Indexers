using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            Console.WriteLine(dictionary["girq"]);
            Console.WriteLine(dictionary["grich"]);
            Console.WriteLine(dictionary["tun"]);
            Console.WriteLine(dictionary["arev"]);


            Console.WriteLine(new string('*',10));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadLine();
        }
    }
}
