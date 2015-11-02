#ifndef BRANCH_H
#define BRANCH_H
#include"Bus.h"
#include<vector>
namespace PowerFlow
{
	class Branch
	{
	public:
		Branch(){};
		~Branch(){};
	private:
		std::string internal_ID_;
		std::string voltageLevel_;
		//std::vector<Bus> connectedBuses_;
	public:
		std::string get_internal_ID()
		{
			return internal_ID_;
		}
		void set_internal_ID(std::string ID)
		{
			internal_ID_ = ID;
		}

		std::string get_voltageLevel()
		{
			return voltageLevel_;
		}
		void set_voltageLevel(std::string level)
		{
			voltageLevel_ = level;
		}

		//std::vector<Bus> get_connectedBuses()
		//{
		//	return connectedBuses_;
		//}

		//void set_connectedBuses(const std::vector<Bus> &buses)
		//{
		//	connectedBuses_ = buses;
		//}
	};
}
#endif