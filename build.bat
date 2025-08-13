@echo off

REM Navigate to the website source directory
cd /d "C:\Users\Intel\Documents\GitHub\RobloxWebsite-2013-\Website\Source"

REM Build the project using MSBuild
REM Note: You may need to adjust the path to MSBuild based on your Visual Studio installation
"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" Roblox.Website.csproj /p:Configuration=Debug /m

REM Check the exit code
if %errorlevel% equ 0 (
  echo Build succeeded!
) else (
  echo Build failed with error level %errorlevel%
)

pause
