#!/bin/bash
BASEDIR=$(dirname $0)

pushd $BASEDIR/Assets/Lib
ln -s ../../../MGFX MGFX
popd