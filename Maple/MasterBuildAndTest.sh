#!/bin/bash

if [ "$#" -ne 1 ]; then
    echo "Illegal number of parameters. Enter the number of iterations to run."
    exit
fi

echo "*** This Master script will build and test all Maple Benchmarks instrumented with Nekara APIs. ***"

SCRIPT=$(readlink -f "$0")
THIS_DIR=$(dirname "$SCRIPT")

# Create directory for adding results
if [ ! -d "$THIS_DIR/Results" ]
then
        mkdir $THIS_DIR/Results
fi
rm $THIS_DIR/Results/*

cd $THIS_DIR/memcached-127/memcached-1.4.4/
sh BuildAndTest.sh $1
cd ../..

cp $THIS_DIR/memcached-127/memcached-1.4.4/TestResults/* $THIS_DIR/Results/

cd $THIS_DIR/pbzip2-0.9.4/pbzip2-0.9.4/
sh BuildAndTest.sh $1
cd ../..

cp $THIS_DIR/pbzip2-0.9.4/pbzip2-0.9.4/TestResults/* $THIS_DIR/Results/

cd $THIS_DIR/streamcluster/src/
sh BuildAndTest.sh $1
cd ../../

cp $THIS_DIR/streamcluster/src/TestResults/* $THIS_DIR/Results/

echo "*** This Master script for all Maple Benchmarks is completed ***"
echo "*** You can find the results under the $THIS_DIR/Results folder ***"
