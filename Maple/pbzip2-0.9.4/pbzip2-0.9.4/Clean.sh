#!/bin/bash

rm nohup*
rm -r TestResults
make clean 2> /dev/null
rm include_coyote/*.so 2> /dev/null
rm -r include_coyote/coyote-scheduler/build/ 2> /dev/null
rm -r include_coyote/coyote-scheduler/bin/ 2> /dev/null
