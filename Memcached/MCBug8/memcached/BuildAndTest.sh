#!/bin/bash

if [ "$#" -ne 1 ]; then
    echo "Illegal number of parameters. Enter the number of iterations to run."
    exit
fi

N=$1

echo "*** This script will build and test Memcached (Bug#8), instrumented with Nekara APIs. ***"
echo "*** We will run the test case $N times and will report the average number of iterations in which bug could be triggered. ***"
echo "*** It will take around 10 minutes for this script to complete.***"

# Cleanup
sh Clean.sh

cd include_coyote/include

cd coyote-scheduler && mkdir build && cd ./build && cmake -G Ninja .. && ninja -j3 && cp ./src/libcoyote.so ../../ && cd ../../

# Build coyote's FFI wrapper
g++ -std=c++11 -shared -fPIC -I./ -g -o libcoyote_c_ffi.so coyote_c_ffi.cpp -lcoyote -L./
g++ -std=c++11 -shared -fPIC -I./ -g -o libmock_libevent.so mock_libevent.cpp -lcoyote_c_ffi -lcoyote -L./
export LD_LIBRARY_PATH=$PWD:$LD_LIBRARY_PATH
cd ../../

cd coyotest
g++ -std=c++11 -shared -fPIC -I./ -g -o libcoyotest.so mc-stress-test.cpp -g -L../include_coyote/include -lcoyote_c_ffi -lcoyote
export LD_LIBRARY_PATH=$PWD:$LD_LIBRARY_PATH
cd ..

# Build Memcached
./autogen.sh
mkdir build
cd build
../configure
make memcached-debug -j2

# Test
mkdir ../TestResults/

sum=0
# Run test for 100 iterations
for i in $(seq 1 $N);
	do
		# echo "\n\n **** Running test iteration # $i ****\n\n"
		rm coyote_output.txt
		nohup ./memcached-debug
		sum=$((sum + $(cat coyote_output.txt | grep -c "iteration")))
		# cat nohup.out | tail -n 1
done

avg=$(echo $sum / $N | bc -l | awk '{printf("%d\n",$1 + 0.5)}')

echo "\n\n\e[0;33m Average number of iterations in which bug could be triggered: $avg \e[0m"

cd ..
echo "[Memcached Bug#8] Average number of iterations ($N) in which bug could be triggered: $avg" > TestResults/memcached_bug8_results.txt
