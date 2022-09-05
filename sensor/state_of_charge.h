#ifndef __STATE_OF_CHARGE_H_
#define __STATE_OF_CHARGE_H_
#include <vector>

#define SOC_MIN_VALUE   (0)
#define SOC_MAX_VALUE   (100)

using namespace std;

vector<int> generateSocValues(int socMaxValue, int socMinValue, int numberOfReadings);

#endif /*__STATE_OF_CHARGE_H_ */


