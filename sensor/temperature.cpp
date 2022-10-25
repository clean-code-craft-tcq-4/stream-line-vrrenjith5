#include <iostream>
#include "simulate_sensor.h"
#include "temperature.h"

using namespace std;

vector<int> getTemperatureValues(int temperatureMaxValue , int temperatureMinValue, int numberOfReadings) {
  vector<int> temperatureValueList;
  temperatureValueList = simulateRandomSensorValues(temperatureMaxValue, temperatureMinValue, numberOfReadings);
  return temperatureValueList;
}



