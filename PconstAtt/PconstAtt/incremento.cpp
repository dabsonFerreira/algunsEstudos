#include <iostream>
using std::cout;
using std::endl;
#include "incremento.h" // inclui a defini��o da classe Increment

// construtor; membro constante �increment� n�o � inicializado
Incremento::Incremento(int c, int i): count(c), incremento(i)
{
	//corpo vazio
} // fim do construtor Increment

void Incremento::addIncremento()
{	
	count += incremento;
	// fim da fun��o addIncrement
}

// imprime valores de count e increment
void Incremento::print() const
{
	cout << "count = " << count << ", incremento = " << incremento << endl;
} // fim da fun��o print