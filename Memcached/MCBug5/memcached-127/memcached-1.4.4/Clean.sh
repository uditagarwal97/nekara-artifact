#!/bin/bash

rm -rf ./build
rm -rf ./TestResults
rm include_coyote/*.so 2> /dev/null
rm -r include_coyote/coyote-scheduler/build/ 2> /dev/null
rm -r include_coyote/coyote-scheduler/bin/ 2> /dev/null
