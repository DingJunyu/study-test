using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Study_Animal
{
    abstract class Animal
    {
        public abstract void Cry();
    }

    class Cat : Animal {
        public override void Cry() {
            Console.WriteLine("にゃん");
        }
    }

    class Dog : Animal {
        public override void Cry() {
            Console.WriteLine("ワン");
        }
    }

    class Bird : Animal {
        public override void Cry() {
            Console.WriteLine("ビー");
        }
    }

    class Tiger : Animal {
        public override void Cry() {
            Console.WriteLine("イエッタイガー");
        }
    }
}