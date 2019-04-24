using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Person person = new Person();
            person[0] = new Person { Name = "Vahgan" };
            person[1] = new Person { Name = "Ararat" };
            person[6] = new Person { Name = "Armen" };
            Person v = person[6];
            Console.WriteLine(v);
            Console.WriteLine(new string('*',50));

            User tom = new User();
            tom["name"] = "Tom";
            tom["email"] = "vhoagamo@gmail.com";
            tom["phone"] = "944299";
            Console.WriteLine(tom["name"]+" "+tom["email"]+" "+tom["phone"]);
            Console.WriteLine(new string('*',50));


            Matrix matrix = new Matrix();
            Console.WriteLine(matrix[0,2]);
            //matrix[0, 0] = 3019;
           Console.WriteLine(matrix[0,0]);


            Console.WriteLine(new string('*', 50));
            //indexer cant be static but can be virtual or abstract
            Person person2 = new Person();
            person2[0] = new Person { Name = "Bob" };
            Console.WriteLine(person2[0].Name);

            Console.ReadLine();
        }
    }







}
