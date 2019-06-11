#include<stdio.h>
#include<iostream>

int main() {
	char data[255] = ("We are student");

	int length = strnlen_s(data, 20);
	int shift = 100;

	printf("Please Input The Shift:");
	scanf_s("%d", &shift);
	
	for (int i = 0; i < length; i++) {
		printf("%X ", data[i]);
	}printf("\n");
	printf("%s\n \n", data);
	
	for (int i = 0; i < length; i++) {
		int temp;
		temp = (data[i] + shift) % 128;
		data[i] = (char)temp;
		printf("%X ", data[i]);
	}printf("\n");
	printf("%s\n \n", data);

	for (int i = 0; i < length; i++) {
		if (data[i] > shift)
			data[i] = data[i] - shift;
		else
			data[i] = data[i] + 128 - shift;
		printf("%X ", data[i]);
	}printf("\n");
	printf("%s", data);

	getchar(); getchar();
}