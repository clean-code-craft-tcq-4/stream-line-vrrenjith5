#define CATCH_CONFIG_MAIN
#include "test/catch.hpp"
#include <iostream>
#include "sensor/temperature.h"
#include "sensor/state_of_charge.h"
#include <vector>
#include "sender/sender.h"

using namespace std;
vector<int> temperatureValueList;
vector<int> stateOfChargeValueList;

TEST_CASE("Test 1 : Check whether any random temperature values are generated or not if MAX value = MIN value") {
  temperatureValueList = getTemperatureValues(TEMPERATURE_MAX_VALUE ,TEMPERATURE_MAX_VALUE, READINGS_IN_STREAM);
  bool isTemperatureBufferEmpty = temperatureValueList.empty();
  REQUIRE(isTemperatureBufferEmpty == true);
  int temperatureBufferSize = temperatureValueList.size();
  REQUIRE(temperatureBufferSize == 0);
}

TEST_CASE("Test 2 : Check whether any random random State Of Charge values are generated or not if MAX value = MIN value") {
  stateOfChargeValueList = getStateOfChargeValues(STATE_OF_CHARGE_MAX_VALUE ,STATE_OF_CHARGE_MAX_VALUE, READINGS_IN_STREAM);
  bool isStateOfChargeBufferEmpty = stateOfChargeValueList.empty();
  REQUIRE(isStateOfChargeBufferEmpty == true);
  int stateOfChargeBufferSize = stateOfChargeValueList.size();
  REQUIRE(stateOfChargeBufferSize == 0);
}

TEST_CASE("Test 3 : Check whether any temperature, SOC values are sent to console if MAX value = MIN value") {
  bool isSendSensorDataToConsole = sendSensorDataToConsole(temperatureValueList, stateOfChargeValueList);
  REQUIRE(isSendSensorDataToConsole == false);
}

TEST_CASE("Test 4 : Check whether any random temperature values are generated or not if value range is 0") {
  temperatureValueList = getTemperatureValues(TEMPERATURE_MAX_VALUE ,TEMPERATURE_MIN_VALUE, 0);
  bool isTemperatureBufferEmpty = temperatureValueList.empty();
  REQUIRE(isTemperatureBufferEmpty == true);
  int temperatureBufferSize = temperatureValueList.size();
  REQUIRE(temperatureBufferSize == 0);
}

TEST_CASE("Test 5 : Check whether any random random State Of Charge values are generated or not if value range is 0") {
  stateOfChargeValueList = getStateOfChargeValues(STATE_OF_CHARGE_MAX_VALUE ,STATE_OF_CHARGE_MIN_VALUE, 0);
  bool isStateOfChargeBufferEmpty = stateOfChargeValueList.empty();
  REQUIRE(isStateOfChargeBufferEmpty == true);
  int stateOfChargeBufferSize = stateOfChargeValueList.size();
  REQUIRE(stateOfChargeBufferSize == 0);
}

TEST_CASE("Test 6 : Check whether any temperature, SOC values are sent to console if value range is 0") {
  bool isSendSensorDataToConsole = sendSensorDataToConsole(temperatureValueList, stateOfChargeValueList);
  REQUIRE(isSendSensorDataToConsole == false);
}

TEST_CASE("Test 7 : Check whether 50 random temperature values are generated or not") {
  temperatureValueList = getTemperatureValues(TEMPERATURE_MAX_VALUE ,TEMPERATURE_MIN_VALUE, READINGS_IN_STREAM);
  bool isTemperatureBufferEmpty = temperatureValueList.empty();
  REQUIRE(isTemperatureBufferEmpty == false);
  int temperatureBufferSize = temperatureValueList.size();
  REQUIRE(temperatureBufferSize == READINGS_IN_STREAM);
}

TEST_CASE("Test 8 : Check whether 50 random SOC values are generated or not") {
  stateOfChargeValueList = getStateOfChargeValues(STATE_OF_CHARGE_MAX_VALUE ,STATE_OF_CHARGE_MIN_VALUE, READINGS_IN_STREAM);
  bool isStateOfChargeBufferEmpty = stateOfChargeValueList.empty();
  REQUIRE(isStateOfChargeBufferEmpty == false);
  int stateOfChargeBufferSize = stateOfChargeValueList.size();
  REQUIRE(stateOfChargeBufferSize == READINGS_IN_STREAM);
}

TEST_CASE("Test 9 : Check whether 50 random temperature, SOC values are sent to console successfully") {
  bool isSendSensorDataToConsole = sendSensorDataToConsole(temperatureValueList, stateOfChargeValueList);
  REQUIRE(isSendSensorDataToConsole == true);
}
