using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM = 20;
            /*配列とランダムを宣言します*/
            double[] dat = new double[NUM];
            Random rand = new Random();

            /*数字を生成する*/
            for (int i = 0; i < NUM; i++) {
                dat[i] = rand.Next(1000) + rand.NextDouble();//ランダムで数字を生成する
                dat[i] *= 10;//小数の１位を前に移す
                dat[i] = Math.Floor(dat[i])/10;//他の小数の部分を捨てる後に前の数字に戻る
            }
            
            /*生成した数字を表示する*/
            for (int i = 0; i < NUM; i++)
            {
                Console.Write(dat[i] + " ");
            }
            Console.WriteLine();

            /*ソート*/
            System.Array.Sort(dat);
            System.Array.Reverse(dat);

            /*ソートした数字をひょうじする*/
            for (int i = 0; i < NUM; i++)
            {
                Console.Write(dat[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
