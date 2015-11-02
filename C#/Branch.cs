using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerFlow
{
    class Branch
    {
        #region [Private Members]
        private string internal_ID;
        private string voltageLevel;
        private string branchType;
        private string fromBus;
        private string toBus;

        private double resistance;
        private double reactance;
        private double conductance;
        private double susceptance;

        private double ratio;

        private List<Bus> connectedBuses;
        #endregion

        #region [Properties]
        public string ID
        {
            get
            {
                return internal_ID;
            }
            set
            {
                internal_ID = value;
            }
        }

        public string VoltageLevel
        {
            get
            {
                return voltageLevel;
            }
            set
            {
                voltageLevel = value;
            }
        }

        public string BranchType
        {
            get
            {
                return branchType;
            }
            set
            {
                branchType = value;
            }
        }

        public string FromBus
        {
            get
            {
                return fromBus;
            }
            set
            {
                fromBus = value;
            }
        }

        public string ToBus
        {
            get
            {
                return toBus;
            }
            set
            {
                toBus = value;
            }
        }

        public double Resistance
        {
            get
            {
                return resistance;
            }
            set
            {
                resistance = value;
            }
        }

        public double Reactance
        {
            get
            {
                return reactance;
            }
            set
            {
                reactance = value;
            }
        }

        public double Conductance
        {
            get
            {
                return conductance;
            }
            set
            {
                conductance = value;
            }
        }

        public double Susceptance
        {
            get
            {
                return susceptance;
            }
            set
            {
                susceptance = value;
            }
        }

        public double Ratio
        {
            get
            {
                return ratio;
            }
            set
            {
                ratio = value;
            }
        }

        public List<Bus> ConnectedBuses
        {
            get
            {
                return connectedBuses;
            }
            set
            {
                connectedBuses = value;
            }
        }

        #endregion

        #region [Private Methods]

        #endregion

        #region [Public Methods]
        #endregion
    }
}
