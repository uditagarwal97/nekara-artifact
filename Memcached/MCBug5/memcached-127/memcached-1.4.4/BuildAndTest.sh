#!/bin/bash

if [ "$#" -ne 1 ]; then
    echo "Illegal number of parameters. Enter the number of iterations to run."
    exit
fi

N=$1

echo "*** This script will build and test memcached, instrumented with Nekara APIs. ***"
echo "*** We will run the test case $N times and will report the average number of iterations in which bug could be triggered. ***"
echo "*** It will take around 60 minutes (for 100 iterations) for this script to complete. Please press [Enter] to continue... ***"

# Cleanup
sh Clean.sh

# Build coyote-scheduler
cd include_coyote/coyote-scheduler && mkdir build && cd ./build && cmake -G Ninja .. && ninja -j3 && cp ./src/libcoyote.so ../../ && cd ../../

# Build coyote's FFI wrapper
g++ -std=c++11 -shared -fPIC -I./ -g -o libcoyote_c_ffi.so coyote_c_ffi.cpp -lcoyote -L./
export LD_LIBRARY_PATH=$PWD:$LD_LIBRARY_PATH
cd ../

# Build memcached
mkdir build && cd build && ../configure && make memcached-debug

sum=0
# Run test for 100 iterations
for i in $(seq 1 $N);
	do
		echo "\n\n **** Running test iteration # $i ****\n\n"
		rm coyote_output.txt
		nohup ./memcached-debug 
		sum=$((sum + $(cat coyote_output.txt | grep -c "iteration")))
		cat output.out | tail -n 1
done

avg=$(echo $sum / $N | bc -l | awk '{printf("%d\n",$1 + 0.5)}')

echo "\n\n\e[0;33m average number of iterations in which bug could be triggered: $avg \e[0m"

cd .. && mkdir TestResults
echo "[Memcached Bug#5] Average number of iterations ($N) in which bug could be triggered: $avg" > TestResults/memcached_bug5_results.txt

