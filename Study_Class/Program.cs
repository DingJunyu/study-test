using System;

namespace Study_Class
{
    class Program
    {
        class Book {
            public int val;

            public Book CopyFrom(Book temp) {
                Book newTemp = new Book();
                newTemp.val = temp.val;

                return newTemp;
            }

            public static Book operator + (Book temp1,Book temp2) {
                return new Book() { val = temp1.val + temp2.val };
            }

            public static Book operator ++(Book temp) {
                return new Book() { val = temp.val + 1 };
            }
        }

        static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            Random rand = new Random();
            TestMath testMath;

            int a = rand.Next(100);
            int b = rand.Next(100);

            Console.WriteLine("a:" + a + "," + "b:" + b);

            myMath.Swap(ref a, ref b);

            Console.WriteLine("a:" + a + "," + "b:" + b);

            //クラスは参照
            Book t1 = new Book();
            Book t2 = new Book();
            t1.val = 100;
            t2.val = 200;
            t1 = t1 + t2;//加算
            t1++;
            t2 = t2.CopyFrom(t1);//コピー操作
            t1 = t1 + t1;

            Console.WriteLine("a:" + t1.val + "," + "b:" + t2.val);

            string s1 = new string("Hello");
            string s2 = new string("World");
            s1 = s2;
            s2 = "Now";

            Console.WriteLine(s1 + " " + s2);
        }
    }
}
