// Calculadora.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
using namespace std;

int main()
{
	char op;
	float num1, num2;

	cout << "Informe um número" << endl;
	cin >> num1;

	cout << "Informe o segundo número" << endl;
	cin >> num2;

	cout << "Informe a operação" << endl;
	cin >> op;

	while (op != '0') {

		switch (op)
		{
		case '*': cout << num1 * num2 << endl; break;
		case '+': cout << num1 + num2 << endl; break;
		case '-': cout << num1 - num2 << endl; break;
		case '/': cout << num1 / num2 << endl; break;
		default: cout << "operação inexistente. Para Sair Pressione 0" << endl;
			break;
		}
		
		cout << "Informe um número" << endl;
		cin >> num1;

		cout << "Informe o segundo número" << endl;
		cin >> num2;
		
		cout << "Informe a operação" << endl;
		cin >> op;
	}

	
}

