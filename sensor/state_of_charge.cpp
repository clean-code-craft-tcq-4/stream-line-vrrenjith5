#include <iostream>
#include "state_of_charge.h"

using namespace std;

vector<int> generateSocValues(int socMaxValue , int socMinValue, int numberOfReadings) {
  vector<int> socValueList;
  for (int counter = 0; counter < numberOfReadings; counter++) {
    int randomValue = rand() % socMaxValue + socMinValue;
    socValueList.push_back(randomValue);
  }
  return socValueList;
}

