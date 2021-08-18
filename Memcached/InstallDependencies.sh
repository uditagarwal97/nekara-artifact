#!/bin/bash

sudo apt-get update
sudo apt-get upgrade -y

sudo apt-get install git libevent-dev cmake ninja-build autoconf g++ -y
git config --global core.autocrlf false
