#!/bin/bash

if [ "$#" -ne 1 ]; then
    echo "Illegal number of parameters. Enter the number of iterations to run."
    exit
fi

echo "*** This Master script will build and test all Memcached Benchmarks instrumented with Nekara APIs. ***"

SCRIPT=$(readlink -f "$0")
THIS_DIR=$(dirname "$SCRIPT")

cd $THIS_DIR/MCBug2/memcached/
sh BuildAndTest.sh $1

cd ../..
cd $THIS_DIR/MCBug5/memcached-127/memcached-1.4.4/
sh BuildAndTest.sh $1

cd ../../..
cd $THIS_DIR/MCBug8/memcached/
sh BuildAndTest.sh $1


echo "*** This Master script for all Memcached Benchmarks is completed***"
