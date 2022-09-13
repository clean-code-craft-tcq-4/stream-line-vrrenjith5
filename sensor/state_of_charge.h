#ifndef __STATE_OF_CHARGE_H_
#define __STATE_OF_CHARGE_H_
#include <vector>

#define STATE_OF_CHARGE_MIN_VALUE   (0)
#define STATE_OF_CHARGE_MAX_VALUE   (100)

using namespace std;

vector<int> getStateOfChargeValues(int stateOfChargeMaxValue, int stateOfChargeMinValue, int numberOfReadings);

#endif /*__STATE_OF_CHARGE_H_ */


