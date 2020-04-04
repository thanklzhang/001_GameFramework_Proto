#!usr/bin/python
#coding=gbk

# fileProtoList=[]
# fileDBList=[]
# protoFilePath='..\\003_OnePunchMan_Server\\OnePunchManServers\\Protocol\\'
# dataFilePath='..\\003_OnePunchMan_Server\\OnePunchManServers\\Data\\'
# protoFileClientPath='..\\002_OnePunchMan_Client\OnepunchManProject\Assets\Scripts\Protocol\\'
# protoFileClientLuaPath='..\\002_OnePunchMan_Client\\LuaProject\protopb\\'
# errorcodeFile = '..\\006_OnePunchMan_Config\\Dev\\err_code.xlsx'
# errProtoFile = '.\\Protocol\\ResultCode.proto'
import os  
import string
import traceback
import openpyxl
import sys
import time
import re
import shutil

definestr=""

baseDir=os.getcwd()

def get_proto_file_list(dir,flist):
    print("\n")

    print("start get proto files ...")
    print("\n")
    for root, dirs, files in os.walk(dir,True): 
        for name in files:  
            nm = os.path.splitext(name)
            if (nm[1] == ".proto"):
                flist.append(name)
                print("find file : " + name)
                # tmpCmd=('(copy %s %s /y)' %(os.path.join(root, name),baseDir))
                # print(tmpCmd)
                # os.system(tmpCmd)

def Dump(f,str):
        file_part=open(f,'wb')
        file_part.write(str.encode('UTF-8'))
        file_part.close()
                                
def getCmdID(dir,inputFiles,outFile):
        print("\n")
        optionStr = ""
        for currFile in inputFiles:    
            fc = open(dir + "\\" + currFile ,'rb')
            print("currFile : " + currFile)
            line=fc.readline()
            content=[]
            while line:
                   
                    content.append(line)
                    line=fc.readline()
            optionStr += "\t//" + currFile.split('.')[0] + "\n"
            lineNum = 0
            start = -1
            isFinish = False
          
            msdIdIndex = 0
            rightIndex = -1
            for c in content:
                realContent=c
                if(not isFinish):
                    msdIdIndex = realContent.decode('utf-8').find('MsgId')
                    if(msdIdIndex > 0):
                      
                        start = lineNum
                    
                    if(start >= 0):
                        rightIndex = realContent.decode('utf-8').find("}")
                        if(rightIndex >= 0):
                            isFinish = True
                        else:
                                currStrs = realContent.decode('utf-8').split('=')
                                if(len(currStrs)>1):
                                        
                                            leftValue = currStrs[0].strip()
                                            if(leftValue != "First" and leftValue != "Begin" and leftValue != "End"):
                                                rightValue = currStrs[1].strip()
                                                print(leftValue + " = " + rightValue)
                                                rightValue = rightValue.replace(";",",");
                                                optionStr += "\t" + leftValue + " = " + rightValue + "\n"
                                else:
                                    describeStr = realContent.decode('utf-8').split('//')
                                    if(len(describeStr) > 1):
                                        optionStr += realContent.decode('utf-8')
                                        print(realContent.decode('utf-8'))
                    
                    lineNum = lineNum + 1
            print("\n")
            optionStr += "\n"
            fc.close()
        
        allStr = "//gen by tool\npublic enum ProtoMsgIds\n{\n" + optionStr + "}\n"
        
        Dump(outFile,allStr)
        return 
        
def main():
        try:
                # tmpCmd=('.\protoc.exe .\%s.proto --lua_out=.\ --plugin=protoc-gen-lua=.\plugin\protoc-gen-lua.bat &(move /y .\*.lua %s  >nul)' %(f,protoFileClientLuaPath))
                # print("processing %s.proto 2 lua" %(f))
                # os.system(tmpCmd)

                fileProtoList = []
                fileDir = "Proto"
                get_proto_file_list(baseDir + "\\" + fileDir,fileProtoList)

                # for f in fileProtoList:
                    
                getCmdID(fileDir,fileProtoList,"Outpath\\ProtoMsgIds.cs")
                #fdf = ("--server 2 client proto def -- \nProtoEnum = {\n%s}" %(definestr))
                #Dump(("%s//protodefine.lua" %(protoFileClientLuaPath)),fdf)
        
                #os.system('(move /y .\CmdEnum.cs  %s   >nul)' %(protoFileClientPath))
                os.system("pause")
        except:
                print("!!!!!!catch exception!!!!!!")
                traceback.print_exc()
                os.system("pause")
                
        #os.system("pause")
main()
#print("------------------")
