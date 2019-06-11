using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        enum answer {
            AS_NULL = 0,
            AS_SMALLER,
            AS_LARGER,
            AS_SAME
        }

        static void Main(string[] args)
        {
            int targetNum;
            Random rand = new Random();
            GetInput getInput = new GetInput();
            const int MaxChaCount = 5;

            int range;
            int My_Ans = 0;

            Console.WriteLine("Input The Range:");

            range = getInput.getANum();//範囲を設定する

            int[] ans_temp = new int[3];

            while (true) {
                int challengeCount = MaxChaCount;//挑戦回数をリセットする
                int ans = 0;
                targetNum = rand.Next(range);//入力されたものに基づいて数字を生成する
                while (challengeCount > 0 && ans != (int)answer.AS_SAME) {//正解が出る、もしくは挑戦回数がなくなると終わる
                    Console.Clear();//画面をクリアする
                    Console.WriteLine("Range：" + range);//範囲を提示する
                    if (challengeCount != MaxChaCount)//はじめの挑戦ではなかったら
                        Console.Write("前回の結果は");//前回の結果を提示する
                    switch (ans) {
                        case 0:Console.WriteLine("　");break;
                        case 1:Console.WriteLine("小さいでした");break;
                        case 2:Console.WriteLine("大きいでした");break;
                    }

                    Console.WriteLine("残る回数は" + challengeCount + "回");
                    Console.WriteLine("次の予測値を入力してください:");

                    My_Ans = getInput.getANum();//回答を取得する
                    if (My_Ans > targetNum)
                        ans = (int)answer.AS_LARGER;
                    else if (My_Ans < targetNum)
                        ans = (int)answer.AS_SMALLER;
                    else
                        ans = (int)answer.AS_SAME;

                    challengeCount--;//挑戦回数を一回減る
                }
                Console.Clear();
                if (challengeCount == 0 && ans != 3) {
                    Console.WriteLine("残念でした。。。");
                    Console.WriteLine("結果は" + targetNum + "でした(Escを押すと終了する)");
                }
                if (ans == 3) {
                    Console.WriteLine("おめでとうございます(Escを押すと終了する)");
                }
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)//Escapeキーを押すと終了
                    break;
            }
        }
    }
}
