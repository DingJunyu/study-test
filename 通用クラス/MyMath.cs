using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Study_Class
{
    class MyMath
    {
        public void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}