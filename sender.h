#ifndef __SENDER_H_
#define __SENDER_H_
#include "sensor/temperature.h"
#include "sensor/state_of_charge.h"
#include <vector>

#define READINGS_IN_STREAM  (50)

using namespace std;

bool sendSensorDataToConsole();

#endif /*__SENDER_H_ */


