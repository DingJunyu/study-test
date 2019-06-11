// ConsoleApplication1.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include "pch.h"
#include <stdio.h>

void move(int, char, char, char);

int main(int argc, char *argv[]) {
	// start from 1 to ignore script name; argv[0] will be a name of processing file.
	char base1 = 'A';
	char base2 = 'B';
	char base3 = 'C';

	int n;
	//箱の数
	scanf("%d", &n)；


		//範囲を超えたかを確認する
		if (n > 8 || n < 1) {
			printf("Invalid");
			return 0;
		}

	//移動する
	move(n, base1, base2, base3);

	return 0;
}

void move(int n, char x, char y, char z) {
	if (n == 1)//1の場合は特例にする
		printf("Move_%d:from_%c_to_%c\n", n, x, z);
	else {//それ以外の場合はしたの順番にする
		move(n - 1, x, z, y);
		printf("Move_%d:from_%c_to_%c\n", n, x, z);
		move(n - 1, y, x, z);
	}
}
// プログラムの実行: Ctrl + F5 または [デバッグ] > [デバッグなしで開始] メニュー
// プログラムのデバッグ: F5 または [デバッグ] > [デバッグの開始] メニュー

// 作業を開始するためのヒント: 
//    1. ソリューション エクスプローラー ウィンドウを使用してファイルを追加/管理します 
//   2. チーム エクスプローラー ウィンドウを使用してソース管理に接続します
//   3. 出力ウィンドウを使用して、ビルド出力とその他のメッセージを表示します
//   4. エラー一覧ウィンドウを使用してエラーを表示します
//   5. [プロジェクト] > [新しい項目の追加] と移動して新しいコード ファイルを作成するか、[プロジェクト] > [既存の項目の追加] と移動して既存のコード ファイルをプロジェクトに追加します
//   6. 後ほどこのプロジェクトを再び開く場合、[ファイル] > [開く] > [プロジェクト] と移動して .sln ファイルを選択します
