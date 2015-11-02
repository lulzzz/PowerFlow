#ifndef NETWORKMODEL_H
#define NETWORKMODEL_H
#include"Bus.h"
#include "Branch.h";
#include <iostream>
namespace PowerFlow
{
	class NetworkModel
	{
	public:
		NetworkModel(){ };
		~NetworkModel(){};
	private:
		std::vector<Bus> buses_;
		std::vector<Branch> branches_;
	public:
		std::vector<Branch> get_Branches()
		{
			return branches_;
		}

		void set_Branches(const std::vector<Branch> &branches)
		{
			branches_ = branches;
		}

		std::vector<Bus> get_Buses()
		{
			return buses_;
		}

		void set_Buses(const std::vector<Bus> &buses)
		{
			buses_ = buses;
		}

		//Method

		void InitializeNetworkModel();
		void CalculateYBus();
		void Solve_PowerFlow();

	};
}
#endif