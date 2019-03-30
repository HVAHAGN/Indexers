using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_5
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[6];
        public Dictionary()
        {
            key[0] = "girq"; value[0] = "book";
            key[1] = "grich"; value[1] = "pencil";
            key[2] = "arev"; value[2] = "sun";
            key[3] = "sexan"; value[3] = "table";


        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                    {
                        return key[i] + " " + value[i];
                    }

                }
                return string.Format("{0}-not found!", index);
            }
        }


             public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "out of array length! ";
            }
        }
    }

    }

