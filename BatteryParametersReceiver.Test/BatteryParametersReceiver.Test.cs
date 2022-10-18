using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace BatteryParametersReceiver.Test
{
    public class BatteryDataReceiverTest
    {
	//Positive case of computing the BMS parameter success and able to display the message
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
	    
	//Check the negative case of passing lesser data and computation of statistics paused
	[Fact]
        public void FailstoComputeBMSStastics()
        {
            List<string> obatterysampleinfo = new List<string>();
            obatterysampleinfo.Add("1,2");
            obatterysampleinfo.Add("2,4");
            obatterysampleinfo.Add("3,6");
            obatterysampleinfo.Add("4,8");          
		
            List<BatterySystemParameter> bms_result=ProcessSenderData.ProcessSenderDataStatistcs(obatterysampleinfo);
	    bool IsComputationSuccess=BatterySystemStastics.ComputeBatteryManagementStastisticsResult(bms_result);            		
	    Assert.False(BatterySystemStastics.ComputeBatteryManagementStastisticsResult(bms_result));    		    
        }	
	    
	//Verify the negative case of lesser input and expecting no display to console
	[Fact]
        public void FailstoDisplayBMSStatisticsResult()
        {
            List<string> oBatterySystemData = new List<string>();
            oBatterySystemData.Add("2,2");
            oBatterySystemData.Add("2,6");
            oBatterySystemData.Add("3,6");
            oBatterySystemData.Add("4,10");          
		
            List<BatterySystemParameter> bms_result=ProcessSenderData.ProcessSenderDataStatistcs(oBatterySystemData);
	    bool IsComputationSuccess=BatterySystemStastics.ComputeBatteryManagementStastisticsResult(bms_result);  
	    Assert.False(BatterySystemStastics.DisplayBatteryStatisticsOutput());
	}
	    
	//Verifying the Null Case condition
	[Fact]
        public void FailstoDisplayBMSStatisticsResultinNullCase()
        {
		List<string> obattery_system_data = null;
		List<BatterySystemParameter> bms_result_info=ProcessSenderData.ProcessSenderDataStatistcs(obattery_system_data);
		Assert.Null(bms_result_info);
	}
	
	//Verifying the Null check on for empty input
	[Fact]
        public void FailstoDisplayBMSStatisticsResultinEmptyData()
        {
		List<string> obattery_parameter_data = new List<string>();
		List<BatterySystemParameter> bms_result_data=ProcessSenderData.ProcessSenderDataStatistcs(obattery_parameter_data);
		Assert.Null(bms_result_data);
	}
	
	//Positive case of checking battery parameter Temperature input	    
	[Fact]
        public void ValidateBatteryTemperatureDataBoundaries()
	{
		BatterySystemParameter bms_parameter=new BatterySystemParameter();
		bms_parameter.BatteryTemperature=140;
		Assert.True(BatterySystemParameter.ValidateBatterySystemParameterBoundaries(bms_parameter.BatteryTemperature);
	}
	
	//Negative case of failing battery parameter Temperature wrong input
	[Fact]
        public void ValidateBatteryTemperatureDataNegativeBoundaries()
	{
		BatterySystemParameter bms_parameter=new BatterySystemParameter();
		bms_parameter.BatteryTemperature=200;
		Assert.False(BatterySystemParameter.ValidateBatterySystemParameterBoundaries(bms_parameter.BatteryTemperature);
	}
	//Positive case of checking battery parameter SOC input		     
	[Fact]
        public void ValidateBatterySOCDataBoundaries()
	{
		BatterySystemParameter bms_parameter=new BatterySystemParameter();
		bms_parameter.BatteryTemperature=80;
		Assert.True(BatterySystemParameter.ValidateBatterySystemParameterBoundaries(bms_parameter.BatteryTemperature);
	}
	
	//Negative case of failing battery parameter SOC wrong input
	[Fact]
        public void ValidateBatterySOCDataNegativeBoundaries()
	{
		BatterySystemParameter bms_parameter=new BatterySystemParameter();
		bms_parameter.BatteryTemperature=250;
		Assert.False(BatterySystemParameter.ValidateBatterySystemParameterBoundaries(bms_parameter.BatteryTemperature);
	}
			    
	//Negative case of Failing Battery parameter boundary condition
	[Fact]
        public void ValidateSenderDataBoundary()
        {
            List<string> obatterysampleinfo = new List<string>();
            obatterysampleinfo.Add("1,2");
            obatterysampleinfo.Add("2,4");
            obatterysampleinfo.Add("200,6");
            obatterysampleinfo.Add("-20,-10");          		
            List<BatterySystemParameter> bms_result=ProcessSenderData.ProcessSenderDataStatistcs(obatterysampleinfo);
	    Assert.Null(bms_result)	    
    }
}
