SET SWIGPATH=..\..\..\swigwin-1.3.40

erase /s /q SwigOutput\*.*

%SWIGPATH%\swig.exe -csharp -c++ -outdir SwigOutput -dllimport __Internal bwapi-bridge.i
