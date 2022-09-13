
#include <iostream>
#include "../sensor/temperature.h"
#include "../sensor/state_of_charge.h"
#include <vector>
#include "sender.h"

using namespace std;

bool sendSensorDataToConsole(){
  bool isDataSendSuccessfully = false;
  vector<int> temperatureValues = generateTemperatureValues(TEMPERATURE_MAX_VALUE ,TEMPERATURE_MIN_VALUE, READINGS_IN_STREAM);
  vector<int> socValues = generateSocValues(SOC_MAX_VALUE ,SOC_MIN_VALUE, READINGS_IN_STREAM);

  if((temperatureValues.size() == READINGS_IN_STREAM) && (socValues.size() == READINGS_IN_STREAM)) {
    cout<<"Temperature, SOC"<<endl;
    for (int counter = 0; counter < READINGS_IN_STREAM; counter++) {
      cout<<temperatureValues[counter]<<", "<<socValues[counter]<<endl;
    }
    isDataSendSuccessfully = true;
  }
  return isDataSendSuccessfully;
}
