# UnrealSetupCacheBuilder #

A simple tool to create local cache for Unreal Engine 4 source Setup.bat

## Usage ##

1. On a PC with internet connection
   1. Run Setup.bat
   2. Run this tool
   3. Choose Unreal Engine path
   4. Choose Cache path (<Your Engine Path>/.git/ue4-gitdeps by default)
   5. Choose Target path where you want your local cache to be saved in (e.g. D:\UnrealSetupCache)
   6. Hit Build and wait for it to finish
   7. Copy it to a USB drive or a local network storage
2. On another PC
   1. Open <Your Engine Path>/Engine/Build/Commit.gitdeps.xml with a text editor
   2. On line 2 modify BaseUrl to the path of your local cache (e.g. BaseUrl="D:/UnrealSetupCache") and save the file
   3. Run Setup.bat, preferably with --no-cache parameter to save disk space
