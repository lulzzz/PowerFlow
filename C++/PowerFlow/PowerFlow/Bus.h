#ifndef BUS_H
#define BUS_H
#include"Branch.h"
#include "string.h"

namespace PowerFlow
{
	class Bus
	{
	public:
		Bus(){ };
		~Bus(){};
	private:
		std::string internal_ID_;
		std::vector<Branch> connectedBranches_;
	public:
		std::string get_internal_ID()
		{
			return internal_ID_;
		}
		void set_internal_ID(std::string ID)
		{
			internal_ID_ = ID;
		}

		std::vector<Branch> get_connectedBranches()
		{
			return connectedBranches_;
		}

		void set_connectedBranches(const std::vector<Branch> &branches)
		{
			connectedBranches_ = branches;
		}

	};
}
#endif