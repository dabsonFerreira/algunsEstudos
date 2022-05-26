#include <iostream>
using std::cout;

#include "CommisionEmployee.h"

CommissionEmployee::CommissionEmployee(const string first, const string last, const string ssn, double sales, double rate) :
	firstName(first), lastName(last), socialSecurityNumber(ssn)
{
	setGrossSale(sales);
	setCommissionRate(rate);
}

void CommissionEmployee::setFirstName(const string first)
{
	firstName = first;
}

string CommissionEmployee::getFirstName() const
{
	return firstName;
}

void CommissionEmployee::setLastName(const string last)
{
	lastName = last;
}

string CommissionEmployee::getLastName() const
{
	return lastName;
}

void CommissionEmployee::setSocialSecurityNumber(const string ssn)
{
	socialSecurityNumber = ssn;
}

string CommissionEmployee::getSocialSecurityNumber() const
{
	return socialSecurityNumber;
}

void CommissionEmployee::setGrossSale(double sales)
{
	grossSales = (sales < 0.0) ? 0.0 : sales;
}

double CommissionEmployee::getGrossSale() const
{
	return grossSales;
}

void CommissionEmployee::setCommissionRate(double rate)
{
	commissionRate = (rate > 0.0 && rate < 1.0) ? rate : 0.0;
}

double CommissionEmployee::getCommissionRate() const
{
	return commissionRate;
}

double CommissionEmployee::earnings() const
{
	return getGrossSale()*getCommissionRate();
}

void CommissionEmployee::print() const
{
	cout << "Empregado comissionado: " <<
		getFirstName() << ' ' << getLastName() <<
		"\nNumero do seguro social: " << getSocialSecurityNumber() <<
		"\nQuantidade de vendas: " << getGrossSale() <<
		"\nTaxa de comissao: " << getCommissionRate();
}

