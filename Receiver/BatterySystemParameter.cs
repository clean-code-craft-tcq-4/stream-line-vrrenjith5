using System;

namespace BatteryParametersReceiver
{
    public class BatterySystemParameter
    {
        public int BatteryTemperature { get; set; }
        public int StateOfCharge { get; set; }     
        
        public bool ValidateBatterySystemParameterBoundaries(int parameter)
        {
            if(parameter<int.MaxValue && parameter > int.MinValue)
                return true;
            else
                return false;
        }
    }
}



