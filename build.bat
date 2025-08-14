@echo off

REM Navigate to the website directory
cd /d "C:\Users\Intel\Documents\GitHub\RobloxWebsite-2013-\Website"

REM Build the project using MSBuild
REM Note: You may need to adjust the path to MSBuild based on your Visual Studio installation
"C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" Roblox.Website.csproj /p:Configuration=Debug /m

REM Check the exit code
if %errorlevel% equ 0 (
  echo Build succeeded!
) else (
  echo Build failed with error level %errorlevel%
  pause
  exit /b %errorlevel%
)

pause
