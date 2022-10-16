using System;
using System.Collections.Generic;
using System.Linq;

namespace BatteryParametersReceiver
{
    public class BatterySystemStastics
    {
        public static List<int> ComputeBatteryManagementStastisticsResult(List<BatterySystemParameter> bmsresult_data)
        {
            List<int> battery_parmeters_statistics_result = new List<int>();
            int mMinimum_Temperature_value;
            int mMaximum_Temperature_value;
            int mMinimum_Charge_value;
            int mMaximum_Charge_value;
            //int avgerage_last_five_temperature_result;
            //int avgerage_last_five_charge_result;

            mMinimum_Temperature_value = bmsresult_data.Min(x => x.BatteryTemperature);
            mMaximum_Temperature_value = bmsresult_data.Max(x => x.BatteryTemperature);
            mMinimum_Charge_value = bmsresult_data.Min(x => x.StateOfCharge);
            mMaximum_Charge_value = bmsresult_data.Max(x => x.StateOfCharge);
            //avgerage_last_five_temperature_result = bmsresult_data.Select(p => p.BatteryTemperature).TakeLast(5).Sum(p => p) / 5;
            //avgerage_last_five_charge_result = bmsresult_data.Select(p => p.StateOfCharge).TakeLast(5).Sum(p => p) / 5;

            battery_parmeters_statistics_result.Add(mMinimum_Temperature_value);
            battery_parmeters_statistics_result.Add(mMaximum_Temperature_value);
            battery_parmeters_statistics_result.Add(mMinimum_Charge_value);
            battery_parmeters_statistics_result.Add(mMaximum_Charge_value);
            //battery_parmeters_statistics_result.Add(avgerage_last_five_temperature_result);
            //battery_parmeters_statistics_result.Add(avgerage_last_five_charge_result);

            return battery_parmeters_statistics_result;
            
         }
         
        public static bool DisplayBatteryStatisticsOutput(List<int> battery_stastics_result)
        {
            Console.WriteLine($"Minimum Temperature value: {battery_stastics_result[0]},  Maximum Temperature value: {battery_stastics_result[1]}");
            Console.WriteLine($"Minimum State Of Charge value: {battery_stastics_result[2]},  Maximum State Of Charge value: {battery_stastics_result[3]}");
            //Console.WriteLine($"Simple moving Average of last 5 values for Temerature: {battery_stastics_result[4]},  Simple moving Average of last 5 values for State Of Charge: {battery_stastics_result[5]}");
            return true;
        }
    }
}
