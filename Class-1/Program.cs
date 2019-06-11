using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1
{
    class Student {
        public Student(string Name, int[] Point) {
            int maxLength = Point.Length > point.Length ? point.Length : Point.Length;
            for (int a = 0; a < maxLength; a++) {
                point[a] = Point[a];
            }
            name = Name;
        }

        int[] point = new int[3];
        string name;

        public double ave() {
            int ans = 0;
            foreach (int temp in point)
                ans += temp;
            return ans / point.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] point = { 20, 15, 14 };

            Student taro = new Student("taro",point);

            Console.WriteLine(taro.ave());
        }
    }
}
