#!/bin/bash

if [ "$#" -ne 1 ]; then
    echo "Illegal number of parameters. Enter the number of iterations to run."
    exit
fi

echo "*** This Master script will build and test all Memcached Benchmarks instrumented with Nekara APIs. ***"

SCRIPT=$(readlink -f "$0")
THIS_DIR=$(dirname "$SCRIPT")

# Create directory for adding results
if [ ! -d "$THIS_DIR/Results" ]
then
	mkdir $THIS_DIR/Results
fi
rm $THIS_DIR/Results/*

# Run expriment for Mmemcached Bug#2
cd $THIS_DIR/MCBug2/memcached/
sh BuildAndTest.sh $1
cd ../..

cp $THIS_DIR/MCBug2/memcached/TestResults/* ./Results/

cd $THIS_DIR/MCBug5/memcached-127/memcached-1.4.4/
sh BuildAndTest.sh $1
cd ../../..

cp $THIS_DIR/MCBug5/memcached-127/memcached-1.4.4/TestResults/* ./Results/

cd $THIS_DIR/MCBug8/memcached/
sh BuildAndTest.sh $1
cd ../..

cp $THIS_DIR/MCBug8/memcached/TestResults/* ./Results/

echo "*** This Master script for all Memcached Benchmarks is completed ***"
echo "*** You can find the results under the $THIS_DIR/Results folder ***"
