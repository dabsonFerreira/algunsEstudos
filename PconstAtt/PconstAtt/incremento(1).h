#pragma once
class Incremento
{
public:
	Incremento(int c = 0, int i = 1); // construtor-padrão
	// definição da função addIncrement
	void addIncremento();
	void print() const; // imprime count e increment
private:
	int count;
	const int incremento; // membro de dados const
}; // fim da classe Increment