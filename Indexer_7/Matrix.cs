﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_7
{
    class Matrix
    {
        private int [,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } }; 
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
            private set  //prevent to mutate
            {
                 numbers[i, j] = value;
            }
        }

    }
}
