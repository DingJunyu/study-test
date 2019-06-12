using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] Zoo = new Animal[10];
            Random rand = new Random();

            for (int i = 0; i < Zoo.Length; i++) {
                switch (rand.Next(4)) {//乱数で選ぶ
                    case 0:Zoo[i] = new Cat();break;
                    case 1:Zoo[i] = new Dog();break;
                    case 2:Zoo[i] = new Bird();break;
                    case 3:Zoo[i] = new Tiger();break;
                }
                Zoo[i].Cry();//鳴かす
            }
        }
    }
}
