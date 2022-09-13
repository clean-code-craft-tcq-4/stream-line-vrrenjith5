#include <iostream>
#include "simulate_sensor.h"

using namespace std;

vector<int> simulateRandomSensorValues(int maxValue , int minValue, int numberOfReadings) {
  vector<int> randomValueList;
  if ((maxValue != minValue) && (numberOfReadings != 0)) {
    for (int counter = 0; counter < numberOfReadings; counter++) {
      int randomValue = rand() % maxValue + minValue;
      randomValueList.push_back(randomValue);
    }
  }
  return randomValueList;
}



