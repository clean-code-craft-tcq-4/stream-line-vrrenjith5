using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace BatteryParametersReceiver.Test
{
    public class BatteryDataReceiverTest
    {
        [Fact]
        public void ValidateBMSStatisticsResultAndDisplay()
        {
            List<string> oBatterySenderInputSample = new List<string>();
            oBatterySenderInputSample.Add("1,2");
            oBatterySenderInputSample.Add("2,4");
            oBatterySenderInputSample.Add("3,6");
            oBatterySenderInputSample.Add("4,8");
            oBatterySenderInputSample.Add("5,10");
		
            List<BatterySystemParameter> bms_result=ProcessSenderData.ProcessSenderDataStatistcs(oBatterySenderInputSample);
	    List<int> battery_statistics_result=BatterySystemStastics.ComputeBatteryManagementStastisticsResult(bms_result);            
	
            Assert.Equal(1,battery_statistics_result[0]);
            Assert.Equal(5,battery_statistics_result[1]);
            Assert.Equal(2,battery_statistics_result[2]);
            Assert.Equal(10,battery_statistics_result[3]);       
	
	    Assert.True(DisplayBatteryStatisticsOutput(battery_statistics_result));
        }
	
    }
}
