@echo off

set clientSRC=proto
set clientDES=outpath

set serSRC=proto\server
set serDES=outpath\server

REM set copyClientOutPath = "..\001_GameFramework_Client\Assets\Script\Data\Define\Protobuf"
REM set copyServerOutPath = "GameServer\GameServer\ProtoMsgModel"

echo gen client cs ----------------------------
for %%i in (%clientSRC%\*.proto) do (    
echo %%i  
protoc -I=%clientSRC% --csharp_out=%clientDES% %%i
)

echo gen server cs ----------------------------
for %%i in (%serSRC%\*.proto) do (    
echo %%i  
protoc -I=%serSRC% --csharp_out=%serDES% %%i --proto_path=%clientSRC%
)

echo copy cs to client path ----------------------------
copy %clientDES%\*.cs "..\001_GameFramework_Client\Assets\Script\Data\Define\Protobuf"

echo copy cs to server path ----------------------------
copy %serDES%\*.cs "..\001_GameFramework_Server\GameServer\Common\ProtoMsgModel\Server"
copy %clientDES%\*.cs "..\001_GameFramework_Server\GameServer\Common\ProtoMsgModel"

echo copy cs to pure battle logic path ----------------------------
copy %serDES%\*.cs "..\001_GameFramework_Battle\BattleProject\Common\ProtoMsgModel\Server"
copy %clientDES%\*.cs "..\001_GameFramework_Battle\BattleProject\Common\ProtoMsgModel"

::python gen_cs_proto_msg_ids.py

echo finish!



pause
