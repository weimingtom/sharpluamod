# sharpluamod
My mod of sharplua, with vs2013 native code debugging  
**WIP**: A mod and fork of sharplua, for getting a lite P/Invoke CLR Lua

## Run with sharpdevelop  
see sharplua_sharpdevelop.sln  
it copy sharplua.dll to output folder in project  

## About unmanaged code debugging  
* Please use vs2013 to open sharpluatest_vs2013.sln  
* Please check 'Enable native code debugging' in sharpluatest_vs2013 project Debug tab  
see https://www.technipages.com/visual-studio-native-code-debugging  
* When debugging, click menu 'Debug->Exception' and enable all exceptions  

## build sharplua.dll  
* use vc6 to open sharplua_vc6.dsw  
