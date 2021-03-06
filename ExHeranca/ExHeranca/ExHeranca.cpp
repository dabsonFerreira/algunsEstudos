// ExHeranca.cpp : define o ponto de entrada para o aplicativo do console.
//
#include <iostream>
#include <iomanip>
#include "BasePlusCommissionEmployee.h"


using namespace std;
int main(){

	BasePlusCommissionEmployee ce("Sue", "Jose", "222-22-2222", 1000, 0.6);
	BasePlusCommissionEmployee employee("Bob", "Lewis", "333-33-333", 5000, 0.04, 300);

	cout << fixed << setprecision(2);

	//Pare 1

	ce.print();
	cout << endl << endl;
	bpce.print();
	cout << endl << endl;

	//Parte 2
	system("cls");
	CommissionEmployee vet_ce[2] = { ce, bpce };
	vet_ce[0].print();
	cout << endl << endl;
	vet_ce[1].print();
	cout << endl << endl;

	//Parte 3
	system("cls");
	CommissionEmployee* ce_ptr = &ce;
	BasePlusCommissionEmployee* bpce_ptr = &bpce;

	ce_ptr->print();
	cout << endl << endl;
	bpce_ptr->print();
	cout << endl << endl;

	ce_ptr = &bpce;
	ce_ptr->print();

	system("pause");

	cout << "Informacoes do empregado obtidas pelas funcoes get: \n"
		<< "\n O nome e " << employee.getFirstName()
		<< "\n O sobrenome e " << employee.getLastName()
		<< "\n O numero de seguro social e " << employee.getSocialSecurityNumber()
		<< "\n A quantidade de vendas e " << employee.getGrossSale()
		<< "\n A taxa de comissao e " << employee.getCommissionRate()
		<< "\n O salario base e " << employee.getBaseSalary()<<endl;

	employee.setBaseSalary(1000);

	cout << "Informacoes atraves da funcao print" << endl << endl;

	employee.print();

	cout << "Salario do empregado R$ " << employee.earnings() << endl;
	system("pause");
	 


    return 0;
}

