@echo off

set SRC=Proto
for %%i in (%SRC%\*.proto) do (    
echo %%i  
protoc -I=%SRC% --csharp_out=Outpath %%i

)

echo copy cs to client path ...

copy Outpath\*.cs ..\JekoClient\GameClient\JekoClient\Assets\Script\Data\ProtobufData

echo copy cs to server path ...

copy Outpath\*.cs ..\JekoAllServer\CommonCode\NetMsg

python gen_cs_proto_msg_ids.py


pause
