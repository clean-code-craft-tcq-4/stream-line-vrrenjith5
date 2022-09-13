#include <iostream>
#include "simulate_sensor.h"
#include "state_of_charge.h"

using namespace std;

vector<int> getStateOfChargeValues(int stateOfChargeMaxValue, int stateOfChargeMinValue, int numberOfReadings) {
  vector<int> stateOfChargeValueList;
  stateOfChargeValueList = simulateRandomSensorValues(stateOfChargeMaxValue, stateOfChargeMinValue, numberOfReadings);
  return stateOfChargeValueList;
}

