﻿// track-test.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include"pch.h"
#include<iostream>
#include<stdio.h>
#include<unordered_map>
#include<string>
//argc,argvの使用テスト
//unordered_map使用テスト

using namespace std;

int main(int argc,char* argv[])
{
	char fileName[50];
	sprintf_s(fileName,".//data//test-%s.txt",argv[1]);

	FILE *fp;

	if (argc >= 2)
		printf("%s\n", argv[2]);

	printf("%s\n", fileName);
	
	if ((fopen_s(&fp, fileName, "r")) == 0) {//ファイル開く失敗する時の対応
		int temp;

		while (fscanf_s(fp, "%d", &temp) != EOF) {//全部読み込むまで読む
			printf("%d ", temp);
		}

		fclose(fp);
	}
	unordered_map<char, list<int>> hmap;
	list<int> b;
	b.push_back(1);

	hmap.insert(pair<char, list<int>>('a', b));

	cout << *hmap['a'].begin() << endl;

	system("pause");
	return 0;
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
