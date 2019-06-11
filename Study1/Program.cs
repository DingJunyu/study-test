using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 999;
            int[] b = new int[4];

            Random rnd = new Random();

            for (int i = 0; i < 4; i++) {
                b[i] = rnd.Next(10000);
            }

            foreach(int tmp in b){
                Console.WriteLine(tmp); }
        }
    }
}
