using System;

namespace BatteryParametersReceiver
{
    public class BatterySystemParameter
    {
        //constant boundary values
        private const int SOC_MIN = 0;
        private const int SOC_MAX = 100;
        private const int TEMP_MIN = -50;
        private const int TEMP_MAX = 150;        
        
        public int BatteryTemperature { get; set; }
        public int StateOfCharge { get; set; }     
        
        //Check the boundary limit of Temperature
        public static bool ValidateBatterySystemTemperatureBoundaries(int parameter)
        {
            if(parameter<TEMP_MAX && parameter > TEMP_MIN)
                return true;
            else
                return false;            
        }
        
        //Check the boundary limit of StateOfCharge
        public static bool ValidateBatterySystemStateOfChargeBoundaries(int parameter)
        {
            if(parameter<SOC_MAX && parameter > TEMP_MIN)
                return true;
            else
                return false;            
        }
    }
}



