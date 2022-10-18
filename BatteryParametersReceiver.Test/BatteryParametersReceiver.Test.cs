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
	    bool IsComputationSuccess=BatterySystemStastics.ComputeBatteryManagementStastisticsResult(bms_result);            
		
	    if(IsComputationSuccess)
	    {
		    Assert.Equal(1,BatterySystemStastics.MinimumSystemTemperature);
		    Assert.Equal(5,BatterySystemStastics.MaximumSystemTemperature);
		    Assert.Equal(2,BatterySystemStastics.MinimumStateOfCharge);
		    Assert.Equal(10,BatterySystemStastics.MaximumStateOfCharge);  	
		    Assert.Equal(3,BatterySystemStastics.AverageFiveSystemTemperature);  	
		    Assert.Equal(6,BatterySystemStastics.AverageFiveSystemStateOfCharge);  	
	    }
	
	    Assert.True(BatterySystemStastics.DisplayBatteryStatisticsOutput());
        }		
	
    }
}
