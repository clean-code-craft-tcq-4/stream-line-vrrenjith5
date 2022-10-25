#ifndef __TEMPERATURE_H_
#define __TEMPERATURE_H_
#include <vector>

#define TEMPERATURE_MIN_VALUE  (-50)
#define TEMPERATURE_MAX_VALUE  (150)

using namespace std;

vector<int> getTemperatureValues(int temperatureMaxValue, int temperatureMinValue, int numberOfReadings);

#endif /*__TEMPERATURE_H_ */


