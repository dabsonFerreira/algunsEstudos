#include <iostream>
using std::cout;

#include "incremento.h" // inclui a definição da classe Incremento
int main()
{
	Incremento value(10, 5);
	cout << "Antes do incremento: ";
	value.print();
	for (int j = 1; j <= 3; j++)
	{
		value.addIncremento();
		cout << "Apos incremento " << j << ": ";
		value.print();
	} // fim do for
	return 0;
} // fim de main