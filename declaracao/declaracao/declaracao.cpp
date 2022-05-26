// declaracao.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//pagina 12 apostila

#include <iostream>
#include <iomanip>//formatação dos dados no console - exemplo os espaços 
#include <stdlib.h>

using namespace std;

int main()
{
    int vetor[5]; //alocação de memória comunicado ao sistema operacional

	for (int i = 0; i < 5; i++) {
		vetor[i] = i;
	}

	//Pare 3

	char vet[5]; 

	memset(vet, '$', sizeof(vet)); //biblioteca stdlib; vai repetir o cifrão em x vezes onde x é o tamanho de vet

	cout << "Elemento" << setw(13) << "Valor" << endl;

	for (int j = 0; j < sizeof(vet) / sizeof(vet[0]); j++) {

		cout << setw(7) << j << setw(7) << vet[j] << endl; //o setw eh o espaçamento na tabela entre colunas e linhas
	}
	system("pause");
	return 0;
}
