#!/bin/bash

apt-get update
apt-get upgrade -y

apt-get install git libevent-dev cmake ninja-build autoconf g++ bc -y
git config --global core.autocrlf false
