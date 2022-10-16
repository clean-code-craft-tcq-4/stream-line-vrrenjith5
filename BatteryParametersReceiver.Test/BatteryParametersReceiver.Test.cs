using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace BatteryParametersReceiver.Test
{
    public class BatteryDataReceiverTest
    {
        [Fact]
        public void ValidateBMSStatisticsResult()
        {
            List<string> oBatterySenderInputSample = new List<string>();
            oBatterySenderInputSample.Add("1,2");
            oBatterySenderInputSample.Add("2,4");
            oBatterySenderInputSample.Add("3,6");
            oBatterySenderInputSample.Add("4,8");
            oBatterySenderInputSample.Add("5,10");
		
            List<BatterySystemParameter> bms_result=ProcessSenderData.ProcessSenderDataStatistcs(oBatterySenderInputSample);
	    List<int> battery_statistics_result=BatterySystemStastics.ComputeBatteryManagementStastisticsResult(bms_result);            
	
            Assert.Equal(battery_statistics_result[0],1);
            Assert.Equal(battery_statistics_result[1],5);
            Assert.Equal(battery_statistics_result[2],2);
            Assert.Equal(battery_statistics_result[3],10);            
        }
    }
}
