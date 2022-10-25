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
  REQUIRE(temperatureValueList.empty() == true);
  REQUIRE(temperatureValueList.size() == 0);
}

TEST_CASE("Test 2 : Check whether any random random State Of Charge values are generated or not if MAX value = MIN value") {
  stateOfChargeValueList = getStateOfChargeValues(STATE_OF_CHARGE_MAX_VALUE ,STATE_OF_CHARGE_MAX_VALUE, READINGS_IN_STREAM);
  REQUIRE(stateOfChargeValueList.empty() == true);
  REQUIRE(stateOfChargeValueList.size() == 0);
}

TEST_CASE("Test 3 : Check whether any temperature, SOC values are sent to console if MAX value = MIN value") {
  REQUIRE(sendSensorDataToConsole(temperatureValueList, stateOfChargeValueList) == false);
}

TEST_CASE("Test 4 : Check whether any random temperature values are generated or not if value range is 0") {
  temperatureValueList = getTemperatureValues(TEMPERATURE_MAX_VALUE ,TEMPERATURE_MIN_VALUE, 0);
  REQUIRE(temperatureValueList.empty() == true);
  REQUIRE(temperatureValueList.size() == 0);
}

TEST_CASE("Test 5 : Check whether any random random State Of Charge values are generated or not if value range is 0") {
  stateOfChargeValueList = getStateOfChargeValues(STATE_OF_CHARGE_MAX_VALUE ,STATE_OF_CHARGE_MIN_VALUE, 0);
  REQUIRE(stateOfChargeValueList.empty() == true);
  REQUIRE(stateOfChargeValueList.size() == 0);
}

TEST_CASE("Test 6 : Check whether any temperature, SOC values are sent to console if value range is 0") {
  REQUIRE(sendSensorDataToConsole(temperatureValueList, stateOfChargeValueList) == false);
}

TEST_CASE("Test 7 : Check whether 50 random temperature values are generated or not") {
  temperatureValueList = getTemperatureValues(TEMPERATURE_MAX_VALUE ,TEMPERATURE_MIN_VALUE, READINGS_IN_STREAM);
  REQUIRE(temperatureValueList.empty() == false);
  REQUIRE(temperatureValueList.size() == READINGS_IN_STREAM);
}

TEST_CASE("Test 8 : Check whether 50 random SOC values are generated or not") {
  stateOfChargeValueList = getStateOfChargeValues(STATE_OF_CHARGE_MAX_VALUE ,STATE_OF_CHARGE_MIN_VALUE, READINGS_IN_STREAM);
  REQUIRE(stateOfChargeValueList.empty() == false);
  REQUIRE(stateOfChargeValueList.size() == READINGS_IN_STREAM);
}

TEST_CASE("Test 9 : Check whether 50 random temperature, SOC values are sent to console successfully") {
  REQUIRE(sendSensorDataToConsole(temperatureValueList, stateOfChargeValueList) == true);
}
