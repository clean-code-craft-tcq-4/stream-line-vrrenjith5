#include <iostream>
#include "sender.h"
#define CATCH_CONFIG_MAIN
#include "test/catch.hpp"

using namespace std;

TEST_CASE("Test 1 : Check whether 50 random temperature values are generated or not") {
  vector<int> generatedTemperatureValues = generateTemperatureValues(TEMPERATURE_MAX_VALUE ,TEMPERATURE_MIN_VALUE, READINGS_IN_STREAM);
  bool isTemperatureBufferEmpty = generatedTemperatureValues.empty();
  REQUIRE(isTemperatureBufferEmpty == false);
  int temperatureBufferSize = generatedTemperatureValues.size();
  REQUIRE(temperatureBufferSize == READINGS_IN_STREAM);
}

TEST_CASE("Test 2 : Check whether 50 random SOC values are generated or not") {
  vector<int> generatedSocValues = generateSocValues(SOC_MAX_VALUE ,SOC_MIN_VALUE, READINGS_IN_STREAM);
  bool isSocBufferEmpty = generatedSocValues.empty();
  REQUIRE(isSocBufferEmpty == false);
  int socBufferSize = generatedSocValues.size();
  REQUIRE(socBufferSize == READINGS_IN_STREAM);
}

TEST_CASE("Test 3 : Check whether 50 random temperature, SOC values are sent to console successfully") {
  bool isSendSensorDataToConsole = sendSensorDataToConsole();
  REQUIRE(isSendSensorDataToConsole == true);
}


