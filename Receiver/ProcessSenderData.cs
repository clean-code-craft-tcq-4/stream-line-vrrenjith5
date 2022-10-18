using System;
using System.Collections.Generic;

namespace BatteryParametersReceiver
{
    public class ProcessSenderData
    {
        public static List<BatterySystemParameter> ProcessSenderDataStatistcs(List<string> sender_system_data)
        {
            if(sender_system_data!=null && sender_system_data.Count!=0)
            {
                bool IsValidBoudaryData=true;
                List<BatterySystemParameter> battery_parameters_data = new List<BatterySystemParameter>();
                foreach (string sender_info in sender_system_data)
                {
                    string[] battery_spilt_info = sender_info.Split(',');
                    BatterySystemParameter battery_system_info = new BatterySystemParameter();
                    battery_system_info.BatteryTemperature = Convert.ToInt32(battery_spilt_info[0].Trim());                    
                    battery_system_info.StateOfCharge = Convert.ToInt32(battery_spilt_info[1].Trim());
                    if(!ValidateBatterySystemTemperatureBoundaries(battery_system_info.BatteryTemperature) Or !ValidateBatterySystemStateOfChargeBoundaries(battery_system_info.StateOfCharge))
                    {
                        IsValidBoudaryData=false;
                        break;
                    }
                    battery_parameters_data.Add(battery_system_info);
                }
                if(IsValidBoudaryData)
                    return battery_parameters_data;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }
    }
}
