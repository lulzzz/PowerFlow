//***************************************Energy Management System*********************************
//***************************************   Power Flow Solution  *********************************
//***************************************   Created by Lin Zhang *********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.IO;
using System.Text.RegularExpressions;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex;

namespace PowerFlow
{
    class NetworkModel
    {
        #region [Private Members]
        private List<Bus> buses = new List<Bus>();
        private List<Branch> branches = new List<Branch>();

        private DenseMatrix m_Y_Bus = DenseMatrix.OfArray(new Complex[1, 1]);

        #endregion 

        #region [Properties]
        public List<Bus> Buses
        {
            get
            {
                return buses;
            }
            set
            {
                buses = value;
            }
        }
        public List<Branch> Branches
        {
            get
            {
                return branches;
            }
            set
            {
                branches = value;
            }
        }
        public DenseMatrix Y_Bus
        {
            get
            {
                return m_Y_Bus;
            }
            set
            {
                m_Y_Bus = value;
            }
        }
        #endregion

        #region [Private Methods]

        #endregion
    
        #region [Public Methods]
        public void InitializeNetworkModel()
        {
            StreamReader objReader = new StreamReader("ieee14cdf.txt");
            string sline = " ";
            // read the header
            sline = objReader.ReadLine();
            sline = objReader.ReadLine();
            Console.WriteLine("these are the header");
            
            // Load bus data
            while (!sline.Equals("-999"))
            {
                Bus bus = new Bus();
                sline = objReader.ReadLine();
                if (sline.Equals("-999"))
                    break;
                sline = sline.Trim();
                string[] data = Regex.Split(sline, "\\s+");
                // trim all the strings in the string array
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = data[i].Trim();
                }
                bus.ID = data[0];
                bus.BusType = data[6];
                bus.BusVoltage = Convert.ToDouble(data[7]);
                bus.BusAngle = Convert.ToDouble(data[8]);
                bus.LoadRealPower = Convert.ToDouble(data[9]);
                bus.LoadReactivePower = Convert.ToDouble(data[10]);
                bus.GenerationRealPower = Convert.ToDouble(data[11]);
                bus.GenerationReactivePower = Convert.ToDouble(data[12]);
                bus.MaximumReactivePowerLimit = Convert.ToDouble(data[15]);
                bus.MinimumReactivePowerLimit = Convert.ToDouble(data[16]);
                bus.ShuntSusceptance = Convert.ToDouble(data[18]);
                buses.Add(bus);
            }
            // branch header
            sline = objReader.ReadLine();
            // Load branch data
            int indexofBranch = 0;
            while (!sline.Equals("-999"))
            {
                Branch branch = new Branch();
                sline = objReader.ReadLine();
                Console.WriteLine(sline);
                if (sline.Equals("-999"))
                    break;
                sline = sline.Trim();
                string[] data = Regex.Split(sline, "\\s+");
                // trim all the strings in the string array
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = data[i].Trim();
                }
                branch.ID = indexofBranch.ToString();
                branch.FromBus = data[0];
                branch.ToBus = data[1];
                branch.Resistance = Convert.ToDouble(data[6]);
                branch.Reactance = Convert.ToDouble(data[7]);
                branch.Susceptance = Convert.ToDouble(data[8]);
                if (data[14].Equals("0.0"))
                { branch.BranchType = "LN"; }
                else
                { branch.BranchType = "XF"; branch.Ratio = Convert.ToDouble(data[14]); };
                branches.Add(branch);
                indexofBranch++;
            }
            objReader.Close();
        }
        public void CalculateYBus()
        {
            foreach (Branch branch in branches)
            {

            }
        }
        public void Solve_PowerFlow()
        {

        }
        #endregion
    }
}
