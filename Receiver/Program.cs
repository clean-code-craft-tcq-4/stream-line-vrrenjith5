using System;
using System.Collections.Generic;

namespace BatteryParametersReceiver
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            const int MaxSenderData = 50;
            List<string> battery_Info_From_Sender_System=null;
            
            battery_Info_From_Sender_System = new List<string>();
            try
            {
                for (int console_info = 0; console_info < MaxSenderData; console_info++)
                {
                    battery_Info_From_Sender_System.Add(Convert.ToString(Console.ReadLine()));
                }
               List<BatterySystemParameter> battery_system_info = ProcessSenderData.ProcessSenderDataStatistcs(battery_Info_From_Sender_System); 
               List<int> battery_system_statistics= BatterySystemStastics.ComputeBatteryManagementStastisticsResult(battery_system_info);
               BatterySystemStastics.DisplayBatteryStatisticsOutput(battery_system_statistics);
            }
            catch(NullReferenceException)
            {
                throw new Exception("Data passed from sender is Invalid!");
            }
        }
    }
}
