@echo off

set SRC=Proto
for %%i in (%SRC%\*.proto) do (    
echo %%i  
protoc -I=%SRC% --csharp_out=..\JekoClient\GameClient\JekoClient\Assets\Script\DTO %%i

)
echo copy cs to combat server path ...
copy ..\JekoClient\GameClient\JekoClient\Assets\Script\DTO\*.cs ..\JekoAllServer\CommonCode\MsgList
pause
