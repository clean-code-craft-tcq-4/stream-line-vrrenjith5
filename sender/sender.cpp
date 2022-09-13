
#include <iostream>
#include "../sensor/temperature.h"
#include "../sensor/state_of_charge.h"
#include <vector>
#include "sender.h"

using namespace std;

bool sendSensorDataToConsole(vector<int> temperatureValues, vector<int> stateOfChargeValues){
  bool isDataSendSuccessfully = false;
  if((temperatureValues.size() == READINGS_IN_STREAM) && (stateOfChargeValues.size() == READINGS_IN_STREAM)) {
    cout<<"Temperature, STATE OF CHARGE"<<endl;
    for (int counter = 0; counter < READINGS_IN_STREAM; counter++) {
      cout<<temperatureValues[counter]<<", "<<stateOfChargeValues[counter]<<endl;
    }
    isDataSendSuccessfully = true;
  }
  return isDataSendSuccessfully;
}
