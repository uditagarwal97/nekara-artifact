#!/bin/bash

rm -rf ./build
rm -rf ./TestResults
rm include_coyote/include*.so 2> /dev/null
rm coyotest/*.so 2> /dev/null
rm -r include_coyote/include/coyote-scheduler/build/ 2> /dev/null
rm -r include_coyote/include/coyote-scheduler/bin/ 2> /dev/null
