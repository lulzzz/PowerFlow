using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerFlow
{
    class Bus
    {
        #region [Private Members]
        private string internal_ID;
        private string busType;
        private string voltageLevel;
        private double busVoltage;
        private double busAngle;

        private double generationRealPower;
        private double generationReactivePower;
        private double loadRealPower;
        private double loadReactivePower;
        private double maximumReactivePowerLimit;
        private double minimumReactivePowerLimit;

        private double shuntConductance;
        private double shuntSusceptance;

        private List<Branch> connectedBranches; 

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

        public string BusType
        {
            get
            {
                return busType;
            }
            set
            {
                busType = value;
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

        public double BusVoltage
        {
            get
            {
                return busVoltage;
            }
            set
            {
                busVoltage = value;
            }
        }

        public double BusAngle
        {
            get
            {
                return busAngle;
            }
            set
            {
                busAngle = value;
            }
        }

        public double GenerationRealPower
        {
            get
            {
                return generationRealPower;
            }
            set
            {
                generationRealPower = value;
            }
        }

        public double GenerationReactivePower
        {
            get
            {
                return generationReactivePower;
            }
            set
            {
                generationReactivePower = value;
            }
        }

        public double LoadRealPower
        {
            get
            {
                return loadRealPower;
            }
            set
            {
                loadRealPower = value;
            }
        }

        public double LoadReactivePower
        {
            get
            {
                return loadReactivePower;
            }
            set
            {
                loadReactivePower = value;
            }
        }

        public double MaximumReactivePowerLimit
        {
            get
            {
                return maximumReactivePowerLimit;
            }
            set
            {
                maximumReactivePowerLimit = value;
            }
        }

        public double MinimumReactivePowerLimit
        {
            get
            {
                return minimumReactivePowerLimit;
            }
            set
            {
                minimumReactivePowerLimit = value;
            }
        }

        public double ShuntConductance
        {
            get
            {
                return shuntConductance;
            }
            set
            {
                shuntConductance = value;
            }
        }

        public double ShuntSusceptance
        {
            get
            {
                return shuntSusceptance;
            }
            set
            {
                shuntSusceptance = value;
            }
        }

        public List<Branch> ConnectedBranches
        {
            get
            {
                return connectedBranches;
            }
            set
            {
                connectedBranches = value;
            }
        }
        #endregion

        #region [Private Methods]

        #endregion

        #region [Public Methods]
        #endregion
    }
}
