#ifndef __SENDER_H_
#define __SENDER_H_

#define READINGS_IN_STREAM  (50)

using namespace std;

bool sendSensorDataToConsole(vector<int> temperatureValues, vector<int> stateOfChargeValues);

#endif /*__SENDER_H_ */
