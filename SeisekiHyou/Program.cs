using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumber;

namespace SeisekiHyou
{
    class Program
    {
        const int grade = 6;
        const int courseCount = 3;
        const int studentAmount = 30;
        const int placeForAver = 1;
        const int maxScore = 100;
        const int randomSup = 1;
        Random P_rand = new Random();

        public void SetRandom(ref int[] a)
        {
           
            for (int i = 0; i < courseCount; i++)
            {
                a[i] = P_rand.Next(maxScore + randomSup);
                a[courseCount] += a[i];//総得点に加算
            }
            a[courseCount] /= 3;//平均点を計算する
        }

        public static void TheOldOne() {
            Program p = new Program();
            /*関数法*/
            int[][][] tblTest = new int[grade][][];
            for (int i = 0; i < grade; i++)
            {
                tblTest[i] = new int[studentAmount + placeForAver][];
                for (int j = 0; j < studentAmount + placeForAver; j++)
                {
                    tblTest[i][j] = new int[courseCount + placeForAver];
                    p.SetRandom(ref tblTest[i][j]);
                }
            }

            for (int k = 0; k < grade; k++)
            {
                tblTest[k][studentAmount][courseCount] = 0;
                for (int j = 0; j < courseCount; j++)
                {
                    tblTest[k][studentAmount][j] = 0;//リセットする
                    for (int i = 0; i < studentAmount; i++)
                        tblTest[k][studentAmount][j] += tblTest[k][i][j];
                    tblTest[k][studentAmount][j] /= studentAmount;//教科毎の平均を計算する
                    tblTest[k][studentAmount][courseCount] += tblTest[k][studentAmount][j];//総平均点に加算
                }
                tblTest[k][studentAmount][courseCount] /= courseCount;//総平均点を計算する
            }

            for (int k = 0; k < grade; k++)
            {
                Console.WriteLine(k + 1 + "学年");
                for (int i = 0; i < studentAmount + placeForAver; i++)
                {
                    if (i != studentAmount)//平均点ではないときに学生の番号を輸出
                        Console.Write("{0,2}番:", i + 1);
                    else//平均点の時に平均を描く
                        Console.Write("平均:");

                    for (int j = 0; j < courseCount + placeForAver; j++)
                    {
                        Console.Write("{0,3}  ", tblTest[k][i][j]);
                    }
                    Console.WriteLine();//改行
                }
                Console.WriteLine();//改行
            }

        }

        public static void TheNewOne() {
            Random rand = new Random();
            /*C#方法*/
            int[,,] tbl = new int[grade, studentAmount + placeForAver, courseCount + placeForAver];//配列を宣言
            for (int k = 0; k < grade; k++)
            {
                for (int i = 0; i < studentAmount; i++)
                {
                    for (int j = 0; j < courseCount; j++)
                    {
                        tbl[k, i, j] = rand.Next(maxScore + randomSup);//各科目の成績を生成する
                        tbl[k, i, courseCount] += tbl[k, i, j];//生成した成績を平均点のところに加算
                        tbl[k, studentAmount, j] += tbl[k, i, j];//生成した成績を教科毎の平均のところに加算
                    }
                    tbl[k, i, courseCount] /= courseCount;//学生平均点を計算する
                }
            }

            for (int k = 0; k < grade; k++)
            {
                for (int j = 0; j < courseCount; j++)
                {
                    tbl[k, studentAmount, j] /= studentAmount;//教科毎の平均を計算する
                    tbl[k, studentAmount, courseCount] += tbl[k, studentAmount, j];//総平均点に加算
                }
                tbl[k, studentAmount, courseCount] /= courseCount;//総平均点を計算する
            }
            Console.WriteLine("番号 国語 算数 社会 平均");

            for (int k = 0; k < grade; k++)
            {
                Console.WriteLine(k + 1 + "学年");
                for (int i = 0; i < studentAmount + placeForAver; i++)
                {
                    if (i != studentAmount)//平均点ではないときに学生の番号を輸出
                        Console.Write("{0,2}番:", i + 1);
                    else//平均点の時に平均を描く
                        Console.Write("平均:");

                    for (int j = 0; j < courseCount + placeForAver; j++)
                    {
                        Console.Write("{0,3}  ", tbl[k, i, j]);
                    }
                    Console.WriteLine();//改行
                }
                Console.WriteLine();//改行
            }
        }

        static void Main(string[] args)
        {
            GetInput getInput = new GetInput();
            int ans = 0;

            while (ans != 1 && ans != 2)
            {
                Console.Clear();
                Console.WriteLine("バージョンを選択してください(1:過去のやり方,2:C#のやり方)");
                ans = getInput.getANum();
            }
            Console.Clear();

            switch (ans)
            {
                case 1: TheOldOne(); break;
                case 2: TheNewOne(); break;
            }
        }
    }
}
