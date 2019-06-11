using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class GetInput
    {
        private String str;//入力を受け取る
        private String temp = null;//数字の部分を保存する
        private int num;

        public int getANum() {
            while (temp == null) {

                Console.Write("Please Input A Number:");//数字入力を提示

                str = Console.ReadLine();//文字列を取る

                for(int i=0;i<str.Length;i++) {
                    if (str[i] >= 48 && str[i] <= 58) {
                        temp += str[i];
                    }
                }
                if (temp.Length > 10){//オーバーフロー防止
                    Console.WriteLine("より小さいな数字を入力してください");//数字入力を提示
                    temp = null;
                }
            }
            num = int.Parse(temp);//数字に変更する
            temp = null;//文字列をクリアする
            str = null;

            return num;//数字を返す
        }
    }
}
