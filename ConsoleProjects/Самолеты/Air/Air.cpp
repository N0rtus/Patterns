#include "stdafx.h"
#include "iostream"
#include<locale.h>
#include<stdio.h>
#include<iomanip>
#include<conio.h>
#include <Windows.h>
#pragma warning (disable: 4996)
using namespace std;
void main()
{
	const int N = 7;
	int k = 0;
	int i;
	struct AEROFLOT //Структура
	{
		char naznach[10]; //пункт назначения
		char nomers[20];// номер самолета
		char tips[10];//тип самолета
	};
	AEROFLOT BAEROFLOT[7];//массив структур AEROFLOT
	AEROFLOT TAEROFLOT[1];
	char tips2[10];
	SetConsoleCP(1251);// установка кодовой страницы win-cp 1251 в поток ввода
	SetConsoleOutputCP(1251); // установка кодовой страницы win-cp 1251 в поток вывода
	setlocale(LC_ALL, "rus");
	FILE * wFile = fopen("Kursovaya_WORKER.txt", "w");

	for (int i = 1; i <= N; i++)//ввод данных
	{
		cout << "Пункт назначения: ";
		cin.sync();
		cin.getline(BAEROFLOT[i].naznach, 10);//ввод поля пункт назнач
		cout << "Номер самолета: ";
		cin >> BAEROFLOT[i].nomers;//ввод номера самолета
		cout << "Тип самолета: ";
		cin >> BAEROFLOT[i].tips;
	}

	cout << "---------------------------------------------------------\n";
	cout << "|Пункт назначения     |Номер самолета   |Тип самолета    | \n ";
	cout << "-----------------------------------------------------------\n";
	for (int i = 1; i <= N; i++)
	{
		cout << "|" << setw(21) << left << BAEROFLOT[i].naznach << "|" << setw(17) << left << BAEROFLOT[i].nomers << "|" << setw(16) << left << BAEROFLOT[i].tips << "|" << "\n";
		cout << "-----------------------------------------------------------\n";
	}
	for (int i = 1; i <= N-1 ; i++)
		for (int j = 1; j <= N-i ; j++)
			if (strcmp(BAEROFLOT[i].naznach, BAEROFLOT[j].naznach)>0)
			{
				TAEROFLOT[1] = BAEROFLOT[i];
				BAEROFLOT[i] = BAEROFLOT[j];
				BAEROFLOT[j] = TAEROFLOT[1];
			}
	cout << "---------------------------------------------------------\n";
	cout << "|Пункт назначения     |Номер самолета   |Тип самолета    | \n ";
	cout << "-----------------------------------------------------------\n";
	for (int i = 1; i <= N; i++)
	{
		cout << "|" << setw(21) << left << BAEROFLOT[i].naznach << "|" << setw(17) << left << BAEROFLOT[i].nomers << "|" << setw(16) << left << BAEROFLOT[i].tips << "|" << "\n";
		cout << "-----------------------------------------------------------\n";
	}
	cout << "Введите тип самолета: ";
	cin >> tips2;
	for (i = 1; i<N; i++)
		if (strcmp(tips2, BAEROFLOT[i].tips) == 0)
		{
			cout << "|" << setw(21) << left << BAEROFLOT[i].naznach << "|" << setw(17) << left << BAEROFLOT[i].nomers << "|" << setw(16) << left << BAEROFLOT[i].tips << "|" << "\n";
			k++;
		}
	if (k == 0)
		cout << "Нет";
	fprintf(wFile, "---------------------------------------------------------\n");
	fprintf(wFile, "|Пункт назначения |Номер самолета |Тип самолета | \n ");
	fprintf(wFile, "-----------------------------------------------------------\n");
	for (int i = 1; i <= N; i++)
		fprintf(wFile, "%s,%s,%d", BAEROFLOT[i].naznach, BAEROFLOT[i].nomers, BAEROFLOT[i].tips);
	fclose(wFile);
	system("pause");
}