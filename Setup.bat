@echo off
pushd %~dp0
echo Creating Directories...
if not exist Assets mkdir Assets
if not exist Assets\Lib mkdir Assets\Lib
if not exist Assets\App mkdir Assets\App
echo Linking...
mklink /d "Assets\Lib\MGFX" "..\..\..\MGFX"
popd
pause