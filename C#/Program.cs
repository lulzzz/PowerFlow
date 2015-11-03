using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//for git test
namespace PowerFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //input bus-branch model base case
            NetworkModel networkModel = new NetworkModel();
            networkModel.InitializeNetworkModel();
            networkModel.CalculateYBus();
            networkModel.Solve_PowerFlow();
        }
    }
}
