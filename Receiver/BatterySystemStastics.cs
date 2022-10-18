using System;
using System.Collections.Generic;
using System.Linq;

namespace BatteryParametersReceiver
{
    public static class BatterySystemStastics
    {
            //Properties Declaration
                
            public static int MinimumSystemTemperature { get; set; }

            public static int MaximumSystemTemperature { get; set; }

            public static int MinimumStateOfCharge { get; set; }

            public static int MaximumStateOfCharge { get; set; }

            public static double AverageFiveSystemTemperature { get; set; }

            public static double AverageFiveSystemStateOfCharge { get; set; }
        
            public static int BatterySystemParameterCount{get;set;}
                        
        //Method Computes the System Parameter Statistics
        public static bool ComputeBatteryManagementStastisticsResult(List<BatterySystemParameter> bmsresult_data)
        {
            bool IsStatisticsCompleted=false;            
            if(bmsresult_data!=null && bmsresult_data.Count>=5)
            {
                MinimumSystemTemperature = bmsresult_data.Min(x => x.BatteryTemperature);
                MaximumSystemTemperature = bmsresult_data.Max(x => x.BatteryTemperature);
                MinimumStateOfCharge = bmsresult_data.Min(x => x.StateOfCharge);
                MaximumStateOfCharge = bmsresult_data.Max(x => x.StateOfCharge);
                AverageFiveSystemTemperature = bmsresult_data.Select(p => p.BatteryTemperature).TakeLast(5).Sum(p => p) / 5;
                AverageFiveSystemStateOfCharge = bmsresult_data.Select(p => p.StateOfCharge).TakeLast(5).Sum(p => p) / 5;         
                IsStatisticsCompleted=true;
                BatterySystemParameterCount=bmsresult_data.Count;
                return IsStatisticsCompleted;
            }
            else
            {
                BatterySystemParameterCount=bmsresult_data.Count;
                return IsStatisticsCompleted;
            }            
         }
         
        //Method to display the battery system parameters
        public static bool DisplayBatteryStatisticsOutput()
        {
            if(BatterySystemParameterCount>=5)
            {
                Console.WriteLine($"Minimum Temperature value: {MinimumSystemTemperature},  Maximum Temperature value: {MaximumSystemTemperature}");
                Console.WriteLine($"Minimum State Of Charge value: {MinimumStateOfCharge},  Maximum State Of Charge value: {MaximumStateOfCharge}");
                Console.WriteLine($"Simple moving Average of last 5 values for Temerature: {AverageFiveSystemTemperature},  Simple moving Average of last 5 values for State Of Charge: {AverageFiveSystemStateOfCharge}");
                return true;
            }
            else
                return false;
        }
    }
}
