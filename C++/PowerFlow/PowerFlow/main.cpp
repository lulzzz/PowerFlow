#include"NetworkModel.h"

void main()
{
	PowerFlow::NetworkModel test;
	test.InitializeNetworkModel();
	test.CalculateYBus();
	test.Solve_PowerFlow();
	system("pause");
}