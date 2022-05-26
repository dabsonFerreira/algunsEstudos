#include <iostream>
using std::cout;
using std::endl;
#include "incremento.h" // inclui a definição da classe Increment

// construtor; membro constante ‘increment’ não é inicializado
Incremento::Incremento(int c, int i): count(c), incremento(i)
{
	//corpo vazio
} // fim do construtor Increment

void Incremento::addIncremento()
{	
	count += incremento;
	// fim da função addIncrement
}

// imprime valores de count e increment
void Incremento::print() const
{
	cout << "count = " << count << ", incremento = " << incremento << endl;
} // fim da função print