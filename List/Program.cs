using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        /*データ輸出関数*/
        public void Show(List<int> a) {
            foreach (int temp in a)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine("\n");
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            Random rand = new Random();
            List<int> Dat = new List<int>();

            for (int i = 0; i < 100; i++) Dat.Add(rand.Next(100));
            
            p.Show(Dat);

            for (int i = 0;i < Dat.Count;i++) Dat[i] += 50;//全部+50

            p.Show(Dat);

            int mark = 0;//訪問用マーク

            while (true) {
                if (mark != Dat.Count)//continueする場合オーバーフローの可能性があります
                    if (Dat[mark] > 100)
                    {
                        Dat.Remove(Dat[mark]);//削除する
                        continue;
                    }
                mark++;//削除しない場合次の物に訪問する
                if (mark >= Dat.Count)//もしmarkはこのリストの最後になったら.
                    break;//操作終了
            }

            p.Show(Dat);
        }
    }
}
