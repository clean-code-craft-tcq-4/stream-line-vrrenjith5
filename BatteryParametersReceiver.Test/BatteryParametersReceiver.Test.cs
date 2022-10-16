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
            List<string> oSenderInputSample = new List<string>();
            oSenderInputSample.Add("1,2");
            oSenderInputSample.Add("2,4");
            oSenderInputSample.Add("3,6");
            oSenderInputSample.Add("4,8");
            oSenderInputSample.Add("5,10");
            List<BatterySystemParameter> bms_result=BatterySystemStastics.ComputeBatteryManagementStastisticsResult(oSenderInputSample);            
	
            Assert.Equal(bms_result[0],1);
            Assert.Equal(bms_result[1],5);
            Assert.Equal(bms_result[2],2);
            Assert.Equal(bms_result[3],10);            
        }
    }
}
